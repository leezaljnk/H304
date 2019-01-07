using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PMIS.DataCore;

namespace Common.Winforms.UserControls
{
    public partial class DonViFullSelect : Form
    {
        public DonViFullSelect()
        {
            InitializeComponent();
            if (LoaiGDDT == 0)
                pagBranch.SelectedPage = pagBranch.Pages[0];
            else
                pagBranch.SelectedPage = pagBranch.Pages[1];
        }
        public IList<DONVI> DonViCollection { get; set; }
        public IList<TRUONG> TruongCollection { get; set; }
        public IList<CAPTRUONG> CapTruongCollection { get; set; }
        public IList<TINH> TinhCollection { get; set; }
        public Guid? DonViId { get; set; }
        public string MaDonVi { get; set; }
        public string TenDonVi { get; set; }
        public int CapDonVi { get; set; }
        public int LoaiGDDT { get; set; }
        public string MaTinhThanhPho { get; set; }
        public BranchEntity BranchSelect { get; set; }
        private void InitTrvDG()
        {
            trvDonViGD.Nodes.Clear();
            if (DonViCollection == null || DonViCollection.Count == 0) return;
            //Add cap Bo
            DONVI bo = DonViCollection.Where(e => e.DonViId == Guid.Empty).SingleOrDefault();
            if (bo == null) return;
            TreeNode root = new TreeNode();
            root.Text = bo.TenDonvi;
            root.Tag = bo;
            root.ImageIndex = 0;
            root.SelectedImageIndex = 4;
            //Add So 
            IList<DONVI> soColl = DonViCollection.Where(e => e.PhongId == null && e.DonViId != bo.DonViId).OrderBy(p => p.ma_donvi).ToList();
            foreach (DONVI so in soColl)
            {
                TreeNode soNode = new TreeNode();
                soNode.Text = so.TenDonvi;
                soNode.Tag = so;
                soNode.ImageIndex = 1;
                soNode.SelectedImageIndex = 4;
                //Add phong
                IList<DONVI> phongColl = DonViCollection.Where(e => e.SoId == so.SoId && e.PhongId !=null).OrderBy(p => p.ma_donvi).ToList();
                foreach (DONVI phong in phongColl)
                {
                    TreeNode phongNode = new TreeNode();
                    phongNode.Text = phong.TenDonvi;
                    phongNode.Tag = phong;
                    phongNode.ImageIndex = 2;
                    phongNode.SelectedImageIndex = 4;
                    soNode.Nodes.Add(phongNode);
                }
                root.Nodes.Add(soNode);
            }
            trvDonViGD.Nodes.Add(root);
        }

        private void InitTrvDT()
        {
            trvDonViDT.Nodes.Clear();
            if (DonViCollection == null || DonViCollection.Count == 0||CapTruongCollection ==null ||CapTruongCollection.Count ==0) return;
            //Add cap Bo
            DONVI bo = DonViCollection.Where(e => e.DonViId == Guid.Empty).SingleOrDefault();
            if (bo == null) return;
            TreeNode root = new TreeNode();
            root.Text = bo.TenDonvi;
            root.Tag = bo;
            root.ImageIndex = 0;
            root.SelectedImageIndex = 4;
            //Add cap hoc
            foreach (CAPTRUONG ctr in CapTruongCollection)
            {
                TreeNode capNode = new TreeNode();
                capNode.Text = ctr.TenCapTruong;
                capNode.Tag = ctr;
                capNode.ImageIndex = 1;
                capNode.SelectedImageIndex = 4;
                foreach (TINH tinh in TinhCollection)
                {
                    TreeNode tinhNode = new TreeNode();
                    tinhNode.Text = tinh.ten_tinh;
                    tinhNode.Tag = tinh;
                    tinhNode.ImageIndex = 2;
                    tinhNode.SelectedImageIndex = 4;
                    AddTruongCapHocNode(ctr.CapTruongId, tinh.ma_tinh, tinhNode);
                    capNode.Nodes.Add(tinhNode);
                }
                root.Nodes.Add(capNode);
            }            
            trvDonViDT.Nodes.Add(root);
        }

        private void AddTruongCapHocNode(int capHocId, string maTinh, TreeNode capNode)
        {
            IList<TRUONG> truongColl = TruongCollection.Where(e => e.CapTruongId == capHocId && e.ma_tinh == maTinh).OrderBy(p => p.MaTruong).ToList();
            foreach(TRUONG tr in truongColl)
            {
                TreeNode trNode = new TreeNode();
                trNode.Text = tr.TenTruong;
                trNode.Tag = tr;
                trNode.ImageIndex = 3;
                trNode.SelectedImageIndex = 4;
                capNode.Nodes.Add(trNode);
            }
        }

        private void DonViFullSelect_Load(object sender, EventArgs e)
        {
            InitTrvDG();
            InitTrvDT();
        }

        private void trvDonViGD_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (trvDonViGD.SelectedNode != null) btnOK.Enabled = true;
        }

        private void trvDonViDT_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = trvDonViDT.SelectedNode;
            if (node != null)
            {
                TRUONG capTruong = node.Tag as TRUONG;
                if (capTruong == null)
                {
                    btnOK.Enabled = false;
                }
                else
                {
                    btnOK.Enabled = true;
                }
            }
            else
            {
                btnOK.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void DonViFullSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                BranchSelect = null;
                if (pagBranch.SelectedPage == pagBranch.Pages[0])
                {
                    DONVI dv = trvDonViGD.SelectedNode.Tag as DONVI;
                    if (dv == null) return;
                    BranchSelect = new BranchEntity();
                    DonViId = dv.DonViId;
                    MaDonVi = dv.ma_donvi;
                    TenDonVi = dv.TenDonvi;
                    MaTinhThanhPho = dv.ma_tinh;
                    
                    LoaiGDDT = 0;
                    if (dv.DonViId == Guid.Empty)
                    {
                        CapDonVi = (int)CAPQUANLY.BO;
                        BranchSelect.Level = CAPQUANLY.BO;
                    }
                    else
                    {
                        CapDonVi = dv.PhongId == null ? (int)CAPQUANLY.SO : (int)CAPQUANLY.PHONG;
                        BranchSelect.Level = dv.PhongId == null ? CAPQUANLY.SO : CAPQUANLY.PHONG;
                    }
                    BranchSelect.BranchId = Converter.Obj2Guid(DonViId);
                    BranchSelect.BranchCode = MaDonVi;
                    BranchSelect.BranchName = TenDonVi;
                    BranchSelect.MaTinh = MaTinhThanhPho;
                    BranchSelect.MaQuan = dv.ma_qh;
                    BranchSelect.Address = dv.Diachi;
                    BranchSelect.Email = dv.Email;
                    BranchSelect.PhoneNumber = dv.Dienthoai;
                    BranchSelect.Fax = dv.Fax;
                    BranchSelect.WebSite = dv.WebSite;
                }
                else
                {
                    TRUONG truong = trvDonViDT.SelectedNode.Tag as TRUONG;
                    if (truong != null)
                    {
                        LoaiGDDT = 1;
                        DonViId = truong.TruongId;
                        MaDonVi = truong.MaTruong;
                        TenDonVi = truong.TenTruong;
                        MaTinhThanhPho = truong.ma_tinh;
                        CapDonVi = (int)CAPQUANLY.TRUONG;
                        BranchSelect.BranchId = truong.TruongId;
                        BranchSelect.BranchCode = MaDonVi;
                        BranchSelect.BranchName = TenDonVi;
                        BranchSelect.MaTinh = MaTinhThanhPho;
                        BranchSelect.Level = CAPQUANLY.TRUONG;
                        BranchSelect.Address = truong.DiaChi;
                        BranchSelect.Email = truong.Email;
                        BranchSelect.PhoneNumber = truong.DienThoai;
                        BranchSelect.Fax = truong.Fax;
                        BranchSelect.WebSite = truong.WebSite;
                    }
                }
            }
        }
    }
}


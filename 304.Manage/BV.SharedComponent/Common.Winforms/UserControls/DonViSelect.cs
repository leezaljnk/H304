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
    public partial class DonViSelect : Telerik.WinControls.UI.RadForm
    {
        public DonViSelect()
        {
            InitializeComponent();
            //this.InitUserControl();
        }

        public bool ChonTruong { get; set; }
        public static bool IsShow { get; set; }
        public IList<DONVI> DonViSource { get; set; }
        public IList<TRUONG> TruongSource { get; set; }
        private IList<TRUONG> _truongCopy;
        public IList<PHONG_BAN> PhongBanSource { get; set; }
        public IList<TRUONG_PHONGBAN> _truongPhongCopy;
        public IList<TRUONG_PHONGBAN> TruongPhongBanSource { get; set; }
        public Guid? DonViId { get; set; }
        public string MaDonVi { get; set; }
        public string TenDonVi { get; set; }
        public int CapDonVi { get; set; }
        public int? CapTruongId { get; set; }
        public int? HangTruongId { get; set; }
        public string MaTinhThanhPho { get; set; }
        public string MaSo { get; set; }
        public BranchEntity BranchSelect { get; set; }
        public void DonViBind()
        {
            TreeNode nodeSo = null;
            trvDonVi.Nodes.Clear();
            List<TreeNode> lstNodePhong = new List<TreeNode>();
            if (DonViSource == null || DonViSource.Count == 0)//Là trường
            {
                if (PhongBanSource != null && PhongBanSource.Count > 0)
                {
                    TreeNode node = new TreeNode();
                    node.Text = PhongBanSource[0].TenDonVi;
                    node.Tag = PhongBanSource[0];
                    node.ImageIndex = 2;
                    node.SelectedImageIndex = 1;
                    trvDonVi.Nodes.Add(node);
                    AddSubPhongBan2Tree(node);
                }
                else
                {
                    if (TruongSource.Count == 0) return;
                    TreeNode node = new TreeNode();
                    node.Text = TruongSource[0].TenTruong;
                    node.Tag = TruongSource[0];
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 1;
                    AddPhongBan2Tree(node, TruongSource[0].TruongId);
                    lstNodePhong.Add(node);
                    trvDonVi.Nodes.Add(lstNodePhong[0]);
                }
            }
            else
            {
                foreach (DONVI dv in DonViSource)
                {
                    if (dv.PhongId == null) //la so
                    {
                        nodeSo = new TreeNode();
                        nodeSo.Tag = dv;
                        nodeSo.ImageIndex = 0;
                        nodeSo.SelectedImageIndex = 1;
                        nodeSo.Text = dv.TenDonvi;
                    }
                    else
                    {
                        //if (nodeSo == null) continue;
                        TreeNode node = new TreeNode();
                        node.Text = dv.TenDonvi;
                        node.Tag = dv;
                        node.ImageIndex = 0;
                        node.SelectedImageIndex = 1;
                        AddPhongBan2Tree(node, dv.DonViId);
                        //AddTruongToTree(node,dv.DonViId);
                        lstNodePhong.Add(node);
                    }
                }

                if (nodeSo != null)
                {
                    DONVI dv_so = nodeSo.Tag as DONVI;
                    if (dv_so == null) return;
                    AddPhongBan2Tree(nodeSo, dv_so.DonViId);
                    trvDonVi.Nodes.Add(nodeSo);
                    for (int i = 0; i < lstNodePhong.Count; i++)
                    {
                        nodeSo.Nodes.Add(lstNodePhong[i]);
                    }
                    //AddTruongToTree(nodeSo, dv_so.DonViId);

                }
                else
                {
                    for (int i = 0; i < lstNodePhong.Count; i++)
                    {
                        trvDonVi.Nodes.Add(lstNodePhong[i]);
                    }
                }
            }
            //Expand node level 1
            if (trvDonVi.Nodes.Count > 0)
                trvDonVi.Nodes[0].Expand();
            IsShow = true;
        }

        private void AddTruongToTree(TreeNode p_node, Guid donviId)
        {
            if (!ChonTruong) return;
            var found = from tr in _truongCopy
                        join p_tr in TruongPhongBanSource on tr.TruongId equals p_tr.TruongId
                        where p_tr.PhongBanId == donviId && (tr.InActive == null || tr.InActive == false)
                        select tr;
            foreach (TRUONG tr in found)
            {
                TreeNode node = new TreeNode(tr.TenTruong);
                node.SelectedImageIndex = 1;
                node.ImageIndex = 3;
                node.Tag = tr;
                AddPhongBan2Tree(node, tr.TruongId);
                p_node.Nodes.Add(node);
                //_truongCopy.Remove(tr);
            }

        }

        public void AddPhongBan2Tree(TreeNode p_node, Guid donviId)
        {
            if (PhongBanSource == null || PhongBanSource.Count == 0) return;
            //var found = PhongBanSource.Where(e => e.DonViId == donviId && e.ParentId == null).OrderBy(e=>e.MaPhongBan);
            var found = PhongBanSource.Where(e => e.DonViId == donviId && e.ParentId == null).OrderBy(e => e.MaPhongBan);
            foreach (PHONG_BAN item in found)
            {
                TreeNode node = new TreeNode(item.TenDonVi);
                node.Tag = item;
                node.ImageIndex = 2;
                node.SelectedImageIndex = 1;
                AddSubPhongBan2Tree(node);
                //AddTruongToTree(node, item.PhongBanId);
                p_node.Nodes.Add(node);
            }

        }

        public void AddSubPhongBan2Tree(TreeNode p_node)
        {
            if (PhongBanSource == null || PhongBanSource.Count == 0) return;
            PHONG_BAN parent = p_node.Tag as PHONG_BAN;
            if (parent == null) return;
            var found = PhongBanSource.Where(e => e.ParentId == parent.PhongBanId).OrderBy(e => e.MaPhongBan);
            foreach (PHONG_BAN item in found)
            {
                TreeNode node = new TreeNode(item.TenDonVi);
                node.Tag = item;
                node.ImageIndex = 2;
                node.SelectedImageIndex = 1;
                AddSubPhongBan2Tree(node);
                //AddTruongToTree(node, item.PhongBanId);
                p_node.Nodes.Add(node);
            }
        }
        private void DonViSelect_Load(object sender, EventArgs e)
        {
            _truongCopy = new List<TRUONG>();
            if (TruongSource != null)
                _truongCopy = _truongCopy.Concat(TruongSource).ToList();

            if (TruongPhongBanSource != null)
            {
                _truongPhongCopy = new List<TRUONG_PHONGBAN>();
                _truongPhongCopy = _truongPhongCopy.Concat(TruongPhongBanSource).ToList();
            }
            DonViBind();
            trvDonVi.Focus();
        }

        private void trvDonVi_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnOK.Enabled = true;
            if (ChonTruong && (e.Node.ImageIndex == 2))
            {
                PHONG_BAN phong = e.Node.Tag as PHONG_BAN;
                if (phong == null) return;
                e.Node.Nodes.Clear();
                AddSubPhongBan2Tree(e.Node);
                AddTruongToTree(e.Node, phong.PhongBanId);
            }
            e.Node.Expand();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void DonViSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                BranchSelect = new BranchEntity();
                DONVI dv = trvDonVi.SelectedNode.Tag as DONVI;
                TRUONG truong = trvDonVi.SelectedNode.Tag as TRUONG;
                PHONG_BAN phongBan = trvDonVi.SelectedNode.Tag as PHONG_BAN;
                if (dv != null) //don vi
                {
                    DonViId = dv.DonViId;
                    MaDonVi = dv.ma_donvi;
                    TenDonVi = dv.TenDonvi;
                    MaTinhThanhPho = dv.ma_tinh;
                    MaSo = dv.PhongId == null ? MaDonVi : string.Empty;
                    CapDonVi = dv.PhongId == null ? (int)CAPQUANLY.SO : (int)CAPQUANLY.PHONG;
                    BranchSelect.BranchId = Converter.Obj2Guid( DonViId);
                    BranchSelect.BranchCode = MaDonVi;
                    BranchSelect.BranchName = TenDonVi;
                    BranchSelect.MaTinh = MaTinhThanhPho;
                    BranchSelect.MaQuan = dv.ma_qh;
                    BranchSelect.MaXa = dv.ma_px;
                    BranchSelect.Level = dv.PhongId == null ? CAPQUANLY.SO : CAPQUANLY.PHONG;
                }
                else if (truong != null)
                {

                    DonViId = truong.TruongId;
                    MaDonVi = truong.MaTruong;
                    TenDonVi = truong.TenTruong;
                    MaTinhThanhPho = truong.ma_tinh;
                    CapDonVi = (int)CAPQUANLY.TRUONG;
                    CapTruongId = truong.CapTruongId;
                    HangTruongId = truong.HangTruongId;
                    BranchSelect.BranchId = truong.TruongId;
                    BranchSelect.BranchCode = MaDonVi;
                    BranchSelect.BranchName = TenDonVi;
                    BranchSelect.MaTinh = MaTinhThanhPho;
                    BranchSelect.Level = CAPQUANLY.TRUONG;
                    BranchSelect.CapTruongId = CapTruongId;
                    BranchSelect.HangTruongId = HangTruongId;
                }
                else if (phongBan != null)
                {
                    DonViId = phongBan.PhongBanId;
                    MaDonVi = phongBan.MaPhongBan;
                    TenDonVi = phongBan.TenDonVi;
                    CapDonVi = (int)CAPQUANLY.PHONGBAN;
                    DONVI dvi = DonViSource.Where(p => p.DonViId == phongBan.DonViId).SingleOrDefault();
                    BranchSelect.BranchId = phongBan.PhongBanId;
                    BranchSelect.DepartmentId = phongBan.PhongBanId;
                    BranchSelect.DepartmentName = phongBan.TenDonVi;
                    BranchSelect.Level = CAPQUANLY.PHONGBAN;
                    if (dvi != null)
                    {
                        BranchSelect.BranchCode = MaDonVi;
                        BranchSelect.BranchName = TenDonVi;
                        BranchSelect.MaTinh = MaTinhThanhPho = dvi.ma_tinh;
                        BranchSelect.MaQuan = dvi.ma_qh;
                        BranchSelect.MaXa = dvi.ma_px;
                    }
                    else
                    {
                        TRUONG trv = TruongSource.Where(p => p.TruongId == phongBan.DonViId).SingleOrDefault();
                        if (trv != null)
                        {
                            BranchSelect.BranchCode = MaDonVi;
                            BranchSelect.BranchName = TenDonVi;
                            BranchSelect.MaTinh = MaTinhThanhPho = trv.ma_tinh;
                            BranchSelect.MaQuan = trv.ma_qh;
                            BranchSelect.MaXa = trv.ma_px;
                        }
                    }                   
                }
            }
        }
    }
}

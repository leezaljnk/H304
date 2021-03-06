﻿using BV.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV.QLKHO.THUOC
{
    public partial class ThongTinThuocForm : Form
    {
        public Thuoc304 Entity { get; internal set; }
        private GiaThuoc _giaThuoc;
        private List<ChuyenDoiDonViThuoc> _lstDonVis = new List<ChuyenDoiDonViThuoc>();
        public ThongTinThuocForm()
        {
            InitializeComponent();
        }

        private void InitControl()
        {
            //Đường Dùng
            var lstDuongDung = KhoUtil.GetDanhMuc<ThuocDuongDung>();
            cboDuongDung.DataSource = lstDuongDung;
            cboDuongDung.DisplayMember = "DienGiai";

            //Ho tri lieu
            List<string> lstHoTriLieu = KhoUtil.GetDanhMuc<HoTriLieu>().Select(h => h.Ten).Distinct().ToList();//.GroupBy(h => h.Ten).ToList();
            cboHoTriLieu.DataSource = lstHoTriLieu;

            //Don Vi Thuoc
            var lstDonViThuoc = KhoUtil.GetDanhMuc<DonViThuoc>().OrderBy(t => t.Ten).ToList();

            cboDonVi.DataSource = lstDonViThuoc;
            cboDonVi.DisplayMember = "Ten";
            cboDonVi.ValueMember = "ID";

            clmDonVi.DataSource = lstDonViThuoc.ToList();
            clmDonVi.DisplayMember = "Ten";
            clmDonVi.ValueMember = "ID";
        }

        public void InitThongTin(Thuoc304 oThuoc)
        {
            //btnAddFromDmByt.Enabled = oThuoc != null;
            InitControl();

            this.Entity = oThuoc;
            if (Entity == null)
            {
                Entity = new Thuoc304() { ID = Guid.NewGuid() };
                _giaThuoc = new GiaThuoc() { ID = Guid.NewGuid(), ThuocID = Entity.ID };

                return;
            }

            _giaThuoc = KhoUtil.GetGiaThuoc(Entity.ID);
            if (_giaThuoc == null)
            {
                _giaThuoc = new GiaThuoc() { ID = Guid.NewGuid (), ThuocID = Entity.ID };
            }

            _lstDonVis = KhoUtil.GetChuyenDoiDonViThuoc(Entity.ID);

            txtTenThuoc.Text = Entity.TEN_THUOC;
            txtSoDangKy.Text = Entity.SO_DANG_KY;
            txtHoatChat.Text = Entity.HOAT_CHAT;
            txtHamLuong.Text = Entity.HAM_LUONG;
            cboDuongDung.Text = Entity.DUONG_DUNG;
            txtDongGoi.Text = Entity.DONG_GOI;
            cboHoTriLieu.Text = Entity.HO_TRI_LIEU;
            //Đơn vị tính giá
            cboDonVi.Value = _giaThuoc.DonViID;
            txtGiaDichVu.Text = _giaThuoc.GiaDichVu.ToString();
            txtGiaBH.Text = _giaThuoc.GiaBaoHiem.ToString();
            txtGiaCB.Text = _giaThuoc.GiaChinhSach.ToString();

            var lstChuyenDoiDonViThuoc = KhoUtil.GetChuyenDoiDonViThuoc(Entity.ID).OrderBy(d => d.TiLeChuyenDoi).ToList();
            int i = 0;
            foreach (var item in lstChuyenDoiDonViThuoc)
            {
                i++;
                object[] arr = new object[] { i.ToString(), item.DonViID, item.TiLeChuyenDoi, item.PhuongThucChuyenDoi == 0? "Chia" : "Nhân", item.MoTa };
                int index = dataGridView1.Rows.Add(arr);
                dataGridView1.Rows[index].Tag = item;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void ultraCombo1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            if (e.Layout.Bands.Count > 0)
            {
                foreach (var clm in e.Layout.Bands[0].Columns)
                {
                    //if (clm.Header.Caption == "TEN_THUOC")
                    //{
                    //    clm.Width = 200;
                    //    clm.Header.Caption = "Tên Thuốc";
                    //    //clm.Width = ultraCombo1.Width;
                    //}
                    //else if (clm.Header.Caption == "HAM_LUONG")
                    //{
                    //    clm.Header.Caption = "Hàm Lượng";
                    //}
                    //else if (clm.Header.Caption == "DONG_GOI")
                    //{
                    //    clm.Header.Caption = "Đóng Gói";
                    //}
                    //else if (clm.Header.Caption == "SO_DANG_KY")
                    //{
                    //    clm.Header.Caption = "Số Đăng Ký";
                    //}
                    //else if (clm.Header.Caption == "DONG_GOI")
                    //{
                    //    clm.Header.Caption = "Đóng Gói";
                    //}
                    //else
                    //{
                    //    clm.Hidden = true;
                    //}
                }
            }
        }

        private void btnAddFromDmByt_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                ThongTinThuocFormBYT oForm = new ThongTinThuocFormBYT();
                oForm.InitData();
                Cursor = Cursors.Default;
                if (oForm.ShowDialog(this) == DialogResult.OK)
                {
                    var oThuoc = oForm.Entity;
                    txtTenThuoc.Text = oThuoc.TEN_THUOC;
                    txtSoDangKy.Text = oThuoc.SO_DANG_KY;
                    txtHoatChat.Text = oThuoc.HOAT_CHAT;
                    txtHamLuong.Text = oThuoc.HAM_LUONG;
                    var lstDuongDung = KhoUtil.GetDanhMuc<ThuocDuongDung>();
                    var item = lstDuongDung.FirstOrDefault(t => t.ID == oThuoc.MA_DUONG_DUNG);
                    cboDuongDung.Text = item?.DienGiai ?? "";
                    txtDongGoi.Text = oThuoc.DONG_GOI;
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                HandleException(ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.BeginEdit(true);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dataGridView1.Rows[e.RowIndex];
            if (row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null)
            {
                var tenThuoc = KhoUtil.GetDanhMuc<DonViThuoc>().FirstOrDefault(t => t.ID.ToString() == row.Cells[1].Value.ToString());
                var dienGiai = "";
                if (row.Cells[3].Value.ToString() == "Nhân")
                {
                    dienGiai = $"1 {tenThuoc.Ten} = {row.Cells[2].Value} {cboDonVi.Text}";
                }
                else
                {
                    dienGiai = $"1 {tenThuoc.Ten} = 1/{row.Cells[2].Value} {cboDonVi.Text}";
                }

                row.Cells[4].Value = dienGiai;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateEntity()
        {
            bool bRet = true;
            if (string.IsNullOrWhiteSpace(txtTenThuoc.Text))
            {
                errorProvider1.SetError(txtTenThuoc, "thông tin không được bỏ trống");
                bRet = false;
            }

            if (cboDonVi.Value == null)
            {
                errorProvider1.SetError(cboDonVi, "thông tin không được bỏ trống");
                bRet = false;
            }

            if (string.IsNullOrWhiteSpace(txtGiaDichVu.Text))
            {
                errorProvider1.SetError(txtGiaDichVu, "thông tin không được bỏ trống");
                bRet = false;
            }

            //kiem tra gia thuoc
            int giaThuoc = 0;
            if (!int.TryParse(txtGiaDichVu.Text.Trim(), out giaThuoc))
            {
                errorProvider1.SetError(txtGiaDichVu, "phải là số");
                bRet = false;
            }

            if (!int.TryParse(txtGiaBH.Text.Trim(), out giaThuoc))
            {
                errorProvider1.SetError(txtGiaBH, "phải là số");
                bRet = false;
            }

            if (!int.TryParse(txtGiaCB.Text.Trim(), out giaThuoc))
            {
                errorProvider1.SetError(txtGiaCB, "phải là số");
                bRet = false;
            }

            //kiem tra chuyen doi don vi
            

            return bRet;
        }

        private void SaveEntity()
        {
            Thuoc304 oThuoc = new Thuoc304();
            oThuoc.ID = Entity.ID;
            oThuoc.TEN_THUOC = txtTenThuoc.Text;
            oThuoc.SO_DANG_KY = txtSoDangKy.Text;
            oThuoc.HOAT_CHAT = txtHoatChat.Text;
            oThuoc.HAM_LUONG = txtHamLuong.Text;
            oThuoc.DUONG_DUNG = cboDuongDung.Text;
            oThuoc.DONG_GOI = txtDongGoi.Text;
            oThuoc.HO_TRI_LIEU = cboHoTriLieu.Text;
            oThuoc.DonViID = (Guid)cboDonVi.Value;

            GiaThuoc oGiaThuoc = new GiaThuoc();
            if (_giaThuoc.ID == Guid.Empty)
            {
                _giaThuoc.ID = Guid.NewGuid();
                _giaThuoc.ThuocID = oThuoc.ID;
            }

            oGiaThuoc.ID = _giaThuoc.ID;
            oGiaThuoc.ThuocID = oThuoc.ID;
            oGiaThuoc.DonViID = (Guid)cboDonVi.Value;
            oGiaThuoc.GiaDichVu = decimal.Parse(txtGiaDichVu.Text);
            oGiaThuoc.GiaBaoHiem = decimal.Parse(txtGiaBH.Text);
            oGiaThuoc.GiaChinhSach = decimal.Parse(txtGiaCB.Text);

            //Don vi chuyen doi
            List<ChuyenDoiDonViThuoc> lstDonVi = new List<ChuyenDoiDonViThuoc>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ChuyenDoiDonViThuoc oDonVi = null;
                var row = dataGridView1.Rows[i];
                if (row.Tag == null)
                {
                    oDonVi = new ChuyenDoiDonViThuoc();
                    oDonVi.ID = Guid.NewGuid();
                }
                else
                {
                    oDonVi = row.Tag as ChuyenDoiDonViThuoc;
                }

                oDonVi.ThuocID = oThuoc.ID;
                oDonVi.DonViID = (Guid)row.Cells[1].Value;
                oDonVi.TiLeChuyenDoi = int.Parse(row.Cells[2].Value.ToString());
                oDonVi.PhuongThucChuyenDoi = row.Cells[3].Value.ToString() == "Chia" ? (byte)0 : (byte)1;
                oDonVi.MoTa = row.Cells[4].Value.ToString();

                lstDonVi.Add(oDonVi);
            }

            //Save data
            KhoUtil.SaveThuoc304(oThuoc, oGiaThuoc, lstDonVi);

            //Update cached
            var item = KhoUtil.GetDanhMuc<Thuoc304>().FirstOrDefault(t => t.ID == oThuoc.ID);
            if (item == null)
            {
                KhoUtil.GetDanhMuc<Thuoc304>().Add(item);
            }
            else
            {
                item = oThuoc;   
            }
        }

        private DonViThuoc GetDonViThuoc()
        {
            var dvThuoc = new DonViThuoc();
            //dvThuoc.

            return dvThuoc;
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show(this, "Có lỗi xảy ra, vui lòng thử lại hoặc liên hệ với người quản trị hệ thống." + Environment.NewLine + "Lỗi: " + ex.Message, "Quản lý thuốc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveEntity();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
    }
}

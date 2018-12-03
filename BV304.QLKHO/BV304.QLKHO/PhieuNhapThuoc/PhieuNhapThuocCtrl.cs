using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BV.DataModel;
using BV.QLKHO.THUOC;
using Infragistics.Win.UltraWinEditors;
using BV.DataModel.KhoChung;
using BV.DataModel.Kho;
using Infragistics.Win.UltraWinGrid;
using BV.SharedComponent;

namespace BV.QLKHO.PhieuNhapThuoc
{
    public partial class PhieuNhapThuocCtrl : UserControl
    {
        bool bComboValueChanged = false;
        bool bComboDropDownVisible = false;

        Guid _phieuID = Guid.Empty;
        public PhieuNhapThuocCtrl()
        {
            InitializeComponent();
        }

        private void InitData()
        {
            //lấy dữ liệu các danh mục
            var lstNhaCungCap = KhoUtil.GetDanhMuc<NhaCungCap>();
            var lstThuocVTYT = KhoUtil.GetDanhMuc<HangHoa>();
            var lstThuocDetail = KhoUtil.GetDanhMuc<v_ChiTietDonViHangHoa>();
            var lstPhanLoaiHoaDon = KhoUtil.GetDanhMuc<PhanLoaiHoaDon>();
            var lstLoHang = KhoUtil.GetDanhMuc<LoHangHoa>();
            var lstQDThau = KhoUtil.GetDanhMuc<QuyetDinhThau>();
        }

        public void InitControl(Guid phieuID)
        {
            _phieuID = phieuID;

            InitData();

            cboNhaCungCap.DataSource = KhoUtil.GetDanhMuc<NhaCungCap>();
            cboNhaCungCap.ValueMember = "NguonNhapID";
            cboNhaCungCap.DisplayMember = "Ten";

            cboPLHoaDon.DataSource = KhoUtil.GetDanhMuc<PhanLoaiHoaDon>();
            cboPLHoaDon.DisplayMember = "Ten";
            cboPLHoaDon.ValueMember = "ID";

            cboThuoc.DataSource = KhoUtil.GetDanhMuc<HangHoa>();
            cboThuoc.ValueMember = "ID";
            cboThuoc.DisplayMember = "Ten";
            cboThuoc.DisplayLayout.PerformAutoResizeColumns(false, Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand);

            var lstQuyetDinh = KhoUtil.GetDanhMuc<QuyetDinhThau>();
            cboQDThau.DataSource = lstQuyetDinh;
            cboQDThau.ValueMember = "Ma";
            cboQDThau.DisplayMember = "Ma";
            cboQDThau.DisplayLayout.PerformAutoResizeColumns(false, Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand);
        }

        private void cboNhaCungCap_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            NhaCungCapForm oForm = new NhaCungCapForm();
            oForm.InitThongTin(null);
            if (oForm.ShowDialog(this) == DialogResult.OK)
            {
                cboNhaCungCap.DataBind();
                cboNhaCungCap.Value = oForm.Entity.NguonNhapID;
            }
        }

        private void cboNhaCungCap_ValueChanged(object sender, EventArgs e)
        {
            //ultraDataSource1.Rows.Add()
        }

        private void cboThuoc_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            if (e.Button.Key == "add")
            {
                ThongTinThuocForm oForm = new ThongTinThuocForm();
                oForm.InitThongTin(null);
                if (oForm.ShowDialog(this) == DialogResult.OK)
                {
                    //update cached
                    UpdateCached();
                    cboThuoc.DataBind();
                    cboThuoc.DisplayLayout.PerformAutoResizeColumns(false, Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand);
                    cboThuoc.Value = oForm.Entity.ID;
                }
            }
            else if (e.Button.Key == "edit")
            {
                if (cboThuoc.SelectedRow != null)
                {
                    var itemID = (Guid)cboThuoc.Value;
                    var item = KhoUtil.GetDanhMuc<HangHoa>().FirstOrDefault(t => t.ID == itemID);

                    ThongTinThuocForm oForm = new ThongTinThuocForm();
                    oForm.InitThongTin(item);
                    if (oForm.ShowDialog(this) == DialogResult.OK)
                    {
                        UpdateCached();

                        cboThuoc.DataBind();
                        cboThuoc.DisplayLayout.PerformAutoResizeColumns(false, Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand);
                        cboThuoc.Value = oForm.Entity.ID;

                        ShowThuocInfo(oForm.Entity.ID);
                    }
                }
            }
        }

        private void cboThuoc_AfterCloseUp(object sender, EventArgs e)
        {
            bComboDropDownVisible = false;
            if (bComboValueChanged && cboThuoc.SelectedRow != null)
            {
                ShowThuocInfo((Guid)cboThuoc.Value);
                bComboValueChanged = false;
            }
        }

        private void cboThuoc_AfterDropDown(object sender, EventArgs e)
        {
            bComboDropDownVisible = true;
        }

        private void cboThuoc_ValueChanged(object sender, EventArgs e)
        {
            bComboValueChanged = true;
            if (cboThuoc.SelectedRow != null && !bComboDropDownVisible)
            {
                ShowThuocInfo((Guid)cboThuoc.Value);
            }
        }

        private void UpdateCached()
        {
            KhoUtil.GetDanhMuc<HangHoa>(true);
            KhoUtil.GetDanhMuc<v_ChiTietDonViHangHoa>(true);
        }

        private void ShowThuocInfo(Guid itemID)
        {
            //Don vi
            var lstDonVi = KhoUtil.GetDanhMuc<v_ChiTietDonViHangHoa>().Where(t => t.HangHoaID == itemID).ToList();

            //cboDonVi.DataSource = KhoUtil.GetDanhMuc<LoHangHoa>().Where(l => l.ThuocVtytID == itemID).ToList();
            cboDonVi.DataSource = lstDonVi;//.OrderBy(d => d.TiLeChuyenDoi);
            cboDonVi.ValueMember = "DonViID";
            cboDonVi.DisplayMember = "TenDonVi";
            cboDonVi.DataBind();
            cboDonVi.Value = null;
            //So lo
            var lstLoHang = KhoUtil.GetDanhMuc<LoHangHoa>().Where(l => l.ThuocVtytID == itemID).ToList();
            cboLoHang.DataSource = lstLoHang;
            cboLoHang.ValueMember = "ID";
            cboLoHang.DisplayMember = "SoLo";
            //cboLoHang.DataBind();
            cboLoHang.Value = null;
        }

        private void PhieuNhapThuocCtrl_Resize(object sender, EventArgs e)
        {
            clmNo.Width = 40;
            clmTenVatTu.Width = cboThuoc.Width - 32;
            clmSoLo.Width = cboLoHang.Width + 2;
            clmHSD.Width = txtHSD.Width + 7;
            clmQDThau.Width = cboQDThau.Width + 7;
            clmDonVi.Width = cboDonVi.Width + 6;
            clmSoLuong.Width = txtSoLuong.Width + 7;
            clmDonGia.Width = txtDonGia.Width + 6;
            clmChietKhau.Width = txtChietKhau.Width + 6;
        }

        private void cboNhaCungCap_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            cboNhaCungCap.UltraCommbo_InitializeLayout(sender, e);
            if (e.Layout.Bands.Count > 0)
            {
                foreach (var clm in e.Layout.Bands[0].Columns)
                {
                    if (clm.Key == "Ten")
                    {
                        clm.Header.Caption = "Tên";
                    }
                    else if (clm.Key == "DiaChi")
                    {
                        clm.Header.Caption = "Địa Chỉ";
                    }
                    else
                    {
                        clm.Hidden = true;
                    }
                }
            }
        }

        private void cboThuoc_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            if (e.Layout.Bands.Count > 0)
            {
                e.Layout.Bands[0].Override.HeaderAppearance.BackColor = Color.DimGray;
                foreach (var clm in e.Layout.Bands[0].Columns)
                {
                    if (clm.Key == "Ma")
                    {
                        clm.Header.Caption = "Mã Vật Tư";
                    }
                    else if (clm.Key == "Ten")
                    {
                        clm.Header.Caption = "Tên Vật Tư";
                    }
                    else if (clm.Key == "HamLuong")
                    {
                        clm.Header.Caption = "Hàm Lượng";
                    }
                    else if (clm.Key == "DongGoi")
                    {
                        clm.Header.Caption = "Đóng Gói";
                    }
                    else
                    {
                        clm.Hidden = true;
                    }
                }
            }
        }

        private void cboDonVi_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            cboDonVi.UltraCommbo_InitializeLayout(sender, e);
            if (e.Layout.Bands.Count > 0)
            {
                var lst = e.Layout.Bands[0];//.Columns;
                foreach (var clm in e.Layout.Bands[0].Columns)
                {
                    if (clm.Key == "TenDonVi")
                    {
                        clm.Header.Caption = "Đơn Vị";
                    }
                    else if (clm.Key == "MoTa")
                    {
                        clm.Header.Caption = "Mô Tả";
                    }
                    else
                    {
                        clm.Hidden = true;
                    }
                }
            }
        }

        private void txtChietKhau_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            var btn = e.Button as EditorButton;
            btn.Text = btn.Text == "%" ? "$" : "%";
            btn.Width = 22;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            try
            {
                //get chi tiet phieu
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void GetChiTietPhieu()
        {
            ChiTietPhieu oRow = new ChiTietPhieu();
            oRow.ID = Guid.NewGuid();
            oRow.HangHoaID = (Guid)cboThuoc.Value;
            //oRow.LoHangID
        }

        public void HandleException(Exception ex)
        {
            this.Cursor = Cursors.Default;
            //TODO: ghi log client vào đây
            //CommonFunction.WriteLog(ex.Message);
            MessageBox.Show(this, "Có lỗi xảy ra, vui lòng thử lại hoặc liên hệ với người quản trị. \n Lỗi: " + ex.Message, "Phiếu Nhập Kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowMessage(string msg)
        {
            MessageBox.Show(this, msg, "Phiếu Nhập Kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void cboThuoc_Enter(object sender, EventArgs e)
        {
            UltraCombo cbo = (UltraCombo)sender;
            foreach (var item in cbo.ButtonsRight)
            {
                item.Visible = true;
            }
        }

        private void cboThuoc_Leave(object sender, EventArgs e)
        {
            UltraCombo cbo = (UltraCombo)sender;
            foreach (var item in cbo.ButtonsRight)
            {
                item.Visible = false;
            }
        }

        private void cboLoHang_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            cboLoHang.UltraCommbo_InitializeLayout(sender, e);
            if (e.Layout.Bands.Count > 0)
            {
                foreach (var clm in e.Layout.Bands[0].Columns)
                {
                    if (clm.Key == "SoLo")
                    {
                        clm.Header.Caption = "Số Lô";
                    }
                    else if (clm.Key == "HanSuDung")
                    {
                        clm.Header.Caption = "Hạn Sử Dụng";
                    }
                    else
                    {
                        clm.Hidden = true;
                    }
                }
            }
        }

        private void cboLoHang_EditorButtonClick(object sender, EditorButtonEventArgs e)
        {
            try
            {
                if (cboThuoc.Value == null)
                {
                    ShowMessage("Bạn chưa chọn hàng hóa để nhập");
                    return;
                }

                LoHangHoa oSoLo = null;
                var hanghoaID = (Guid)cboThuoc.Value;
                var hanghoa = KhoUtil.GetDanhMuc<HangHoa>().FirstOrDefault(t => t.ID == hanghoaID);
                if (e.Button.Key == "edit")
                {
                    if (cboLoHang.Value != null)
                    {
                        Guid loID = (Guid)cboLoHang.Value;
                        oSoLo = KhoUtil.GetDanhMuc<LoHangHoa>().FirstOrDefault(l => l.ID == loID);
                    }
                }

                ThongTinLoHangForm oForm = new ThongTinLoHangForm();
                oForm.InitThongTin(hanghoa, oSoLo);
                if (oForm.ShowDialog(this) == DialogResult.OK)
                {
                    var lstLoHang = KhoUtil.GetDanhMuc<LoHangHoa>().Where(l => l.ThuocVtytID == hanghoaID).ToList();
                    cboLoHang.DataSource = lstLoHang;
                    cboLoHang.ValueMember = "ID";
                    cboLoHang.DisplayMember = "SoLo";
                    cboLoHang.DataBind();
                    cboLoHang.DisplayLayout.PerformAutoResizeColumns(false, Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand);
                    cboLoHang.Value = oForm.Entity.ID;
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            
        }

        private void cboQDThau_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            cboQDThau.UltraCommbo_InitializeLayout(sender, e);
            if (e.Layout.Bands.Count > 0)
            {
                foreach (var clm in e.Layout.Bands[0].Columns)
                {
                    if (clm.Key == "Ma")
                    {
                        clm.Header.Caption = "Quyết Định";
                    }
                    else if (clm.Key == "MoTa")
                    {
                        clm.Header.Caption = "Mô Tả";
                    }
                    else
                    {
                        clm.Hidden = true;
                    }
                }
            }
        }

        private void cboQDThau_EditorButtonClick(object sender, EditorButtonEventArgs e)
        {
            try
            {
                //LoHangHoa oSoLo = null;
                //var hanghoaID = (Guid)cboThuoc.Value;
                //var hanghoa = KhoUtil.GetDanhMuc<HangHoa>().FirstOrDefault(t => t.ID == hanghoaID);
                //if (e.Button.Key == "edit")
                //{
                //    if (cboLoHang.Value != null)
                //    {
                //        Guid loID = (Guid)cboLoHang.Value;
                //        oSoLo = KhoUtil.GetDanhMuc<LoHangHoa>().FirstOrDefault(l => l.ID == loID);
                //    }
                //}

                QuyetDinhThauForm oForm = new QuyetDinhThauForm();
                oForm.InitThongTin(null);
                if (oForm.ShowDialog(this) == DialogResult.OK)
                {
                    var lstQuyetDinh = KhoUtil.GetDanhMuc<QuyetDinhThau>();
                    cboQDThau.DataSource = lstQuyetDinh;
                    cboQDThau.ValueMember = "Ma";
                    cboQDThau.DisplayMember = "Ma";
                    cboQDThau.DisplayLayout.PerformAutoResizeColumns(false, Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand);
                    cboQDThau.Value = oForm.Entity.Ma;
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void cboQDThau_ValueChanged(object sender, EventArgs e)
        {
        }

        private void cboLoHang_ValueChanged(object sender, EventArgs e)
        {
            if (cboLoHang.SelectedRow != null)
            {
                var loHang = KhoUtil.GetDanhMuc<LoHangHoa>().FirstOrDefault(l => l.SoLo == cboLoHang.Text);
                if (loHang == null)
                {
                    txtHSD.Text = "";
                }
                else
                {
                    txtHSD.Text = loHang.HanSuDung.Value.ToString("dd/MM/yyyy");
                }
            }
        }

        private void cboQDThau_Enter(object sender, EventArgs e)
        {
            UltraCombo cbo = (UltraCombo)sender;
            foreach (var item in cbo.ButtonsRight)
            {
                item.Visible = true;
            }
        }

        private void cboQDThau_Leave(object sender, EventArgs e)
        {
            UltraCombo cbo = (UltraCombo)sender;
            foreach (var item in cbo.ButtonsRight)
            {
                item.Visible = false;
            }
        }
    }
}

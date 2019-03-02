using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BV.AppCommon;
using BV.BUS;
using BV.DataModel;
using BV.QLKHO.THUOC;
using BV.SharedComponent;
using Common.Winforms;
using Common.Winforms.UserControls;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;

namespace BV.QLKHO.KhoChan.NhapThuoc
{
    public partial class PhieuNhapThuocCtrl : UserControlBase
    {
        //private PhieuNhapKhoModel _phieuNhap { get; set; }
        private readonly List<PhieuNhapChiTiet> _chiTietPhieus = new List<PhieuNhapChiTiet>();
        private Guid? _phieuDeNghiId;


        private Guid _phieuID = Guid.Empty;

        //add hang hoa
        private double? _thanhTien;
        private LoaiChietKhau _chietKhauHangHoa = LoaiChietKhau.TienMat;

        private bool bComboDropDownVisible;
        private bool bComboValueChanged;


        public PhieuNhapThuocCtrl()
        {
            InitializeComponent();
            dataGridView1.InitDataGridView();
        }

        private void InitData()
        {
            //lấy dữ liệu các danh mục
            BusApp.GetDanhMuc<NhaCungCap>();
            BusApp.GetDanhMuc<HangHoa>();
            BusApp.GetDanhMuc<v_ChiTietDonViHangHoa>();
            BusApp.GetDanhMuc<PhanLoaiHoaDon>();
            BusApp.GetDanhMuc<LoHangHoa>();
            BusApp.GetDanhMuc<QuyetDinhThau>();
        }

        public void InitControl(Guid phieuId)
        {
            _phieuID = phieuId;

            InitData();

            cboNhaCungCap.DataSource = BusApp.GetDanhMuc<NhaCungCap>();
            cboNhaCungCap.ValueMember = "ID";
            cboNhaCungCap.DisplayMember = "Ten";

            cboPLHoaDon.DataSource = BusApp.GetDanhMuc<PhanLoaiHoaDon>();
            cboPLHoaDon.DisplayMember = "Ten";
            cboPLHoaDon.ValueMember = "ID";

            cboThuoc.DataSource = BusApp.GetDanhMuc<HangHoa>();
            cboThuoc.ValueMember = "ID";
            cboThuoc.DisplayMember = "Ten";
            cboThuoc.DisplayLayout.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand);

            var lstQuyetDinh = BusApp.GetDanhMuc<QuyetDinhThau>();
            cboQDThau.DataSource = lstQuyetDinh;
            cboQDThau.ValueMember = "Ma";
            cboQDThau.DisplayMember = "Ma";
            cboQDThau.DisplayLayout.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand);
        }

        private void cboNhaCungCap_EditorButtonClick(object sender, EditorButtonEventArgs e)
        {
            var oForm = new NhaCungCapForm();
            oForm.InitThongTin(null);
            if (oForm.ShowDialog(this) == DialogResult.OK)
            {
                cboNhaCungCap.DataBind();
                cboNhaCungCap.Value = oForm.Entity.ID;
            }
        }

        private void cboNhaCungCap_ValueChanged(object sender, EventArgs e)
        {
            //ultraDataSource1.Rows.Add()
        }

        private void cboThuoc_EditorButtonClick(object sender, EditorButtonEventArgs e)
        {
            if (e.Button.Key == "add")
            {
                var oForm = new ThongTinThuocForm();
                oForm.InitThongTin(null);
                if (oForm.ShowDialog(this) == DialogResult.OK)
                {
                    //update cached
                    UpdateCached();
                    cboThuoc.DataBind();
                    cboThuoc.DisplayLayout.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand);
                    cboThuoc.Value = oForm.Entity.ID;
                }
            }
            else if (e.Button.Key == "edit")
            {
                if (cboThuoc.SelectedRow != null)
                {
                    var itemId = (Guid) cboThuoc.Value;
                    var item = BusApp.GetDanhMuc<HangHoa>().FirstOrDefault(t => t.ID == itemId);

                    var oForm = new ThongTinThuocForm();
                    oForm.InitThongTin(item);
                    if (oForm.ShowDialog(this) == DialogResult.OK)
                    {
                        UpdateCached();

                        cboThuoc.DataBind();
                        cboThuoc.DisplayLayout.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand);
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
                ShowThuocInfo((Guid) cboThuoc.Value);
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
            if (cboThuoc.SelectedRow != null && !bComboDropDownVisible) ShowThuocInfo((Guid) cboThuoc.Value);
        }

        private void UpdateCached()
        {
            BusApp.GetDanhMuc<HangHoa>(true);
            BusApp.GetDanhMuc<v_ChiTietDonViHangHoa>(true);
        }

        private void ShowThuocInfo(Guid itemId)
        {
            //Don vi
            var lstDonVi = BusApp.GetDanhMuc<v_ChiTietDonViHangHoa>().Where(t => t.HangHoaID == itemId).ToList();

            //cboDonVi.DataSource = KhoUtil.GetDanhMuc<LoHangHoa>().Where(l => l.ThuocVtytID == itemID).ToList();
            cboDonVi.DataSource = lstDonVi; //.OrderBy(d => d.TiLeChuyenDoi);
            cboDonVi.ValueMember = "DonViID";
            cboDonVi.DisplayMember = "TenDonVi";
            cboDonVi.DataBind();
            cboDonVi.Value = null;
            //So lo
            var lstLoHang = BusApp.GetDanhMuc<LoHangHoa>().Where(l => l.ThuocVtytID == itemId).ToList();
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
            clmHSD.Width = dateHSD.Width + 7;
            clmQDThau.Width = cboQDThau.Width + 7;
            clmDonVi.Width = cboDonVi.Width + 6;
            clmSoLuong.Width = txtSoLuong.Width + 7;
            clmDonGia.Width = txtDonGia.Width + 6;
            clmChietKhau.Width = txtChietKhau.Width + 6;
        }

        private void cboNhaCungCap_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            cboNhaCungCap.UltraCommbo_InitializeLayout(sender, e);
            if (e.Layout.Bands.Count > 0)
                foreach (var clm in e.Layout.Bands[0].Columns)
                    if (clm.Key == "Ten")
                        clm.Header.Caption = @"Tên";
                    else if (clm.Key == "DiaChi")
                        clm.Header.Caption = @"Địa Chỉ";
                    else
                        clm.Hidden = true;
        }

        private void cboThuoc_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            if (e.Layout.Bands.Count > 0)
            {
                e.Layout.Bands[0].Override.HeaderAppearance.BackColor = Color.DimGray;
                foreach (var clm in e.Layout.Bands[0].Columns)
                    if (clm.Key == "Ma")
                        clm.Header.Caption = @"Mã Vật Tư";
                    else if (clm.Key == "Ten")
                        clm.Header.Caption = @"Tên Vật Tư";
                    else if (clm.Key == "HamLuong")
                        clm.Header.Caption = @"Hàm Lượng";
                    else if (clm.Key == "DongGoi")
                        clm.Header.Caption = @"Đóng Gói";
                    else
                        clm.Hidden = true;
            }
        }

        private void cboDonVi_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            cboDonVi.UltraCommbo_InitializeLayout(sender, e);
            if (e.Layout.Bands.Count > 0)
            {
                //var lst = e.Layout.Bands[0]; //.Columns;
                foreach (var clm in e.Layout.Bands[0].Columns)
                    if (clm.Key == "TenDonVi")
                        clm.Header.Caption = @"Đơn Vị";
                    else if (clm.Key == "MoTa")
                        clm.Header.Caption = @"Mô Tả";
                    else
                        clm.Hidden = true;
            }
        }

        private void txtChietKhau_EditorButtonClick(object sender, EditorButtonEventArgs e)
        {
            if (e.Button is EditorButton btn)
            {
                btn.Text = btn.Text == @"%" ? "$" : "%";
                btn.Width = 22;
                switch (btn.Text)
                {
                    case "%":
                        _chietKhauHangHoa = LoaiChietKhau.PhanTram;
                        break;
                    case @"$":
                        _chietKhauHangHoa = LoaiChietKhau.TienMat;
                        break;
                    default:
                        _chietKhauHangHoa = LoaiChietKhau.TienMat;
                        break;
                }
            }

            TinhTien();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void GetChiTietPhieu()
        {
            //var oRow = new ChiTietPhieu();
            //oRow.ID = Guid.NewGuid();
            //oRow.HangHoaID = (Guid) cboThuoc.Value;
            ////oRow.LoHangID
        }

        private void ShowMessage(string msg)
        {
            MessageBox.Show(this, msg, @"Phiếu Nhập Kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void cboThuoc_Enter(object sender, EventArgs e)
        {
            var cbo = (UltraCombo) sender;
            foreach (var item in cbo.ButtonsRight) item.Visible = true;
        }

        private void cboThuoc_Leave(object sender, EventArgs e)
        {
            var cbo = (UltraCombo) sender;
            foreach (var item in cbo.ButtonsRight) item.Visible = false;
        }

        private void cboLoHang_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            cboLoHang.UltraCommbo_InitializeLayout(sender, e);
            if (e.Layout.Bands.Count > 0)
                foreach (var clm in e.Layout.Bands[0].Columns)
                    if (clm.Key == "SoLo")
                        clm.Header.Caption = @"Số Lô";
                    else if (clm.Key == "HanSuDung")
                        clm.Header.Caption = @"Hạn Sử Dụng";
                    else
                        clm.Hidden = true;
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
                var hanghoaId = (Guid) cboThuoc.Value;
                var hanghoa = BusApp.GetDanhMuc<HangHoa>().FirstOrDefault(t => t.ID == hanghoaId);
                if (e.Button.Key == "edit")
                    if (cboLoHang.Value != null)
                    {
                        var loId = (Guid) cboLoHang.Value;
                        oSoLo = BusApp.GetDanhMuc<LoHangHoa>().FirstOrDefault(l => l.ID == loId);
                    }

                var oForm = new ThongTinLoHangForm();
                oForm.InitThongTin(hanghoa, oSoLo);
                if (oForm.ShowDialog(this) == DialogResult.OK)
                {
                    var lstLoHang = BusApp.GetDanhMuc<LoHangHoa>().Where(l => l.ThuocVtytID == hanghoaId).ToList();
                    cboLoHang.DataSource = lstLoHang;
                    cboLoHang.ValueMember = "ID";
                    cboLoHang.DisplayMember = "SoLo";
                    cboLoHang.DataBind();
                    cboLoHang.DisplayLayout.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand);
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
                foreach (var clm in e.Layout.Bands[0].Columns)
                    if (clm.Key == "Ma")
                        clm.Header.Caption = @"Quyết Định";
                    else if (clm.Key == "MoTa")
                        clm.Header.Caption = @"Mô Tả";
                    else
                        clm.Hidden = true;
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

                var oForm = new QuyetDinhThauForm();
                oForm.InitThongTin(null);
                if (oForm.ShowDialog(this) == DialogResult.OK)
                {
                    var lstQuyetDinh = BusApp.GetDanhMuc<QuyetDinhThau>();
                    cboQDThau.DataSource = lstQuyetDinh;
                    cboQDThau.ValueMember = "Ma";
                    cboQDThau.DisplayMember = "Ma";
                    cboQDThau.DisplayLayout.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand);
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
                var loHang = BusApp.GetDanhMuc<LoHangHoa>().FirstOrDefault(l => l.SoLo == cboLoHang.Text);
                if (loHang == null)
                    dateHSD.Text = "";
                else if (loHang.HanSuDung != null) dateHSD.Text = loHang.HanSuDung.Value.ToString("dd/MM/yyyy");
            }
        }

        private void cboQDThau_Enter(object sender, EventArgs e)
        {
            var cbo = (UltraCombo) sender;
            foreach (var item in cbo.ButtonsRight) item.Visible = true;
        }

        private void cboQDThau_Leave(object sender, EventArgs e)
        {
            var cbo = (UltraCombo) sender;
            foreach (var item in cbo.ButtonsRight) item.Visible = false;
        }

        private void ThanhTien_ValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void TinhTien()
        {
            switch (_chietKhauHangHoa)
            {
                case LoaiChietKhau.PhanTram:
                    if(string.IsNullOrEmpty(txtChietKhau.Text) || Converter.Obj2Int(txtChietKhau.Text.Replace(".", ""))==0)
                    _thanhTien = Converter.Obj2double(txtSoLuong.Text.Replace(".", ""))
                        * Converter.Obj2double(txtDonGia.Text.Replace(".", ""));
                    else
                        _thanhTien = Converter.Obj2double(txtSoLuong.Text.Replace(".", ""))
                                     * Converter.Obj2double(txtDonGia.Text.Replace(".", ""))
                                     * Converter.Obj2Int(txtChietKhau.Text.Replace(".", "")) / 100;
                    break;
                case LoaiChietKhau.TienMat:
                    _thanhTien = Converter.Obj2double(txtSoLuong.Text.Replace(".", ""))
                        * Converter.Obj2double(txtDonGia.Text.Replace(".", ""))
                        - Converter.Obj2double(txtChietKhau.Text.Replace(".", ""));
                    break;
            }

            txtThanhTien.Text = _thanhTien?.ToString();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            try
            {
                //get chi tiet phieu
                var phieu = new PhieuNhapChiTiet
                {
                    ID = Guid.NewGuid(),
                    ChietKhau = Converter.obj2double(txtChietKhau.Text),
                    DonGia = Converter.obj2double(txtDonGia.Text),
                    HangHoaID = Converter.obj2Guid(cboThuoc.Value),
                    LoHangID = Converter.obj2Guid(cboLoHang.Value),
                    LoaiChietKhau = Converter.obj2Short(_chietKhauHangHoa),
                    MaDonVi = Converter.obj2Guid(cboDonVi.Value),
                    PhieuID = _phieuID,
                    SoLuong = Converter.obj2double(txtSoLuong.Text),
                    SoQuyeDinh = Converter.obj2String(cboQDThau.Value),
                    TenDonVi = Converter.obj2String(cboDonVi.Text),
                    ThanhTien = _thanhTien,
                    HanSuDung = Converter.Obj2Date(dateHSD.Text)
                };

                _chiTietPhieus.Add(phieu);
                //add item to grid
                var newItem = new object[] {
                     Guid.NewGuid(),//id
                    _phieuID,//ma phieu
                    _chiTietPhieus.Count, //STT
                    cboThuoc.Text,//ten thuoc
                    cboDonVi.Text,//don vi tinh
                    cboQDThau.Text,//quyet dinh thau
                    cboLoHang.Text,//so lo
                    dateHSD.Text,//han su dung
                    txtSoLuong.Text,//so luong
                    (txtChietKhau.Text + (_chietKhauHangHoa == LoaiChietKhau.PhanTram ?" %":" đ")),//chiet khau
                    txtDonGia.Text,//don gia
                    //cboDonVi.Text,//ten don vi tinh
                    _thanhTien,// thanh tien
                    //_chietKhauHangHoa,//loai chiet khau
                };

                var newIdx = dataGridView1.Rows.Add(newItem);
                dataGridView1.Rows[newIdx].Tag = phieu;
                DataGridViewRow row = dataGridView1.Rows[newIdx];
                row.DefaultCellStyle.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }


        public PhieuNhapKhoModel PhieuNhapData()
        {
            var phieuNhap = new PhieuNhapKhoModel
            {
                ChiTietPhieuNhaps = _chiTietPhieus,
                ID = _phieuID,
                Ma = txtMaPhieu.Text,
                MaNhaCungCap = Converter.Obj2Int(cboNhaCungCap.Value),
                MaPhanLoaiHoaDon = Converter.obj2Int(cboPLHoaDon.Value),
                NgayHoaDon = Converter.Obj2Date(dateNgayNhap.Text),
                NgayTao = Converter.Obj2Date(dateNgayTao.Text),
                NguoiCungCap = txtNguoiGiao.Text,
                NguoiTao = txtNguoiTao.Text,
                NhaCungCap = cboNhaCungCap.Text,
                //PhanLoaiHoaDon = cboPLHoaDon.Text,
                PhieuDeNghiId = _phieuDeNghiId,
                SoHoaDon = txtSoHoaDon.Text,
                TenPhanLoaiHoaDon = cboPLHoaDon.Text,
                TongTien = _chiTietPhieus.Sum(e => e.ThanhTien ?? 0),
                VAT = Converter.obj2double(txtVat.Text),
                KhoId = PublicVariable.CurrentKhoId
            };
            if (phieuNhap.VAT != null)
                phieuNhap.ThanhTien = phieuNhap.TongTien * phieuNhap.VAT / 100;
            else
                phieuNhap.ThanhTien = phieuNhap.TongTien;
            return phieuNhap;
        }

        public void DisplayData()
        {
            //try
            //{
            //    this.Cursor = Cursors.WaitCursor;
            //    _The_ThuocData = DBCommandUtils.GetTHE_THUOC_DVS();
            //    if (_data == null)
            //        _data = DBCommandUtils.GetThuocYHCT();
            //    GrdThuoc.Rows.Clear();
            //    grdTheThuoc.Rows.Clear();
            //    if (_data == null)
            //        return;
            //    toolbarGeneral1.EnableButton(ActionTypes.Refresh, _data.Count);
            //    foreach (var item in _data)
            //    {
            //        var newItem = new object[] {
            //            item.THUOC_ID,
            //            item.SO_DANG_KY,
            //            item.TEN_THUOC,
            //            item.MA_HOAT_CHAT,
            //            item.HOAT_CHAT,
            //            item.MA_DUONG_DUNG,
            //            item.HAM_LUONG,
            //            item.DONG_GOI
            //        };
            //        var newIdx = GrdThuoc.Rows.Add(newItem);
            //        GrdThuoc.Rows[newIdx].Tag = item;
            //        LoadTheThuocDelegate onLoadThe = new LoadTheThuocDelegate(LoadThe);
            //        BeginInvoke(onLoadThe, new object[] { newIdx, item.THUOC_ID, item.SO_DANG_KY, item.TEN_THUOC, item.MA_HOAT_CHAT });
            //    }
            //}
            //finally
            //{
            //    this.Cursor = Cursors.Default;
            //}
        }
    }
}
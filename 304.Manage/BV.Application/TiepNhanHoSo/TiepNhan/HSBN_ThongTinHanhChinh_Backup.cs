﻿using Common.Winforms;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Infragistics.Win.UltraWinGrid;
using BV.DataModel;
using BV.QLKHO;
using BV.SharedComponent;
using BV.BUS;

namespace EHR.App.HSBenhNhan
{
    public partial class HSBN_ThongTinHanhChinh_Backup : UserControl
    {
        bool bComboValueChanged = false;
        bool bComboDropDownVisible = false;

        public Guid? _hssk_Id { get; set; }
        public HS_CaNhan _entity { get; set; }

        public bool SettingChanged { get; set; }
        public object DBCommandUtils { get; private set; }

        bool _isNewHoso = false;

        public HSBN_ThongTinHanhChinh_Backup()
        {
            InitializeComponent();
        }

        public void SetNewHoSo()
        {
            _isNewHoso = true;
        }

        private void LoadComboxs()
        {
            AppBus.GetDanhMuc<DiaDanh>();
            AppBus.GetDanhMuc<DanToc>();
            AppBus.GetDanhMuc<TonGiao>();
            AppBus.GetDanhMuc<GioiTinh>();

            cbGioiTinh.DataSource = AppBus.GetDanhMuc<GioiTinh>();
            cbGioiTinh.DisplayMember = "TEN_GIOI_TINH";
            cbGioiTinh.ValueMember = "GIOI_TINH_Id";

            cboTinh.DataSource = AppBus.GetDanhMuc<DiaDanh>().GetTinh();
            cboTinh.DisplayMember = "TenNganGon";
            cboTinh.ValueMember = "MaDiaDanh";

            cboDanToc.DataSource = AppBus.GetDanhMuc<DanToc>();
            cboDanToc.DisplayMember = "TEN_DAN_TOC";
            cboDanToc.ValueMember = "DAN_TOC_Id";

            cboQuocTich.DataSource = AppBus.GetDanhMuc<QuocGia>();
            cboQuocTich.DisplayMember = "ten_qg";
            cboQuocTich.ValueMember = "MA_QGIA";

            cboTonGiao.DataSource = AppBus.GetDanhMuc<TonGiao>();
            cboTonGiao.DisplayMember = "TEN_TON_GIAO";
            cboTonGiao.ValueMember = "TON_GIAO_Id";
        }

        public void DisplayData(Guid? hosoID, object data)
        {
            try
            {
                this._hssk_Id = hosoID.Value;
                if (_isNewHoso)
                {
                    _entity = new HS_CaNhan() { ID = _hssk_Id.Value };
                }
                else
                {
                    _entity = AppBus.GetHoSoCaNhanByID(this._hssk_Id.Value);
                    if (_entity == null)
                        throw new Exception("Không tìm thấy thông tin của hồ sơ");
                    BindValue(this._entity);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                SettingChanged = false;
            }
        }

        public object SaveDataChanged()
        {
            return GetDataChanged();
        }

        public void InitControlUI()
        {
            LoadComboxs();
        }

        private void BindValue(HS_CaNhan entity)
        {
            try
            {
                txtHoTen.Text = entity.HO_TEN;
                if (entity.GIOI_TINH == null)
                    cbGioiTinh.SelectedIndex = -1;
                else
                    cbGioiTinh.SelectedValue = entity.GIOI_TINH;

                txtNhomMau.Text = entity.NHOM_MAU;

                datNgaySinh.SetDateValue(entity.NAM_SINH, entity.THANG_SINH, entity.NGAY_SINH);

                cboDanToc.Value = entity.DAN_TOC ?? null;
                cboQuocTich.Value = entity.MA_QGIA ?? null;
                cboTonGiao.Value = entity.TON_GIAO ?? null;

                txtNgheNghiep.Text = entity.NGHE_NGHIEP;
                txtCMND.Text = entity.CMND;

                
                var bhyt = AppBus.GetSoBHYT(this._hssk_Id.Value);

                txtBHXH.Tag = bhyt;
                if (bhyt != null)
                {
                    txtBHXH.Text = bhyt != null ? bhyt.MA_THE : "";
                    txtNoiCapBH.Text = bhyt.DIACHI_DKBD;
                    //var cs = DBGlobalCached.CSKCBCollection.FirstOrDefault(c => c.MA_CSKCB == bhyt.MA_DKBD);
                    //txtNoiCapBH.Text = cs != null ? cs.TEN_CSKCB : "";
                    //txtNoiCapBH.Text = CommandCommon.GetTenCSKBByMa(bhyt.MA_DKBD); 
                }

                txtDC_DKTT.Text = entity.DIA_CHI;
                cboTinh.Value = entity.MA_TINH;
                cboHuyen.Value = entity.MA_HUYEN;
                cboXa.Value = entity.MA_XA;
                txtDC_DKTT.Text = entity.DIA_CHI;
                txtDienThoai.Text = entity.DIEN_THOAI;
                txtHoTenNCSC.Text = entity.HO_TEN_NCSC;
                txtQhe_NCSC.Text = entity.MOI_QH_NCSC;
            }
            catch (Exception ex)
            {
                var abc = ex.Message;
                throw;
            }
        }

        public object GetDataChanged()
        {
            try
            {
                HS_CaNhan item = new HS_CaNhan();
                string hovaten = txtHoTen.Text.ToTitleCase();
                string ten = string.Empty;
                item.ID = _entity.ID;
                item.HO_TEN = hovaten;
                item.TEN = CommonFunction.TachHoVaTen(hovaten, out ten);
                item.GIOI_TINH = cbGioiTinh.SelectedIndex > -1 ? cbGioiTinh.SelectedValue as int? : null;

                item.NHOM_MAU = txtNhomMau.Text;

                var arrString = datNgaySinh.Text.Replace("-", "/").Split('/');

                item.NGAY_SINH = Converter.obj2Int(arrString[0]);
                item.THANG_SINH = Converter.obj2Int(arrString[1]);
                item.NAM_SINH = Converter.Obj2Int(arrString[2]);

                item.DAN_TOC = cboDanToc.Value as int?;
                item.MA_QGIA = cboQuocTich.Value as int?;
                item.TON_GIAO = cboTonGiao.Value as int?;

                item.NGHE_NGHIEP = txtNgheNghiep.Text;
                item.CMND = txtCMND.Text.Trim();

                item.DIA_CHI = txtDC_DKTT.Text;
                item.MA_TINH = cboTinh.Value as string;
                item.MA_HUYEN = cboHuyen.Value as string;
                item.MA_XA = cboXa.Value as string;

                item.DIEN_THOAI = txtDienThoai.Text;
                item.HO_TEN_NCSC = txtHoTenNCSC.Text;
                item.MOI_QH_NCSC = txtQhe_NCSC.Text;
                item.DIEN_THOAI_NCSC = txtDienThoai_NCSC.Text;
                item.CreateBy = PublicVariables.UserId.ToString();
                item.CreateDate = DateTime.Now;
                return item;
            }
            catch (Exception ex)
            {
                var abc = ex.Message;
                throw;
            }
        }

        public object CommitDataChanged()
        {
            //Update benh
            var entity = GetDataChanged() as HS_CaNhan;
            if (AppBus.SaveHS_CaNhan(this._hssk_Id.Value, "0", entity))
            {
                _entity = entity;

                //Save thong tin bao hiem
                if (_isNewHoso && txtBHXH.Tag != null)
                {
                    var bhyt = txtBHXH.Tag as HS_BHYT;
                    bhyt.HSCN_ID = entity.ID;
                    txtBHXH.Tag = AppBus.UpdateHoSo_BHYT(_entity.ID, bhyt);
                }
                _isNewHoso = false;
                return true;
            }
            return false;
        }

        public bool ValidateData()
        {
            bool bRet = true;
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtMaHSSK.Text))
            {
                errorProvider1.SetError(label10, "Xin hãy nhập mã cá nhân!");
                return false;
            }
            //Check trung ma hs suc khoe sau
            var item = AppBus.GetHoSoCaNhanByMa(txtMaHSSK.Text);
            if (item != null && item.ID != _hssk_Id)
            {
                errorProvider1.SetError(label10, "Nhập mã cá nhân đã tồn tại! Xin hãy kiểm tra lại.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Xin hãy nhập họ và tên!");
                return false;
            }
            string ngaysinh = datNgaySinh.Text.Replace("-", "/");
            var arrString = ngaysinh.Split('/');
            if (arrString.Length == 1 || string.IsNullOrWhiteSpace(arrString[2]))
            {
                errorProvider1.SetError(datNgaySinh, "Phải có thông tin năm sinh!");
                return false;
            }
            else if (DateTime.Today.Year < Converter.Obj2Int(arrString[2]))
            {
                errorProvider1.SetError(datNgaySinh, "Năm sinh không hợp lệ! Xin hãy kiểm tra lại.");
                return false;
            }
            string NgayCapCMND = dateNgayCapCMND.Text.Replace("-", "/");
            if (!string.IsNullOrWhiteSpace(NgayCapCMND.Replace('/', ' ')) && !dateNgayCapCMND.GetDateValue().HasValue)
            {
                errorProvider1.SetError(dateNgayCapCMND, "Thông tin chưa chính xác! Xin hãy kiểm tra lại.");
                return false;
            }
            else if (dateNgayCapCMND.GetDateValue() != null && DateTime.Today.Year < dateNgayCapCMND.GetDateValue().Value.Year)
            {
                errorProvider1.SetError(datNgaySinh, "Dữ liệu không hợp lệ! xin hãy kiểm tra lại.");
                return false;
            }
            return bRet;
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            if (((Control)sender).Name == txtMaHSSK.Name)
            {
                errorProvider1.SetError(label10, "");
            }
            else
                errorProvider1.SetError((Control)sender, "");
            this.SettingChanged = true;
        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SettingChanged = true;
        }

        private void lbBH_Detail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var bhyt = txtBHXH.Tag as HS_BHYT;
                if (bhyt == null)
                {
                    bhyt = new HS_BHYT() { ID = Guid.Empty };
                    bhyt.HSCN_ID = _isNewHoso ? Guid.Empty : _hssk_Id.Value;
                }

                FormBHYT oForm = new FormBHYT();
                oForm.InitGUI(bhyt);
                if (oForm.ShowDialog(this) == DialogResult.OK)
                {
                    if (oForm.Entity == null)
                        return;
                    bhyt = oForm.Entity;
                    txtBHXH.Tag = oForm.Entity;
                    txtBHXH.Text = bhyt.MA_THE;
                    txtNoiCapBH.Text = bhyt.DIACHI_DKBD;

                    if (oForm.Entity.ID == Guid.Empty)
                    {
                        this.SettingChanged = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTinh_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            UltraCombo cbo = (UltraCombo)sender;
            cbo.UltraCommbo_InitializeLayout(sender, e);
            if (e.Layout.Bands.Count > 0)
            {
                e.Layout.Bands[0].Override.HeaderAppearance.BackColor = Color.DimGray;
                foreach (var clm in e.Layout.Bands[0].Columns)
                {
                    if (clm.Key == "MaDiaDanh")
                    {
                        clm.Header.Caption = "Mã Địa Danh";
                    }
                    else if (clm.Key == "TenNganGon")
                    {
                        clm.Header.Caption = "Tên Ngắn Gọn";
                    }
                    else
                    {
                        clm.Hidden = true;
                    }
                }
            }
        }

        private void cboTinh_AfterCloseUp(object sender, EventArgs e)
        {
            UltraCombo cbo = (UltraCombo)sender;
            bComboDropDownVisible = false;
            if (bComboValueChanged && cbo.SelectedRow != null)
            {
                UltraComboValueChanged(cbo);
                bComboValueChanged = false;
            }
        }

        private void cboTinh_AfterDropDown(object sender, EventArgs e)
        {
            bComboDropDownVisible = true;
        }

        private void cboTinh_ValueChanged(object sender, EventArgs e)
        {
            bComboValueChanged = true;
            UltraCombo cbo = (UltraCombo)sender;
            if (cbo.SelectedRow != null && !bComboDropDownVisible)
            {
                UltraComboValueChanged(cbo);
            }
        }

        private void UltraComboValueChanged(UltraCombo cbo)
        {
            if (cbo == cboTinh)
            {
                //tỉnh
                string maTinh = cboTinh.Value as string;
                 
                cboHuyen.DataSource = AppBus.GetDanhMuc<DiaDanh>().GetHuyen(maTinh);
                cboHuyen.DisplayMember = "TenNganGon";
                cboHuyen.ValueMember = "MaDiaDanh";
                cboHuyen.Value = null;

                cboXa.DataSource = AppBus.GetDanhMuc<DiaDanh>().GetXa(maTinh);
                cboXa.DisplayMember = "TenNganGon";
                cboXa.ValueMember = "MaDiaDanh";
                cboXa.Value = null;
            }
            else if (cbo == cboHuyen)
            {
                //huyện
                string maTinh = cboTinh.Value as string;
                string maHuyen = cboHuyen.Value as string;

                cboXa.DataSource = AppBus.GetDanhMuc<DiaDanh>().GetXa(maTinh, maHuyen);
                cboXa.DisplayMember = "TenNganGon";
                cboXa.ValueMember = "MaDiaDanh";
                cboXa.Value = null;
            }
            else
            {
                //xã
                string maXa = cboXa.Value as string;
                var dd = AppBus.GetDanhMuc<DiaDanh>().FirstOrDefault(d => d.MaDiaDanh == maXa);
                cboHuyen.Value = dd.MaHuyen;
            }
        }
    }
}
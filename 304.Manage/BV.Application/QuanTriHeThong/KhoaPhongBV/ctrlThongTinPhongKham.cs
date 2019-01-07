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
using BV.BUS;
using BV.AppCommon;
using BV.SharedComponent;

namespace BV.QuanTriHeThong.KhoaPhongBV
{
    public partial class ctrlThongTinPhongKham : UserControl
    {
        private PhongKham _entity = null;
        public event EventHandler SettingChanged;

        //bool bComboValueChanged = false;
        //bool bComboDropDownVisible = false;

        public ctrlThongTinPhongKham()
        {
            InitializeComponent();
        }

        public void InitThongTin(PhongKham p)
        {
            //Get list khoa
            cboTenKhoa.DataSource = BusApp.GetDanhMuc<Khoa>();
            cboTenKhoa.DisplayMember = "Ten";
            cboTenKhoa.ValueMember = "ID";
            cboTenKhoa.DisplayLayout.PerformAutoResizeColumns(false, Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand);

            cboCongKham.DataSource = BusApp.GetDanhMuc<CongKhamBenh>();
            cboCongKham.DisplayMember = "TenDichVu";
            cboCongKham.ValueMember = "ID";
            cboCongKham.DisplayLayout.PerformAutoResizeColumns(false, Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand);

            cboCongKham.DataSource = BusApp.GetDanhMuc<CongKhamBenh>();
            cboCongKham.DisplayMember = "TenDichVu";
            cboCongKham.ValueMember = "ID";
            cboCongKham.DisplayLayout.PerformAutoResizeColumns(false, Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand);

            _entity = p;
            if (p != null)
            {
                cboTenKhoa.Value = p.KhoaID;
                txtMaPhong.Text = p.Ma;
                txtTenPhong.Text = p.Ten;
                txtMoTa.Text = p.MoTa;
                cboCongKham.Value = p.CongKhamID;
            }

            if (_entity == null)
            {
                _entity = new PhongKham() { ID = Guid.NewGuid() };
            }
        }

        public PhongKham SaveEntity()
        {
            var p = new PhongKham();
            p.ID = _entity.ID;
            p.Ma = txtMaPhong.Text;
            p.Ten = txtTenPhong.Text;
            p.MoTa = txtMoTa.Text;
            p.KhoaID = (Guid)cboTenKhoa.Value;
            p.CongKhamID = (Guid?)cboCongKham.Value;// == null ? null : (Guid)cboCongKham.Value;

            //Save
            var newK = BUSKhoaPhong.UpdatePhongKham(p);

            //Update cached
            AppCached.UpdateDanhMuc<PhongKham>(newK, "ID");

            return p;
        }

        public bool ValidateData()
        {
            bool bRet = true;
            if (cboTenKhoa.SelectedRow == null)
            {
                bRet = false;
                errorProvider1.SetError(cboTenKhoa, "dữ liệu không được để trống");
            }

            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                bRet = false;
                errorProvider1.SetError(txtMaPhong, "dữ liệu không được để trống");
            }

            if (string.IsNullOrEmpty(txtTenPhong.Text))
            {
                bRet = false;
                errorProvider1.SetError(txtTenPhong, "dữ liệu không được để trống");
            }

            return bRet;
        }

        private void txtMaKhoa_TextChanged(object sender, System.EventArgs e)
        {
            Control ctrl = sender as Control;
            errorProvider1.SetError(ctrl, "");

            SettingChanged?.Invoke(sender, e);
        }

        #region cboTenKhoa
        private void cboTenKhoa_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            cboTenKhoa.UltraCommbo_InitializeLayout(sender, e);
            if (e.Layout.Bands.Count > 0)
            {
                foreach (var clm in e.Layout.Bands[0].Columns)
                {
                    if (clm.Key == "Ma")
                    {
                        clm.Header.Caption = "Mã";
                    }
                    else if (clm.Key == "Ten")
                    {
                        clm.Header.Caption = "Tên Khoa";
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

        private void cboTenKhoa_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cboTenKhoa, "");
            SettingChanged?.Invoke(sender, e);
        }
        #endregion

        #region cboConngKham
        private void cboCongKham_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            cboCongKham.UltraCommbo_InitializeLayout(sender, e);
            if (e.Layout.Bands.Count > 0)
            {
                foreach (var clm in e.Layout.Bands[0].Columns)
                {
                    if (clm.Key == "TenDichVu")
                    {
                        clm.Header.Caption = "Tên Dịch Vụ";
                    }
                    else if (clm.Key == "ThuPhi")
                    {
                        clm.Header.Caption = "Thu Phí";
                    }
                    else
                    {
                        clm.Hidden = true;
                    }
                }
            }
        }

        private void cboCongKham_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cboCongKham, "");
            SettingChanged?.Invoke(sender, e);
        }
        #endregion
    }
}

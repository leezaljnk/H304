using System;
using System.Windows.Forms;
using BV.AppCommon;
using BV.BUS;
using BV.DataModel;

namespace BV.QuanTriHeThong.KhoaPhongBV
{
    public partial class ctrlThongTinKhoa : UserControl
    {
        private Khoa _entity;

        public ctrlThongTinKhoa()
        {
            InitializeComponent();
        }

        public event EventHandler SettingChanged;

        public void InitThongTin(Khoa k)
        {
            _entity = k;
            if (k != null)
            {
                txtMaKhoa.Text = k.Ma;
                txtTenKhoa.Text = k.Ten;
                txtMoTa.Text = k.MoTa;

                txtMaKhoaBYT.Text = k.MaBYT;
                txtTenKhoaBYT.Text = k.TenBYT;
            }

            if (_entity == null) _entity = new Khoa {ID = Guid.NewGuid()};
        }

        public Khoa SaveEntity()
        {
            var k = new Khoa();
            k.ID = _entity.ID;
            k.Ma = txtMaKhoa.Text;
            k.Ten = txtTenKhoa.Text;
            k.MoTa = txtMoTa.Text;
            k.MaBYT = txtMaKhoaBYT.Text;
            k.TenBYT = txtTenKhoaBYT.Text;

            //Save
            var newK = BUSKhoaPhong.UpdateKhoa(k);

            //Update cached
            AppCached.UpdateDanhMuc(k, newK);

            return k;
        }

        public bool ValidateData()
        {
            var bRet = true;
            if (string.IsNullOrEmpty(txtMaKhoa.Text))
            {
                bRet = false;
                errorProvider1.SetError(txtMaKhoa, "dữ liệu không được để trống");
            }

            //if (string.IsNullOrEmpty(cboLoaiKhoa.Text))
            //{
            //    bRet = false;
            //    errorProvider1.SetError(cboLoaiKhoa, "dữ liệu không được để trống");
            //}

            if (string.IsNullOrEmpty(txtTenKhoa.Text))
            {
                bRet = false;
                errorProvider1.SetError(txtTenKhoa, "dữ liệu không được để trống");
            }

            if (string.IsNullOrEmpty(txtMaKhoaBYT.Text))
            {
                bRet = false;
                errorProvider1.SetError(txtMaKhoaBYT, "dữ liệu không được để trống");
            }

            if (string.IsNullOrEmpty(txtTenKhoaBYT.Text))
            {
                bRet = false;
                errorProvider1.SetError(txtTenKhoaBYT, "dữ liệu không được để trống");
            }

            return bRet;
        }

        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            errorProvider1.SetError(ctrl, "");

            SettingChanged?.Invoke(sender, e);
        }
    }
}
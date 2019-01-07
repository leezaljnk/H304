using System.Windows.Forms;
using BV.DataModel;
using System;

namespace BV.TiepNhanHoSo.KhoaPhongBV
{
    public partial class ctrlThongTinKhoa : UserControl
    {
        private Khoa _entity = null;
        public event EventHandler SettingChanged;
        public ctrlThongTinKhoa()
        {
            InitializeComponent();
        }

        public void InitUI(Khoa k)
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

            if (_entity == null)
            {
                _entity = new Khoa() { ID = Guid.NewGuid() };
            }
        }

        public Khoa SaveEntity()
        {
            var e = new Khoa();
            e.ID = _entity.ID;
            e.Ma = txtMaKhoa.Text;
            e.Ten = txtTenKhoa.Text;
            e.MoTa = txtMoTa.Text;
            e.MaBYT = txtMaKhoaBYT.Text;
            e.TenBYT = txtTenKhoaBYT.Text;

            //Save

            return e;
        }

        public bool ValidateData()
        {
            bool bRet = true;
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

        private void txtMaKhoa_TextChanged(object sender, System.EventArgs e)
        {
            Control ctrl = sender as Control;
            errorProvider1.SetError(ctrl, "");

            SettingChanged?.Invoke(sender, e);
        }
    }
}

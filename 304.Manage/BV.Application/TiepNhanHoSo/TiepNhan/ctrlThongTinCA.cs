using System;
using System.Windows.Forms;
using BV.QLKHO;
using BV.DataModel;
using BV.BUS;

namespace EHR.App.DSHoSo
{
    public partial class ctrlThongTinCA : UserControl
    {
        private HS_BHYT _entity;
        public event EventHandler EventSettingChanged;
        public ctrlThongTinCA()
        {
            InitializeComponent();
        }

        public void InitGUI(HS_BHYT source)
        {
            if (source == null) return;
            _entity = source;

            txtCoQuan.Text = "";
            txtCapBac.Text = "";
            txtChucVu.Text = "";
            if (source != null && source.ID != Guid.Empty)
            {
                txtCoQuan.Text = source.MA_THE;
                txtCapBac.Text = source.DIACHI_DKBD;
                txtChucVu.Text = "";
            }
        }

        public bool ValidateSetting()
        {
            bool bRet = true;
            if (string.IsNullOrWhiteSpace(txtCoQuan.Text))
            {
                errorProvider1.SetError(txtCoQuan, "không được để trống");
                bRet = false;
            }

            if (string.IsNullOrWhiteSpace(txtCapBac.Text))
            {
                errorProvider1.SetError(txtCapBac, "không được để trống");
                bRet = false;
            }
            
            return bRet;
        }

        public HS_BHYT SaveSetting()
        {
            var hs = new HS_BHYT()
            {
                ID = _entity.ID,
                HSCN_ID = _entity.HSCN_ID,
                MA_THE = txtCoQuan.Text,
            };

            if (hs.HSCN_ID == Guid.Empty)
            {
                return hs;
            }
            else
            {
                return BusApp.UpdateHoSo_BHYT(_entity.HSCN_ID, hs);
            }
        }

        private void txtMaCSBD_TextChanged(object sender, EventArgs e)
        {
            EventSettingChanged?.Invoke(sender, e);
        }

        private void txtSoBHYT_TextChanged(object sender, EventArgs e)
        {
            EventSettingChanged?.Invoke(sender, e);
        }

        private void txtTenCSBD_TextChanged(object sender, EventArgs e)
        {
            EventSettingChanged?.Invoke(sender, e);
        }

        private void datTuNgay_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            EventSettingChanged?.Invoke(sender, e);
        }

        private void datDenNgay_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            EventSettingChanged?.Invoke(sender, e);
        }
    }
}

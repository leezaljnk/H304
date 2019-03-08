using System;
using System.Globalization;
using System.Windows.Forms;
using BV.BUS;
using BV.DataModel;

namespace EHR.App.DSHoSo
{
    public partial class ctrlThongTinBaoHiem : UserControl
    {
        private HS_BHYT _entity;

        public ctrlThongTinBaoHiem()
        {
            InitializeComponent();
        }

        public event EventHandler EventSettingChanged;

        public void InitGUI(HS_BHYT source)
        {
            if (source == null) return;
            _entity = source;

            txtSoBHYT.Text = "";
            txtMaCSBD.Text = "";
            txtTenCSBD.Text = "";
            datTuNgay.Text = "";
            datDenNgay.Text = "";
            if (source != null && source.ID != Guid.Empty)
            {
                txtSoBHYT.Text = source.MA_THE;
                txtMaCSBD.Text = source.MA_DKBD;

                txtTenCSBD.Text = source.DIACHI_DKBD;

                datTuNgay.Text = source.GT_THE_TU == null
                    ? string.Empty
                    : source.GT_THE_TU.Value.ToString("dd/MM/yyyy");
                datDenNgay.Text = source.GT_THE_DEN == null
                    ? string.Empty
                    : source.GT_THE_DEN.Value.ToString("dd/MM/yyyy");
            }
        }

        public bool ValidateSetting()
        {
            var bRet = true;
            if (string.IsNullOrWhiteSpace(txtSoBHYT.Text))
            {
                errorProvider1.SetError(txtSoBHYT, "không được để trống");
                bRet = false;
            }

            if (string.IsNullOrWhiteSpace(txtMaCSBD.Text))
            {
                errorProvider1.SetError(txtMaCSBD, "không được để trống");
                bRet = false;
            }

            if (string.IsNullOrWhiteSpace(txtTenCSBD.Text))
            {
                errorProvider1.SetError(txtTenCSBD, "không được để trống");
                bRet = false;
            }

            if (string.IsNullOrWhiteSpace(datTuNgay.Text.Trim(' ', '/')))
            {
                //errorProvider1.SetError(datTuNgay, "không được để trống");
                //bRet = false;
            }
            else
            {
                var dtValue = DateTime.Now;
                if (!DateTime.TryParseExact(datTuNgay.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dtValue))
                {
                    errorProvider1.SetError(datTuNgay, "Ngày tháng chưa đúng");
                    bRet = false;
                }
            }

            if (string.IsNullOrWhiteSpace(datDenNgay.Text.Trim(' ', '/')))
            {
                //errorProvider1.SetError(datDenNgay, "không được để trống");
                //bRet = false;
            }
            else
            {
                var dtValue = DateTime.Now;
                if (!DateTime.TryParseExact(datDenNgay.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dtValue))
                {
                    errorProvider1.SetError(datDenNgay, "Ngày tháng chưa đúng");
                    bRet = false;
                }
            }

            return bRet;
        }

        public HS_BHYT SaveSetting()
        {
            var hs = new HS_BHYT
            {
                ID = _entity.ID,
                HSCN_ID = _entity.HSCN_ID,
                MA_THE = txtSoBHYT.Text,
                MA_DKBD = txtMaCSBD.Text
            };
            if (!string.IsNullOrWhiteSpace(datTuNgay.Text.Trim(' ', '/')))
                hs.GT_THE_TU = DateTime.ParseExact(datTuNgay.Text, "dd/MM/yyyy", null, DateTimeStyles.None);

            if (!string.IsNullOrWhiteSpace(datDenNgay.Text.Trim(' ', '/')))
                hs.GT_THE_DEN = DateTime.ParseExact(datDenNgay.Text, "dd/MM/yyyy", null, DateTimeStyles.None);

            if (hs.HSCN_ID == Guid.Empty)
                return hs;
            return BusApp.UpdateHoSo_BHYT(_entity.HSCN_ID, hs);
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
using System;
using System.Windows.Forms;
using BV.DataModel;

namespace BV.QuanTriHeThong.KhoaPhongBV
{
    public partial class ThongTinPhongKhamForm : Form
    {
        public ThongTinPhongKhamForm()
        {
            InitializeComponent();
        }

        public PhongKham Entity { get; internal set; }

        public void InitThongTin(PhongKham k)
        {
            Entity = k;
            if (Entity == null) Entity = new PhongKham {ID = Guid.NewGuid()};

            ctrlThongTinPhongKham1.InitThongTin(Entity);

            btnOK.Enabled = k == null || k.ID == Guid.Empty;
        }

        private void ctrlThongTinPhongKham1_SettingChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ctrlThongTinPhongKham1.ValidateData())
            {
                Entity = ctrlThongTinPhongKham1.SaveEntity();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
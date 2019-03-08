using System;
using System.Windows.Forms;
using BV.DataModel;

namespace BV.QuanTriHeThong.KhoaPhongBV
{
    public partial class ThongTinKhoaForm : Form
    {
        public ThongTinKhoaForm()
        {
            InitializeComponent();
        }

        public Khoa Entity { get; internal set; }

        public void InitThongTin(Khoa k)
        {
            Entity = k;
            if (Entity == null) Entity = new Khoa {ID = Guid.NewGuid()};

            ctrlThongTinKhoa1.InitThongTin(Entity);

            btnOK.Enabled = k == null || k.ID == Guid.Empty;
        }

        private void ctrlThongTinKhoa1_SettingChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ctrlThongTinKhoa1.ValidateData())
            {
                Entity = ctrlThongTinKhoa1.SaveEntity();
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
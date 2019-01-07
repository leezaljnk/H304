using BV.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV.QuanTriHeThong.KhoaPhongBV
{
    public partial class ThongTinKhoaForm : Form
    {
        public Khoa Entity { get; internal set; }

        public ThongTinKhoaForm()
        {
            InitializeComponent();
        }

        public void InitThongTin(Khoa k)
        {
            Entity = k;
            if (Entity == null)
            {
                Entity = new Khoa() { ID = Guid.NewGuid() };
            }

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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

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
    public partial class TemplateForm : Form
    {
        public PhongKham Entity { get; internal set; }

        public TemplateForm()
        {
            InitializeComponent();
        }

        public void InitThongTin(PhongKham k)
        {
            //Entity = k;
            //if (Entity == null)
            //{
            //    Entity = new PhongKham() { ID = Guid.NewGuid() };
            //}

            ////ctrlThongTinPhongKham1.InitThongTin(Entity);

            //btnOK.Enabled = k == null || k.ID == Guid.Empty;
        }

        private void ctrlThongTinPhongKham1_SettingChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //if (ctrlThongTinPhongKham1.ValidateData())
            //{
            //    Entity = ctrlThongTinPhongKham1.SaveEntity();
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

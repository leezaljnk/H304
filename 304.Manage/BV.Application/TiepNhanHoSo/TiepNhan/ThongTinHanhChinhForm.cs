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
    public partial class ThongTinHanhChinhForm : Form
    {
        public HS_CaNhan Entity { get; internal set; }

        public ThongTinHanhChinhForm()
        {
            InitializeComponent();
        }

        public void InitThongTin(HS_CaNhan k)
        {
            Entity = k;
            if (Entity == null)
            {
                Entity = new HS_CaNhan() { ID = Guid.NewGuid() };
            }

            //ctrlThongTinPhongKham1.InitThongTin(Entity);

            btnOK.Enabled = k == null || k.ID == Guid.Empty;
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

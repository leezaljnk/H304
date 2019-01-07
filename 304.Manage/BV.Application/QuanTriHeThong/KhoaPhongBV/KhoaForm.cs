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

namespace BV.TiepNhanHoSo.KhoaPhongBV
{
    public partial class KhoaForm : Form
    {
        private Khoa _entity = null;
        public KhoaForm()
        {
            InitializeComponent();
        }

        public void InitUI(Khoa k)
        {
            _entity = k;
            if (_entity == null)
            {
                _entity = new Khoa() { ID = Guid.NewGuid() };
                btnOK.Enabled = true;
            }

            ctrlThongTinKhoa1.InitUI(k);
        }

        private void ctrlThongTinKhoa1_SettingChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ctrlThongTinKhoa1.ValidateData())
            {
                _entity = ctrlThongTinKhoa1.SaveEntity();
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

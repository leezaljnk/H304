using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV.QLKHO.PhieuNhapThuoc
{
    public partial class PhieuNhapForm : Form
    {
        public PhieuNhapForm()
        {
            InitializeComponent();
        }

        public void InitData(Guid phieuID)
        {
            this.phieuNhapThuocCtrl1.InitControl(phieuID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

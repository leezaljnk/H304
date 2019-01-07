using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Winforms;

namespace Common.Winforms.UserControls.WaitingControl
{
    public partial class UCWaiting : Form, ISplashProcess
    {        
        private bool mblnClose = false;
        public UCWaiting()
        {
            InitializeComponent();
            btnClose.SetToolTip("Đóng thông báo!");
        }
        
        public void SetStatusInfo(string NewStatusInfo)
        {
            lbStatusInfo.Text = NewStatusInfo;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

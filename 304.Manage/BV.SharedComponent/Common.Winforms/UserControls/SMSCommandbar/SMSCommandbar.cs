using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common.Winforms.UserControls.SMSCommandbar
{
    public partial class SMSCommandbar : UserControl
    {
        private const string cs_Master_Title = "Bảng tổng hợp";
        private const string cs_Detail_Title = "Bảng chi tiết";
        public SMSCommandbar()
        {
            InitializeComponent();
        }

        public ISMSCommandHandle CommandHandle { get; set; }

        private bool _isMaster;
        public bool IsMaster 
        {
            get { return _isMaster; }
            set
            {
                _isMaster = value;
                if (_isMaster)
                    btnSwicth.Text = cs_Master_Title;
                else
                    btnSwicth.Text = cs_Detail_Title; 
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CommandHandle != null)
                CommandHandle.OnSave();
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {
            if (CommandHandle != null)
                CommandHandle.OnSMS();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (CommandHandle != null)
                CommandHandle.OnClose();
        }

        private void btnSwicth_Click(object sender, EventArgs e)
        {
            if (CommandHandle != null)
                CommandHandle.OnSwicth();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (CommandHandle != null)
                CommandHandle.OnSearch();
        }

        public void OnKeyPreview(object sender, KeyEventArgs e)
        {
            if (e.Alt || e.Control || e.Shift)
                return;
            switch ((int)e.KeyCode)
            {
                
                case (int)KEYVALUE.SAVE:
                    if (btnSave.Enabled)
                        btnSave_Click(sender, e);
                    break;
                
                case (int)KEYVALUE.EXIT:
                    if (btnClose.Enabled)
                        btnClose_Click(sender, e);
                    break;
                
                case (int)KEYVALUE.SEARCH:
                    if (btnSearch.Enabled)
                        btnSearch_Click(sender, e);
                    break;
                
                default: break;
            }
        }

        public bool EnableSwitch
        {
            set
            {
                btnSwicth.Visible = value;
            }
        }

        public bool EnableSearch
        {
            set
            {
                //btnSearchSp.Visible = btnSearch.Visible = value;
            }
        }

        public bool EnableSMS
        {
            set
            {
                //btnSMS.Visible = btnSMSSp.Visible = value;
            }
        }

    }
}

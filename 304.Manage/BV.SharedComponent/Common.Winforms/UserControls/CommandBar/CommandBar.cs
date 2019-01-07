using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common.Winforms.UserControls.CommandBar
{
    public partial class CommandBar : UserControl
    {
        public CommandBar()
        {
            InitializeComponent();
        }
        #region Event handle
        public ICommandBarHandle CommandHandle
        {
            get;
            set;
        } 
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CommandHandle != null)
            {
                CommandHandle.OnSave();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CommandHandle != null)
            {
                CommandHandle.OnDelete();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (CommandHandle != null)
            {
                CommandHandle.OnRefresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CommandHandle != null)
            {
                CommandHandle.OnClose();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (CommandHandle != null)
                CommandHandle.OnSearch();
        }
        #endregion
        /// <summary>
        /// Handle key press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnKeyPreview(object sender, KeyEventArgs e)
        {
            if (e.Alt || e.Control || e.Shift)
                return;
            switch ((int)e.KeyCode)
            {
                case (int)KEYVALUE.HELP:
                    if (btnHelp.Enabled)
                        btnHelp_Click(sender, e);
                    break;
                
                case (int)KEYVALUE.DELETE:
                    if (btnDelete.Enabled)
                        btnDelete_Click(sender, e);
                    break;
                case (int)KEYVALUE.SAVE:
                    if (btnSave.Enabled)
                        btnSave_Click(sender, e);
                    break;
                case (int)KEYVALUE.EXIT:
                    if (btnCancel.Enabled)
                        btnCancel_Click(sender, e);
                    break;                
                case (int)KEYVALUE.REFRESH:
                    if (btnRefresh.Enabled)
                        btnRefresh_Click(sender, e);
                    break;
                case (int) KEYVALUE.SEARCH:
                    if (btnSearch.Enabled)
                        btnSearch_Click(sender, e);
                    break;
                default: break;
            }
        }

        public void EnableButton(ActionTypes action)
        {
            switch (action)
            { 
                case ActionTypes.Insert:
                    btnDelete.Enabled = false;
                    break;  
                case ActionTypes.Refresh:
                    btnDelete.Enabled = true && !PublicVariables.View;
                    btnSave.Enabled = true && !PublicVariables.View;
                    break;
            }
        }

        public void EnableSearch()
        {
            grpSearch.Visible = true;
        }

        
    }
}

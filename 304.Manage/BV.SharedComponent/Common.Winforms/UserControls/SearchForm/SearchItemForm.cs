using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common.Winforms
{
    public partial class SearchItemForm : Telerik.WinControls.UI.RadForm
    {
        public delegate void SearchMethod(string value);
        public SearchMethod OnSearch;
        public SearchItemForm()
        {
            InitializeComponent();
            this.InitUserControl();
        }       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (OnSearch != null)
            {
                OnSearch(txtContent.Text);
            }
        }
    }
}

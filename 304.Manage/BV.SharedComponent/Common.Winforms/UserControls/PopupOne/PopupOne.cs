using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
//using System.Data.Objects.DataClasses;

namespace Common.Winforms.UserControls.PopupOne
{
    public partial class PopupOne : Telerik.WinControls.UI.RadForm
    {
        public PopupOne()
        {
            InitializeComponent();
        }

        public DataTable DataSource             
        {
            set
            {
                radGridView1.DataSource = value;
            }
        }
    }
}

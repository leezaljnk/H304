using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Winforms.UserControls.SubToolbar
{
    public partial class AddEditToolbar : UserControl
    {
        public AddEditToolbar()
        {
            InitializeComponent();
        }

        public IAddEditEvent GenaralEvent { get; set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (GenaralEvent != null) GenaralEvent.OnAdd();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (GenaralEvent != null) GenaralEvent.OnEdit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GenaralEvent != null) GenaralEvent.OnDelete();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (GenaralEvent != null) GenaralEvent.OnSave();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (GenaralEvent != null) GenaralEvent.OnPrint();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (GenaralEvent != null) GenaralEvent.OnRefresh();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (GenaralEvent != null) GenaralEvent.OnHelp();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (GenaralEvent != null) GenaralEvent.OnClose();
        }
    }
}

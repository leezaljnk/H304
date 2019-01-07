using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Winforms.UserControls.AddRemoveCommand
{
    public partial class UAddRemoveCommand : UserControl
    {
        public UAddRemoveCommand()
        {
            InitializeComponent();
        }

        public IAddRemoveEvent GeneralEvent { get; set; }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (GeneralEvent != null) GeneralEvent.OnAdd();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (GeneralEvent != null) GeneralEvent.OnRemove();
        }
    }
}

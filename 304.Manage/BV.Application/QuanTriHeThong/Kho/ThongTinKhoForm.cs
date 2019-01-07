using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV.QuanTriHeThong.Kho
{
    public partial class ThongTinKhoForm : Form
    {
        public ThongTinKhoForm()
        {
            InitializeComponent();
        }

        public object Entity { get; internal set; }

        internal void InitThongTin(object p)
        {
            throw new NotImplementedException();
        }
    }
}

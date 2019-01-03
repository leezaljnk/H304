using System;
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
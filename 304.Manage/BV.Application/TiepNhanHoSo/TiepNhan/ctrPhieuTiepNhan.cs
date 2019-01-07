using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV.TiepNhanHoSo
{
    public partial class ctrPhieuTiepNhan : UserControl
    {
        public ctrPhieuTiepNhan()
        {
            InitializeComponent();
        }

        public void InitControlUI()
        {
            ctrlThongTinHanhChinh1.InitControlUI();
        }
    }
}

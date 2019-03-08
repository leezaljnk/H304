using System.Windows.Forms;

namespace BV.TiepNhanHoSo
{
    public partial class TiepNhanForm : Form
    {
        public TiepNhanForm()
        {
            InitializeComponent();
        }

        public void InitThongTin()
        {
            ctrPhieuTiepNhan.InitControlUI();
        }
    }
}
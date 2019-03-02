using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BV.DataModel;
using Common.Winforms.UserControls;

namespace BV.QLKHO.KhoChan.XuatThuoc
{
    public partial class XuatThuocBenhNhanForm : FormBase
    {
        public XuatThuocBenhNhanForm()
        {
            InitializeComponent();
        }

        public void InitData(LoaiKhoType loaiKho)
        {
            xuatThuocBNCtrl1.InitControl(loaiKho);
        }
    }
}

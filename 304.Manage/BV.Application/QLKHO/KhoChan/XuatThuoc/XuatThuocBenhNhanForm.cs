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
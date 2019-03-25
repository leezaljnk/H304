using System;
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

        public void InitData(LoaiKhoType loaiKho, PhieuDeNghiLoaiType loaiPhieuDeNghi)
        {
            switch (loaiPhieuDeNghi)
            {
                case PhieuDeNghiLoaiType.NhapKho:
                    Text = "Nhập kho";
                    break;
                case PhieuDeNghiLoaiType.XuatToiKho:
                    Text = "Xuất thuốc tới kho";
                    break;
                case PhieuDeNghiLoaiType.XuatBNNoiTru:
                    Text = "Xuất thuốc cho bệnh nhân Nội trú";
                    break;
                case PhieuDeNghiLoaiType.XuatBNNgoaiTru:
                    Text = "Xuất thuốc cho bệnh nhân Ngoại trú";
                    break;
                case PhieuDeNghiLoaiType.XuatTuThien:
                    Text = "Xuất thuốc Từ thiện";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(loaiPhieuDeNghi), loaiPhieuDeNghi, null);
            }
            xuatThuocBNCtrl1.InitControl(loaiKho, loaiPhieuDeNghi);
        }
    }
}
using System.Collections.Generic;

namespace BV.DataModel
{
    //public class PhieuNhapKhoModel : PhieuNhapKho
    //{
    //    public List<PhieuNhapChiTiet> ChiTietPhieuNhaps { get; set; }
    //}

    public enum LoaiChietKhauType
    {
        PhanTram = 1,
        TienMat = 2
    }

    public enum LoaiKhoType
    {
        KhoChan = 1,
        KhoLe = 2,
        TuTruc = 3
    }

    public enum LoaiKhoaType
    {
        NoiTru = 1,
        NgoaiVien = 2,
        NgoaiTru = 3,
        CanLamSang = 4,
        ChucNang = 5
    }

    public enum PhieuDeNghiTinhTrangType
    {
        ChuaDuyet = 1,
        DaDuyet = 2,
        DaHuy = 3
    }

    public enum PhieuDeNghiLoaiType
    {
        NhapKho = 1,
        XuatKho = 2,
        XuatBNNoiTru = 3,
        XuatBNBanTru = 4,
        XuatTuThien =5
    }
}

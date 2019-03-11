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
        KhoLeNgoaiTru = 2,
        KhoLeNoiTru = 3,
        KhoDongY = 4,
        TuTruc = 5
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
        XuatTuThien = 5
    }

    public enum PhieuTraThuocType
    {
        ChuaDuyet = 1,
        DaDuyet = 2,
        Huy = 3
    }
}
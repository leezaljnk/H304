using System;

namespace BV.AppCommon
{
    public static class PublicVariable
    {
        public static string CurrentUserID;
        public static string CurrentMaKho;
        public static Guid CurrentKhoId = new Guid("091A8248-7B4E-4AD9-A794-7EAB9467320E");
        public static string PhieuNhapKhoCode = "PN";
        public static string PhieuNhapKhoHD = "HDN";

        public static string PhieuXuatKhoCode = "PX";
        public static string PhieuXuatKhoHD = "HDX";

        public static string PhieuXuatTraKhoCode = "PXT";
        public static string PhieuXuatTraKhoHD = "HDXT";
        
        public static string MaKhoChan = "KC-KHOTONG";
        public static string MaKhoLeNgoaiTru = "KL-NGOAITRU";
        public static string MaKhoLeNoiTru = "KL-NOITRU";
        public static string MaKhoNganHangMau = "KL-NGANHANGMAU";
        public static string MaKhoDongY = "KL-DONGY";
    }
}

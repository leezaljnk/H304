using System;
using System.Collections.Generic;
using System.Linq;
using BV.DataModel;
using BV.DAO;

namespace BV.BUS
{
    public class BusKho
    {
        public static string InitMaPhieuNhap()
        {
            var phieuCount = BusApp.CountRecords<PhieuNhapKho>();
            return $"PN{DateTime.Today.ToString("yyymmdd")}{phieuCount}";
        }

        public static bool SavePhieuNhapKhoTuNhaCungCap(PhieuNhapKho phieuNhap)
        {
            return DAOKho.SavePhieuNhapKhoTuNhaCungCap(phieuNhap);
        }

        public static IQueryable<PhieuTraThuoc> GetPhieuTraThuoc(string maPhieu, DateTime? tuNgay, DateTime? denNgay)
        {
            return DAOKho.GetPhieuTraThuoc(maPhieu, tuNgay, denNgay);
        }

        //tra thuoc
        public static string InitMaPhieuXuatTra()
        {
            var phieuCount = BusApp.CountRecords<XuatTra>();
            return $"PN{DateTime.Today.ToString("yyymmdd")}{phieuCount}";
        }

        public static bool SaveXuatTraThuoc(PhieuTraThuoc phieuTra)
        {
            return DAOKho.SaveXuatTraThuoc(phieuTra, InitMaPhieuNhap(), InitMaPhieuXuatTra());
        }

        public static IQueryable<XuatTra> GetXuatTra(DateTime? tuNgay, DateTime? denNgay, Guid? nguoiLap)
        {
            return DAOKho.GetXuatTra(tuNgay, denNgay, nguoiLap);
        }
    }
}
using BV.AppCommon;
using BV.DAO;
using BV.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public  static IQueryable<PhieuTraThuoc> GetPhieuTraThuoc(string maPhieu, DateTime? tuNgay, DateTime? denNgay)
        {
            return DAOKho.GetPhieuTraThuoc(maPhieu, tuNgay, denNgay);
        }

        //tra thuoc
        public static bool SaveXuatTraThuoc(PhieuTraThuoc phieuTra)
        {
            return DAOKho.SaveXuatTraThuoc(phieuTra, InitMaPhieuNhap());
        }
    }
}

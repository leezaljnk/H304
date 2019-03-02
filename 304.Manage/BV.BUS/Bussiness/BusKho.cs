using BV.AppCommon;
using BV.DAO;
using BV.DataModel;
using System;
using System.Collections.Generic;

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


    }
}

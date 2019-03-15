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
            return $"PXT{DateTime.Today.ToString("yyymmdd")}{phieuCount}";
        }

        public static bool SaveXuatTraThuoc(PhieuTraThuoc phieuTra)
        {
            return DAOKho.SaveXuatTraThuoc(phieuTra, InitMaPhieuNhap(), InitMaPhieuXuatTra());
        }

        public static IQueryable<XuatTra> GetXuatTra(DateTime? tuNgay, DateTime? denNgay, Guid? nguoiLap)
        {
            return DAOKho.GetXuatTra(tuNgay, denNgay, nguoiLap);
        }

        public static IQueryable<PhieuDeNghi> GetPhieuDeNghi(DateTime? tuNgay, DateTime? denNgay, Guid? khoId, PhieuDeNghiLoaiType phieuDeNghiLoai, PhieuDeNghiTinhTrangType tinhTrang)
        {
            return DAOKho.GetPhieuDeNghi(tuNgay, denNgay, khoId, phieuDeNghiLoai, tinhTrang);
        }
        public static PhieuDeNghi GetPhieuDeNghi(string maPhieu, PhieuDeNghiLoaiType type)
        {
            return DAOKho.GetPhieuDeNghi(maPhieu, type);
        }
        public static void HuyPhieuDeNghi(Guid phieuDeNghiId, string lyDoHuy)
        {
            DAOKho.HuyPhieuDenghi(phieuDeNghiId, lyDoHuy);
        }

        public static bool DuyetPhieuDeNghi(PhieuDeNghi phieuDeNghi)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<Thuoc_VatTuYteTonKho> GetThuocTonKho(IEnumerable<Guid?> thuocIds)
        {
            return DAOKho.GetThuocTonKhoByIds(thuocIds);
        }
    }
}
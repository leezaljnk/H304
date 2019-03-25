using System;
using System.Collections.Generic;
using System.Linq;
using BV.AppCommon;
using BV.DataModel;
using BV.DAO;

namespace BV.BUS
{
    public class BusKho
    {
        public static int CountRecords<T>() where T : class
        {
            return DAOApp.CountRecords<T>();
        }
        public static string InitMaPhieuNhap(string special)
        {
            var phieuCount = BusApp.CountRecords<PhieuNhapKho>();
            return $"{special}{DateTime.Today.ToString("yyymmdd")}{phieuCount}";
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
        public static string InitMaPhieuXuatTra(string special)
        {
            var phieuCount = BusApp.CountRecords<XuatTra>();
            return $"{special}{DateTime.Today.ToString("yyymmdd")}{phieuCount}";
        }

        public static bool SaveXuatTraThuoc(PhieuTraThuoc phieuTra)
        {
            return DAOKho.SaveXuatTraThuoc(phieuTra, InitMaPhieuNhap(PublicVariable.PhieuNhapKhoCode), InitMaPhieuXuatTra(PublicVariable.PhieuXuatTraKhoCode), InitMaPhieuNhap(PublicVariable.PhieuNhapKhoHD));
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

        public static bool DuyetPhieuDeNghi(PhieuDeNghi phieuDeNghi, PhieuDeNghiLoaiType phieuDeNghiLoai)
        {
           var maPhieuNhap = InitMaPhieuNhap(PublicVariable.PhieuNhapKhoCode);
           var maHdNhap = InitMaPhieuNhap(PublicVariable.PhieuNhapKhoHD);
            return DAOKho.DuyetPhieuDeNghi(phieuDeNghi, phieuDeNghiLoai, maPhieuNhap, maHdNhap);
        }

        public static IEnumerable<Thuoc_VatTuYteTonKho> GetThuocTonKho(IEnumerable<Guid?> thuocIds)
        {
            return DAOKho.GetThuocTonKhoByIds(thuocIds);
        }

        public static Kho GetKhoByCode(string code)
        {
            return DAOKho.GetKhoByCode(code);
        }
        public static Kho GetKhoById(Guid id)
        {
            return DAOKho.GetKhoById(id);
        }
    }
}
using BV.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BV.DAO
{
    public class DAOKho
    {
        public static DinhGiaHangHoa GetGiaThuoc(Guid thuocID)
        {
            try
            {
                //var giaThuoc = DAOApp.DbContext.DinhGiaHangHoa.FirstOrDefault(t => t.HangHoaID == thuocID);
                //DAOApp.DbContext.Entry(giaThuoc).State = EntityState.Detached;
                //return giaThuoc;
                return DAOApp.DbContext.DinhGiaHangHoa.FirstOrDefault(t => t.HangHoaID == thuocID);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<ChuyenDoiDonViHangHoa> GetChuyenDoiDonViThuoc(Guid hangHoaID)
        {
            try
            {
                return DAOApp.DbContext.ChuyenDoiDonViHangHoa.Where(t => t.HangHoaID == hangHoaID).ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static void SaveThuoc304(HangHoa oThuoc, DinhGiaHangHoa giaThuoc, List<ChuyenDoiDonViHangHoa> lstDonVi)
        {
            try
            {
                var thuoc = DAOApp.DbContext.HangHoa.FirstOrDefault(t => t.ID == oThuoc.ID);
                if (thuoc == null)
                {
                    DAOApp.DbContext.HangHoa.Add(oThuoc);
                }
                else
                {
                    thuoc.Ten= oThuoc.Ten;
                    thuoc.TenKhac = oThuoc.TenKhac;
                    thuoc.Ma = oThuoc.Ma;
                    thuoc.HoatChat = oThuoc.HoatChat;
                    thuoc.HamLuong = oThuoc.HamLuong;
                    thuoc.DuongDung = oThuoc.DuongDung;
                    thuoc.DongGoi = oThuoc.DongGoi;
                    thuoc.HoTriLieu = oThuoc.HoTriLieu;
                    thuoc.DonViID = oThuoc.DonViID;
                }

                var updateItem = DAOApp.DbContext.DinhGiaHangHoa.FirstOrDefault(t => t.HangHoaID == giaThuoc.HangHoaID);
                if (updateItem == null)
                {
                    DAOApp.DbContext.DinhGiaHangHoa.Add(giaThuoc);
                }
                else
                {
                    if (giaThuoc.GiaDichVu != updateItem.GiaDichVu || giaThuoc.GiaBaoHiem != updateItem.GiaBaoHiem)
                    {
                        //Save change
                        giaThuoc.GiaDichVu = updateItem.GiaDichVu;
                        giaThuoc.GiaBaoHiem = updateItem.GiaBaoHiem;
                        //giaThuoc.GhiChu = updateItem.GhiChu;
                        giaThuoc.MaNguoiDinhGia = updateItem.MaNguoiDinhGia;
                        giaThuoc.TenNguoiDinhGia = updateItem.TenNguoiDinhGia;
                        giaThuoc.ThoiGianCapNhat = DateTime.Now;
                    }
                }
                //var lstOriginalGiaThuoc = KhoChungProvider.KhoTong.DinhGiaHangHoa.Where(t => t.HangHoaID == oThuoc.ID).ToList();
                //foreach (var updateItem in lstGiaThuoc)
                //{
                //    //var giaThuoc = KhoChungProvider.KhoTong.DinhGiaHangHoa.FirstOrDefault(t => t.HangHoaID == updateItem.HangHoaID && t.LoaiGiaID == updateItem.LoaiGiaID);
                //    var giaThuoc = lstOriginalGiaThuoc.FirstOrDefault(t => t.HangHoaID == updateItem.HangHoaID && t.LoaiGiaID == updateItem.LoaiGiaID);
                //    if (giaThuoc == null)
                //    {
                //        KhoChungProvider.KhoTong.DinhGiaHangHoa.Add(updateItem);
                //    }
                //    else
                //    {
                //        lstOriginalGiaThuoc.Remove(giaThuoc);
                //        if (giaThuoc.GiaTien != updateItem.GiaTien)
                //        {
                //            //Save change
                //            giaThuoc.GiaTien = updateItem.GiaTien;
                //            giaThuoc.GhiChu = updateItem.GhiChu;
                //            giaThuoc.MaNguoiDinhGia = updateItem.MaNguoiDinhGia;
                //            giaThuoc.TenNguoiDinhGia = updateItem.TenNguoiDinhGia;
                //            giaThuoc.ThoiGianCapNhat = DateTime.Now;
                //        }
                //    }
                //}

                //KhoChungProvider.KhoTong.DinhGiaHangHoa.RemoveRange(lstOriginalGiaThuoc);



                //Save thông tin các đơn vị thuốc
                var removeDonvi = DAOApp.DbContext.ChuyenDoiDonViHangHoa.Where(d => d.HangHoaID == oThuoc.ID).ToList();
                //Don vi chinh
                {
                    var donvi = DAOApp.DbContext.ChuyenDoiDonViHangHoa.FirstOrDefault(d => d.DonViID == oThuoc.DonViID && d.HangHoaID == oThuoc.ID);
                    if (donvi == null)
                    {
                        var dv = new ChuyenDoiDonViHangHoa();
                        dv.ID = Guid.NewGuid();
                        dv.HangHoaID = oThuoc.ID;
                        dv.DonViID = oThuoc.DonViID.Value;
                        dv.TiLeChuyenDoi = 1;
                        dv.PhuongThucChuyenDoi = 1;
                        dv.MoTa = "Đơn vị chính";

                        DAOApp.DbContext.ChuyenDoiDonViHangHoa.Add(dv);
                    }
                    else
                    {
                        removeDonvi.RemoveAll(d => d.ID == oThuoc.ID);
                        donvi.TiLeChuyenDoi = 1;
                        donvi.PhuongThucChuyenDoi = 1;
                        donvi.MoTa = "Đơn vị chính";
                    }
                }

                //Đơn vị chuyển đổi
                foreach (var dv in lstDonVi)
                {
                    var donvi = DAOApp.DbContext.ChuyenDoiDonViHangHoa.FirstOrDefault(d => d.ID == dv.ID);
                    if (donvi == null)
                    {   
                        DAOApp.DbContext.ChuyenDoiDonViHangHoa.Add(dv);
                    }
                    else
                    {
                        removeDonvi.RemoveAll(d => d.ID == dv.ID);
                        donvi.DonViID = dv.DonViID;
                        donvi.TiLeChuyenDoi = dv.TiLeChuyenDoi;
                        donvi.PhuongThucChuyenDoi = dv.PhuongThucChuyenDoi;
                        donvi.MoTa = dv.MoTa;
                    }
                }

                DAOApp.DbContext.ChuyenDoiDonViHangHoa.RemoveRange(removeDonvi);
                //foreach (var item in removeDonvi)
                //{
                //    KhoChungProvider.KhoTong.ChuyenDoiDonViHangHoa.RemoveRange(removeDonvi);
                //}

                DAOApp.DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static QuyetDinhThau SaveThongTinQuyetDinhThau(QuyetDinhThau oEntity)
        {
            QuyetDinhThau oRet = null;
            if (oEntity.ID == Guid.Empty)
            {
                //Add
                oRet = DAOApp.DbContext.QuyetDinhThau.FirstOrDefault(l => l.Ma == oEntity.Ma);
                if (oRet != null)
                {
                    throw new Exception("Quyết định đã có trên hệ thống.");
                }
                else
                {
                    oEntity.ID = Guid.NewGuid();
                    oRet = DAOApp.DbContext.QuyetDinhThau.Add(oEntity);
                }
            }
            else
            {
                oRet = DAOApp.DbContext.QuyetDinhThau.FirstOrDefault(l => l.ID == oEntity.ID);
                oRet.Ma = oEntity.Ma;
                oRet.MoTa = oEntity.MoTa;
                oRet.NgayQuyetDinh = oEntity.NgayQuyetDinh;
                oRet.HieuLuc = oEntity.HieuLuc;
            }

            DAOApp.DbContext.SaveChanges();
            return oRet;
        }

        public static LoHangHoa SaveThongTinLoHang(LoHangHoa oEntity)
        {
            LoHangHoa oRet = null;
            if (oEntity.ID == Guid.Empty)
            {
                //Add
                oRet = DAOApp.DbContext.LoHangHoa.FirstOrDefault(l => l.ThuocVtytID == oEntity.ThuocVtytID && l.SoLo == oEntity.SoLo);
                if (oRet != null)
                {
                    throw new Exception("Lô hàng này đã có trên hệ thống.");
                }
                else
                {
                    oEntity.ID = Guid.NewGuid();
                    oRet = DAOApp.DbContext.LoHangHoa.Add(oEntity);
                }
            }
            else
            {
                oRet = DAOApp.DbContext.LoHangHoa.FirstOrDefault(l => l.ID == oEntity.ID);
                oRet.SoLo = oEntity.SoLo;
                oRet.HanSuDung = oEntity.HanSuDung;
            }

            DAOApp.DbContext.SaveChanges();
            return oRet;
        }

        public static NhaCungCap SaveNhaCungCap(NhaCungCap oEntity)
        {
            var ncc = DAOApp.DbContext.NhaCungCap.FirstOrDefault(n => n.ID == oEntity.ID);
            if (ncc == null)
            {
                ncc = DAOApp.DbContext.NhaCungCap.Add(oEntity);
            }
            else
            {
                ncc.Ten = oEntity.Ten;
                ncc.DiaChi = oEntity.DiaChi;
                ncc.TinhThanh = oEntity.TinhThanh;
                ncc.QuocGia = oEntity.QuocGia;
                ncc.DienThoai = oEntity.DienThoai;
                ncc.Fax = oEntity.Fax;
                ncc.GhiChu = oEntity.GhiChu;
                ncc.Email = oEntity.Email;
                ncc.WebSite = oEntity.WebSite;
            }

            DAOApp.DbContext.SaveChanges();
            return ncc;
        }

        public static bool SavePhieuNhapKhoTuNhaCungCap(PhieuNhapKhoModel oEntity)
        {
            var phieuNhap = new PhieuNhapKho
            {
                ID = Guid.NewGuid(),
                Ma = oEntity.Ma,
                MaNhaCungCap = oEntity.MaNhaCungCap,
                MaPhanLoaiHoaDon = oEntity.MaPhanLoaiHoaDon,
                NgayHoaDon = oEntity.NgayHoaDon,
                NgayTao = oEntity.NgayTao,
                NguoiCungCap = oEntity.NguoiCungCap,
                NguoiTao = oEntity.NguoiTao,
                NhaCungCap = oEntity.NhaCungCap,
                PhanLoaiHoaDon = oEntity.PhanLoaiHoaDon,
                PhieuDeNghiId = oEntity.PhieuDeNghiId,
                SoHoaDon = oEntity.SoHoaDon,
                TenPhanLoaiHoaDon = oEntity.TenPhanLoaiHoaDon,
                ThanhTien = oEntity.ThanhTien,
                TongTien = oEntity.TongTien,
                VAT = oEntity.VAT
            };
            DAOApp.DbContext.PhieuNhapKho.Add(phieuNhap);
            DAOApp.DbContext.SaveChanges();

            foreach (var chiTietPhieu in oEntity.ChiTietPhieus)
            {
                var chiTiet = new ChiTietPhieu
                {
                    ID = Guid.NewGuid(),
                    LoaiChietKhau = chiTietPhieu.LoaiChietKhau,
                    ThanhTien = chiTietPhieu.ThanhTien,
                    ChietKhau = chiTietPhieu.ChietKhau,
                    DonGia = chiTietPhieu.DonGia,
                    HanSuDung = chiTietPhieu.HanSuDung,
                    HangHoaID = chiTietPhieu.HangHoaID,
                    LoHangID = chiTietPhieu.LoHangID,
                    MaDonVi = chiTietPhieu.MaDonVi,
                    PhieuID = phieuNhap.ID,
                    SoLuong = chiTietPhieu.SoLuong,
                    SoQuyeDinh = chiTietPhieu.SoQuyeDinh,
                    TenDonVi = chiTietPhieu.TenDonVi
                };
                DAOApp.DbContext.ChiTietPhieu.Add(chiTiet);
            }
            //DAOApp.DbContext.ChiTietPhieu.AddRange(oEntity.ChiTietPhieus);
            DAOApp.DbContext.SaveChanges();
           
            return true;
        }
    }
}

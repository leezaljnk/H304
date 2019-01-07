using BV.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BV.DataConnector
{
    public class KhoDAO
    {
        public static DinhGiaHangHoa GetGiaThuoc(Guid thuocID)
        {
            try
            {
                return AppDAO.DbContext.DinhGiaHangHoa.FirstOrDefault(t => t.HangHoaID == thuocID);
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
                return AppDAO.DbContext.ChuyenDoiDonViHangHoa.Where(t => t.HangHoaID == hangHoaID).ToList();
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
                var thuoc = AppDAO.DbContext.HangHoa.FirstOrDefault(t => t.ID == oThuoc.ID);
                if (thuoc == null)
                {
                    AppDAO.DbContext.HangHoa.Add(oThuoc);
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

                var updateItem = AppDAO.DbContext.DinhGiaHangHoa.FirstOrDefault(t => t.HangHoaID == giaThuoc.HangHoaID);
                if (updateItem == null)
                {
                    AppDAO.DbContext.DinhGiaHangHoa.Add(giaThuoc);
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
                var removeDonvi = AppDAO.DbContext.ChuyenDoiDonViHangHoa.Where(d => d.HangHoaID == oThuoc.ID).ToList();
                //Don vi chinh
                {
                    var donvi = AppDAO.DbContext.ChuyenDoiDonViHangHoa.FirstOrDefault(d => d.DonViID == oThuoc.DonViID && d.HangHoaID == oThuoc.ID);
                    if (donvi == null)
                    {
                        var dv = new ChuyenDoiDonViHangHoa();
                        dv.ID = Guid.NewGuid();
                        dv.HangHoaID = oThuoc.ID;
                        dv.DonViID = oThuoc.DonViID.Value;
                        dv.TiLeChuyenDoi = 1;
                        dv.PhuongThucChuyenDoi = 1;
                        dv.MoTa = "Đơn vị chính";

                        AppDAO.DbContext.ChuyenDoiDonViHangHoa.Add(dv);
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
                    var donvi = AppDAO.DbContext.ChuyenDoiDonViHangHoa.FirstOrDefault(d => d.ID == dv.ID);
                    if (donvi == null)
                    {   
                        AppDAO.DbContext.ChuyenDoiDonViHangHoa.Add(dv);
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

                AppDAO.DbContext.ChuyenDoiDonViHangHoa.RemoveRange(removeDonvi);
                //foreach (var item in removeDonvi)
                //{
                //    KhoChungProvider.KhoTong.ChuyenDoiDonViHangHoa.RemoveRange(removeDonvi);
                //}

                AppDAO.DbContext.SaveChanges();
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
                oRet = AppDAO.DbContext.QuyetDinhThau.FirstOrDefault(l => l.Ma == oEntity.Ma);
                if (oRet != null)
                {
                    throw new Exception("Quyết định đã có trên hệ thống.");
                }
                else
                {
                    oEntity.ID = Guid.NewGuid();
                    oRet = AppDAO.DbContext.QuyetDinhThau.Add(oEntity);
                }
            }
            else
            {
                oRet = AppDAO.DbContext.QuyetDinhThau.FirstOrDefault(l => l.ID == oEntity.ID);
                oRet.Ma = oEntity.Ma;
                oRet.MoTa = oEntity.MoTa;
                oRet.NgayQuyetDinh = oEntity.NgayQuyetDinh;
                oRet.HieuLuc = oEntity.HieuLuc;
            }

            AppDAO.DbContext.SaveChanges();
            return oRet;
        }

        public static LoHangHoa SaveThongTinLoHang(LoHangHoa oEntity)
        {
            LoHangHoa oRet = null;
            if (oEntity.ID == Guid.Empty)
            {
                //Add
                oRet = AppDAO.DbContext.LoHangHoa.FirstOrDefault(l => l.ThuocVtytID == oEntity.ThuocVtytID && l.SoLo == oEntity.SoLo);
                if (oRet != null)
                {
                    throw new Exception("Lô hàng này đã có trên hệ thống.");
                }
                else
                {
                    oEntity.ID = Guid.NewGuid();
                    oRet = AppDAO.DbContext.LoHangHoa.Add(oEntity);
                }
            }
            else
            {
                oRet = AppDAO.DbContext.LoHangHoa.FirstOrDefault(l => l.ID == oEntity.ID);
                oRet.SoLo = oEntity.SoLo;
                oRet.HanSuDung = oEntity.HanSuDung;
            }

            AppDAO.DbContext.SaveChanges();
            return oRet;
        }

        public static NhaCungCap SaveNhaCungCap(NhaCungCap oEntity)
        {
            var ncc = AppDAO.DbContext.NhaCungCap.FirstOrDefault(n => n.NguonNhapID == oEntity.NguonNhapID);
            if (ncc == null)
            {
                ncc = AppDAO.DbContext.NhaCungCap.Add(oEntity);
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

            AppDAO.DbContext.SaveChanges();
            return ncc;
        }
    }
}

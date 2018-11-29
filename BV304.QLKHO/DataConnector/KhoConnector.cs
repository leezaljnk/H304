﻿using BV.AppCommon;
using BV.DataModel;
using BV.DataModel.KhoChung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV.DataConnector
{
    public class KhoConnector
    {
        public static List<T> GetDanhMuc<T>(int take = 0) where T: class
        {
            try
            {
                KhoChungProvider provider = new KhoChungProvider();

                if (take > 0)
                {
                    return provider.GetDanhMuc<T>(take);
                }
                else
                {
                    return provider.GetDanhMuc<T>();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DinhGiaHangHoa GetGiaThuoc(Guid thuocID)
        {
            try
            {
                return KhoChungProvider.KhoTong.DinhGiaHangHoa.FirstOrDefault(t => t.HangHoaID == thuocID);
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
                return KhoChungProvider.KhoTong.ChuyenDoiDonViHangHoa.Where(t => t.HangHoaID == hangHoaID).ToList();
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
                var thuoc = KhoChungProvider.KhoTong.HangHoa.FirstOrDefault(t => t.ID == oThuoc.ID);
                if (thuoc == null)
                {
                    KhoChungProvider.KhoTong.HangHoa.Add(oThuoc);
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

                var updateItem = KhoChungProvider.KhoTong.DinhGiaHangHoa.FirstOrDefault(t => t.HangHoaID == giaThuoc.HangHoaID);
                if (updateItem == null)
                {
                    KhoChungProvider.KhoTong.DinhGiaHangHoa.Add(giaThuoc);
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
                var removeDonvi = KhoChungProvider.KhoTong.ChuyenDoiDonViHangHoa.Where(d => d.HangHoaID == oThuoc.ID).ToList();
                //Don vi chinh
                {
                    var donvi = KhoChungProvider.KhoTong.ChuyenDoiDonViHangHoa.FirstOrDefault(d => d.DonViID == oThuoc.DonViID && d.HangHoaID == oThuoc.ID);
                    if (donvi == null)
                    {
                        var dv = new ChuyenDoiDonViHangHoa();
                        dv.ID = Guid.NewGuid();
                        dv.HangHoaID = oThuoc.ID;
                        dv.DonViID = oThuoc.DonViID.Value;
                        dv.TiLeChuyenDoi = 1;
                        dv.PhuongThucChuyenDoi = 1;
                        dv.MoTa = "Đơn vị chính";

                        KhoChungProvider.KhoTong.ChuyenDoiDonViHangHoa.Add(dv);
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
                    var donvi = KhoChungProvider.KhoTong.ChuyenDoiDonViHangHoa.FirstOrDefault(d => d.ID == dv.ID);
                    if (donvi == null)
                    {   
                        KhoChungProvider.KhoTong.ChuyenDoiDonViHangHoa.Add(dv);
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

                KhoChungProvider.KhoTong.ChuyenDoiDonViHangHoa.RemoveRange(removeDonvi);
                //foreach (var item in removeDonvi)
                //{
                //    KhoChungProvider.KhoTong.ChuyenDoiDonViHangHoa.RemoveRange(removeDonvi);
                //}

                KhoChungProvider.KhoTong.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static NhaCungCap SaveNhaCungCap(NhaCungCap oEntity)
        {
            var ncc = KhoChungProvider.KhoTong.NhaCungCap.FirstOrDefault(n => n.NguonNhapID == oEntity.NguonNhapID);
            if (ncc == null)
            {
                ncc = KhoChungProvider.KhoTong.NhaCungCap.Add(oEntity);
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

            KhoChungProvider.KhoTong.SaveChanges();
            return ncc;
        }
    }
}

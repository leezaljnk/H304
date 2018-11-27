using BV.AppCommon;
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
                KhoTongProvider provider = new KhoTongProvider();

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

        public static GiaThuoc GetGiaThuoc(Guid thuocID)
        {
            try
            {
                return KhoTongProvider.KhoTong.GiaThuoc.FirstOrDefault(t => t.ThuocID == thuocID);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<ChuyenDoiDonViThuoc> GetChuyenDoiDonViThuoc(Guid thuocID)
        {
            try
            {
                return KhoTongProvider.KhoTong.ChuyenDoiDonViThuoc.Where(t => t.ThuocID == thuocID).ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static void SaveThuoc304(Thuoc_VatTuYte oThuoc, GiaThuoc oGiaThuoc, List<ChuyenDoiDonViThuoc> lstDonVi)
        {
            try
            {
                var thuoc = KhoTongProvider.KhoTong.Thuoc_VatTuYte.FirstOrDefault(t => t.ID == oThuoc.ID);
                if (thuoc == null)
                {
                    KhoTongProvider.KhoTong.Thuoc_VatTuYte.Add(oThuoc);
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

                var giaThuoc = KhoTongProvider.KhoTong.GiaThuoc.FirstOrDefault(t => t.ThuocID == oGiaThuoc.ThuocID);
                if (giaThuoc == null)
                {
                    KhoTongProvider.KhoTong.GiaThuoc.Add(oGiaThuoc);
                }
                else
                {
                    giaThuoc.DonViID = oGiaThuoc.DonViID;
                    giaThuoc.GiaBaoHiem = oGiaThuoc.GiaBaoHiem;
                    giaThuoc.GiaChinhSach = oGiaThuoc.GiaChinhSach;
                    giaThuoc.GiaDichVu = oGiaThuoc.GiaDichVu;
                    giaThuoc.ThuocID = oGiaThuoc.ThuocID;
                }

                //Save thông tin các đơn vị thuốc
                var removeDonvi = KhoTongProvider.KhoTong.ChuyenDoiDonViThuoc.Where(d => d.ThuocID == oThuoc.ID).ToList();
                //Don vi chinh
                {
                    var donvi = KhoTongProvider.KhoTong.ChuyenDoiDonViThuoc.FirstOrDefault(d => d.DonViID == oThuoc.DonViID && d.ThuocID == oThuoc.ID);
                    if (donvi == null)
                    {
                        var dv = new ChuyenDoiDonViThuoc();
                        dv.ID = Guid.NewGuid();
                        dv.ThuocID = oThuoc.ID;
                        dv.DonViID = oThuoc.DonViID.Value;
                        dv.TiLeChuyenDoi = 1;
                        dv.PhuongThucChuyenDoi = 1;
                        dv.MoTa = "Đơn vị chính";

                        KhoTongProvider.KhoTong.ChuyenDoiDonViThuoc.Add(dv);
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
                    var donvi = KhoTongProvider.KhoTong.ChuyenDoiDonViThuoc.FirstOrDefault(d => d.ID == dv.ID);
                    if (donvi == null)
                    {   
                        KhoTongProvider.KhoTong.ChuyenDoiDonViThuoc.Add(dv);
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

                foreach (var item in removeDonvi)
                {
                    KhoTongProvider.KhoTong.ChuyenDoiDonViThuoc.RemoveRange(removeDonvi);
                }

                KhoTongProvider.KhoTong.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static NhaCungCap SaveNhaCungCap(NhaCungCap oEntity)
        {
            var ncc = KhoTongProvider.KhoTong.NhaCungCap.FirstOrDefault(n => n.NguonNhapID == oEntity.NguonNhapID);
            if (ncc == null)
            {
                ncc = KhoTongProvider.KhoTong.NhaCungCap.Add(oEntity);
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

            KhoTongProvider.KhoTong.SaveChanges();
            return ncc;
        }
    }
}

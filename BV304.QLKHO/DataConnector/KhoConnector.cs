using BV.AppCommon;
using BV.DataModel;
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

        public static void SaveThuoc304(Thuoc304 oThuoc, GiaThuoc oGiaThuoc, List<ChuyenDoiDonViThuoc> lstDonVi)
        {
            try
            {
                var thuoc = KhoTongProvider.KhoTong.Thuoc304.FirstOrDefault(t => t.ID == oThuoc.ID);
                if (thuoc == null)
                {
                    KhoTongProvider.KhoTong.Thuoc304.Add(oThuoc);
                }
                else
                {
                    thuoc.TEN_THUOC = oThuoc.TEN_THUOC;
                    thuoc.SO_DANG_KY = oThuoc.SO_DANG_KY;
                    thuoc.HOAT_CHAT = oThuoc.HOAT_CHAT;
                    thuoc.HAM_LUONG = oThuoc.HAM_LUONG;
                    thuoc.DUONG_DUNG = oThuoc.DUONG_DUNG;
                    thuoc.DONG_GOI = oThuoc.DONG_GOI;
                    thuoc.HO_TRI_LIEU = oThuoc.HO_TRI_LIEU;
                }
                KhoTongProvider.KhoTong.SaveChanges();

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

                //Save don vi chuyen doi
                var removeDonvi = KhoTongProvider.KhoTong.ChuyenDoiDonViThuoc.Where(d => d.ThuocID == oThuoc.ID).ToList();
                foreach (var dv in lstDonVi)
                {
                    var donvi = KhoTongProvider.KhoTong.ChuyenDoiDonViThuoc.FirstOrDefault(d => d.ID == dv.ID);
                    if (donvi == null)
                    {
                        removeDonvi.RemoveAll(d => d.ID == dv.ID);
                        KhoTongProvider.KhoTong.ChuyenDoiDonViThuoc.Add(dv);
                    }
                    else
                    {
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
    }
}

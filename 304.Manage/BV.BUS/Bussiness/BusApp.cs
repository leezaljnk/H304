using BV.AppCommon;
using BV.DAO;
using BV.DataModel;
using System;
using System.Collections.Generic;

namespace BV.BUS
{
    public class BusApp
    {
        public static int CountRecords<T>() where T : class
        {
            return DAOApp.CountRecords<T>();
        }
        public static List<T> GetDanhMuc<T>(bool bRefresh = false, int take = 0) where T : class
        {
            try
            {
                var coll = AppCached.GetDanhMuc<T>();
                if (bRefresh || coll == null)
                {
                    coll = DAOApp.GetDanhMuc<T>();
                    AppCached.AddDanhMuc<T>(coll);
                }
                return coll;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static HS_CaNhan GetHoSoCaNhanByID(Guid value)
        {
            throw new NotImplementedException();
        }

        public static DinhGiaHangHoa GetGiaThuoc(Guid thuocID)
        {
            try
            {
                return DAOKho.GetGiaThuoc(thuocID);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<ChuyenDoiDonViHangHoa> GetChuyenDoiDonViThuoc(Guid thuocID)
        {
            try
            {
                return DAOKho.GetChuyenDoiDonViThuoc(thuocID);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static void LuuThongTinHangHoa(HangHoa oThuoc, DinhGiaHangHoa oGiaThuoc, List<ChuyenDoiDonViHangHoa> lstDonVi)
        {
            try
            {
                DAOKho.SaveThuoc304(oThuoc, oGiaThuoc, lstDonVi);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static NhaCungCap SaveNhaCungCap(NhaCungCap oEntity)
        {
            try
            {
                return DAOKho.SaveNhaCungCap(oEntity);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static HS_BHYT GetSoBHYT(Guid value)
        {
            throw new NotImplementedException();
        }

        public static LoHangHoa SaveThongTinLoHang(LoHangHoa oEntity)
        {
            try
            {
                return DAOKho.SaveThongTinLoHang(oEntity);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static QuyetDinhThau SaveThongTinQuyetDinhThau(QuyetDinhThau oEntity)
        {
            try
            {
                return DAOKho.SaveThongTinQuyetDinhThau(oEntity);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static T SaveEntity<T>(T entity)
        {
            return entity;
        }

        public static HS_CaNhan GetHoSoCaNhanByMa(string text)
        {
            throw new NotImplementedException();
        }

        public static HS_BHYT UpdateHoSo_BHYT(Guid hSCN_ID, HS_BHYT hs)
        {
            throw new NotImplementedException();
        }

        public static bool SaveHS_CaNhan(Guid value, string v, HS_CaNhan entity)
        {
            throw new NotImplementedException();
        }

    }
}

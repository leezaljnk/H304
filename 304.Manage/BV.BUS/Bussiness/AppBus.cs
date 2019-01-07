﻿using BV.AppCommon;
using BV.DataConnector;
using BV.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BV.BUS
{
    public class AppBus
    {
        public static List<T> GetDanhMuc<T>(bool bRefresh = false, int take = 0) where T : class
        {
            try
            {
                var coll = AppCached.GetDanhMuc<T>();
                if (bRefresh || coll == null)
                {
                    coll = AppDAO.GetDanhMuc<T>();
                    AppCached.AddDanhMuc<T>(coll);
                }
                return coll;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void UpdateDanhMuc<T>(List<T> lstUpdate, string property) where T : class
        {
            try
            {
                PropertyInfo pInfo = typeof(T).GetProperty(property);

                Func<T, object> selector = t => pInfo.GetValue(t);
                var lstID = lstUpdate.Select(selector);

                var coll = AppCached.GetDanhMuc<T>();
                coll.RemoveAll(t => lstID.Contains(pInfo.GetValue(t)));
                coll.AddRange(lstUpdate);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void UpdateDanhMuc<T>(T entity, string property) where T : class
        {
            try
            {
                PropertyInfo pInfo = typeof(T).GetProperty(property);

                Func<T, object> selector = t => pInfo.GetValue(t);

                var coll = AppCached.GetDanhMuc<T>();
                var count = coll.RemoveAll(t => pInfo.GetValue(t).ToString() == pInfo.GetValue(entity).ToString());
                coll.Add(entity);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void UpdateDanhMuc<T>(T oldObject, T newObject) where T : class
        {
            try
            {
                var coll = AppCached.GetDanhMuc<T>();
                bool bFould = false;
                for (int i = 0; i < coll.Count; i++)
                {
                    if (coll[i] == oldObject)
                    {
                        coll[i] = newObject;
                        bFould = true;
                        break;
                    }
                }

                if (!bFould)
                    coll.Add(newObject);
            }
            catch (Exception ex)
            {
                throw;
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
                return KhoDAO.GetGiaThuoc(thuocID);
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
                return KhoDAO.GetChuyenDoiDonViThuoc(thuocID);
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
                KhoDAO.SaveThuoc304(oThuoc, oGiaThuoc, lstDonVi);
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
                return KhoDAO.SaveNhaCungCap(oEntity);
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
                return KhoDAO.SaveThongTinLoHang(oEntity);
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
                return KhoDAO.SaveThongTinQuyetDinhThau(oEntity);
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

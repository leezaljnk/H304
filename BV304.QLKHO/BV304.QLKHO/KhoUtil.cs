using BV.AppCommon;
using BV.DataConnector;
using BV.DataModel;
using BV.DataModel.KhoChung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BV.QLKHO
{
    public class KhoUtil
    {
        public static List<T> GetDanhMuc<T>(bool bRefresh = false, int take = 0) where T : class
        {
            try
            {
                var coll = DanhMucBVCached.GetDanhMuc<T>();
                if (bRefresh || coll == null)
                {
                    coll = KhoConnector.GetDanhMuc<T>();
                    DanhMucBVCached.AddDanhMuc<T>(coll);
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

                var coll = DanhMucBVCached.GetDanhMuc<T>();
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

                var coll = DanhMucBVCached.GetDanhMuc<T>();
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
                var coll = DanhMucBVCached.GetDanhMuc<T>();
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

        public static DinhGiaHangHoa GetGiaThuoc(Guid thuocID)
        {
            try
            {
                return KhoConnector.GetGiaThuoc(thuocID);
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
                return KhoConnector.GetChuyenDoiDonViThuoc(thuocID);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        internal static void LuuThongTinHangHoa(HangHoa oThuoc, DinhGiaHangHoa oGiaThuoc, List<ChuyenDoiDonViHangHoa> lstDonVi)
        {
            try
            {
                KhoConnector.SaveThuoc304(oThuoc, oGiaThuoc, lstDonVi);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        internal static NhaCungCap SaveNhaCungCap(NhaCungCap oEntity)
        {
            try
            {
                return KhoConnector.SaveNhaCungCap(oEntity);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        internal static LoHangHoa SaveThongTinLoHang(LoHangHoa oEntity)
        {
            try
            {
                return KhoConnector.SaveThongTinLoHang(oEntity);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        internal static QuyetDinhThau SaveThongTinQuyetDinhThau(QuyetDinhThau oEntity)
        {
            try
            {
                return KhoConnector.SaveThongTinQuyetDinhThau(oEntity);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        internal static T SaveEntity<T>(T entity)
        {
            return entity;
        }
    }
}

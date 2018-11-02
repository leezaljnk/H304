using BV.AppCommon;
using BV.DataConnector;
using BV.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV.QLKHO
{
    public class KhoUtil
    {
        public static List<T> GetDanhMuc<T>(int take = 0, bool bRefresh = false) where T : class
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

        public static GiaThuoc GetGiaThuoc(Guid thuocID)
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

        public static List<ChuyenDoiDonViThuoc> GetChuyenDoiDonViThuoc(Guid thuocID)
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

        internal static void SaveThuoc304(Thuoc304 oThuoc, GiaThuoc oGiaThuoc, List<ChuyenDoiDonViThuoc> lstDonVi)
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
    }
}

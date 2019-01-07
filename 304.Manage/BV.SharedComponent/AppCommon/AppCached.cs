using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BV.AppCommon
{
    public static class AppCached
    {
        private static Dictionary<string, IList> AllDanhMuc = new Dictionary<string, IList>();

        public static List<T> GetDanhMuc<T>() where T : class
        {
            var key = typeof(T).FullName;
            if (AllDanhMuc.ContainsKey(key))
            {
                return AllDanhMuc[key] as List<T>;
            }

            return null;
        }

        public static void AddDanhMuc<T>(List<T> collection) where T : class
        {
            var key = typeof(T).FullName;
            if (AllDanhMuc.ContainsKey(key))
            {
                AllDanhMuc[key] = collection;
            }
            else
            {
                AllDanhMuc.Add(key, collection);
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

                var idx = coll.FindIndex(t => pInfo.GetValue(t).ToString() == pInfo.GetValue(entity).ToString());
                if (idx > 0)
                {
                    coll[idx] = entity;
                }
                else
                {
                    coll.Add(entity);
                }

                //var count = coll.RemoveAll(t => pInfo.GetValue(t).ToString() == pInfo.GetValue(entity).ToString());
                //coll.Add(entity);
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
    }
}

using BV.DataModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV.AppCommon
{
    public static class DanhMucBVCached
    {
        private static Dictionary<string, IList> AllDanhMuc = new Dictionary<string, IList>();

        public static List<T> GetDanhMuc<T>() where T:class
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
    }
}

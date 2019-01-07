using Library.Common;
using Library.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Winforms
{
    public static class Resources
    {
        private static IResourceProvider _resourceProvider = ServiceLocator.Retrieve<IResourceProvider>();
        public static string GetString(string key)
        {
            return _resourceProvider.GetString(key);
        }

        public static string GetString(string key, string defValue)
        {
            return _resourceProvider.GetString(key, defValue);
        }
    }
}

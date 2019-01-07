using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Winforms
{
    public static partial class PublicVariables
    {
        public static Control MainApplication { get; set; }
        public static string Ma_CSKB { get; set; }
        //public static int SiteSelectedId { get; set; }
        public static string Ten_CSKB { get; set; }
        public static Guid UserId { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string FullUserName { get; set; }
        public static bool Modify { get; set; }
        public static bool Only { get; set; }
        public static bool View { get; set; }
        public static bool Admin { get; set; }        
        public static bool IsBo { get; set; }
        public static bool IsTYTX { get; set; }
        public static string MaTinhThanhPho { get; set; }
        public static string MaHuyenQuan { get; set; }
        public static string INT_PATTERN = "0123456789\b";
        public static string DECIMAL_PATTERN = "0123456789,\b";
        public static int Style { get; set; }
        public static bool RefreshData;
        public static string Notification = "Thông báo";
    }
}

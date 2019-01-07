using BV.DataModel;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BV.SharedComponent
{
    public static class ExtensionMethod
    {
        public static void HandleException(this Form oForm, Exception ex)
        {
            MessageBox.Show(oForm, "Có lỗi xảy ra, vui lòng thử lại hoặc liên hệ với người quản trị hệ thống." + Environment.NewLine + "Lỗi: " + ex.Message, "Quản lý thuốc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void UltraCommbo_InitializeLayout(this UltraCombo cbo, object sender, InitializeLayoutEventArgs e)
        {
            if (e.Layout.Bands.Count > 0)
            {
                e.Layout.AutoFitStyle = AutoFitStyle.ExtendLastColumn;
                e.Layout.Bands[0].Override.HeaderAppearance.BackColor = Color.DimGray;
            }
        }

        public static string ToTitleCase(this string str)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(str.ToLower());
        }

        public static List<DiaDanh> GetTinh(this List<DiaDanh> list)
        {
            return list.Where(o => string.IsNullOrWhiteSpace(o.MaHuyen)).OrderBy(d => d.MaDiaDanh.Trim()).ToList();
        }

        public static List<DiaDanh> GetHuyen(this List<DiaDanh> list, string maTinh)
        {
            return list.Where(o => string.IsNullOrWhiteSpace(o.MaXa) && o.MaTinh == maTinh).OrderBy(d => d.TenNganGon.Trim()).ToList();
        }

        public static List<DiaDanh> GetXa(this List<DiaDanh> list, string maTinh)
        {
            return list.Where(o => !string.IsNullOrWhiteSpace(o.MaXa) && o.MaTinh == maTinh).OrderBy(d => d.TenNganGon.Trim()).ToList();
        }

        public static List<DiaDanh> GetXa(this List<DiaDanh> list, string maTinh, string maHuyen)
        {
            return list.Where(o => !string.IsNullOrWhiteSpace(o.MaXa) && o.MaTinh == maTinh && o.MaHuyen == maHuyen).OrderBy(d => d.TenNganGon.Trim()).ToList();
        }
    }
}

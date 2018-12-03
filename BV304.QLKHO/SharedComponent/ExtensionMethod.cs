using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}

using System;
using System.Windows.Forms;

namespace BV.QLKHO
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //System.IO.Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("BV.QLKHO.Styling.Theme 01.isl");
            //Infragistics.Win.AppStyling.StyleManager.Load(stream);

            Application.Run(new KhoForm());
        }
    }
}
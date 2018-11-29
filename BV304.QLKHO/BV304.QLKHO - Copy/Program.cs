using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BV.QLKHO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //System.IO.Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("BV.QLKHO.Styling.Theme 01.isl");
            //Infragistics.Win.AppStyling.StyleManager.Load(stream);

            Application.Run(new KhoForm());
        }
    }
}

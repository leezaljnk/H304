using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BV.Reporting
{
    public partial class FReportView : Form
    {
        public FReportView()
        {
            InitializeComponent();
        }

        public string ReportPath
        {
            get { return reportViewer1.LocalReport.ReportPath; }
            set
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = value;
            }
        }

        public void SetDataSource(object source, string sourceName)
        {
            var reportDataSource = new ReportDataSource
                { Name = sourceName, Value = source};
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
        }
        private void FReportView_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 150;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Có lỗi xẩy ra! Xin hãy kiểm tra lại dữ liệu {ex.Message}", @"THÔNG BÁO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

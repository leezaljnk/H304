using System;
using System.Windows.Forms;
using BV.AppCommon;
using BV.BUS;
using BV.DataModel;
using BV.Reporting;

namespace BV.QLKHO.PhieuNhapThuoc
{
    public partial class PhieuNhapForm : Form
    {
        public PhieuNhapKhoModel phieuNhap = new PhieuNhapKhoModel();

        public PhieuNhapForm()
        {
            InitializeComponent();
        }

        public void InitData(Guid phieuID)
        {
            phieuNhapThuocCtrl1.InitControl(phieuID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            phieuNhap = new PhieuNhapKhoModel();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                Cursor = Cursors.WaitCursor;
                DialogResult = DialogResult.OK;
                phieuNhap = phieuNhapThuocCtrl1.PhieuNhapData();
                //Save data
                BusApp.SavePhieuNhapKhoTuNhaCungCap(phieuNhap);
                PrintPhieuNhap();
                //Close();
                phieuNhapThuocCtrl1.dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        public void HandleException(Exception ex)
        {
            Cursor = Cursors.Default;
            MessageBox.Show(this, ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void PrintPhieuNhap()
        {
            //TongHopBenhAnSource source = GetTongHopBenhAn();
            //if (source == null) return;
            var report = new FReportView
            {
                WindowState = FormWindowState.Maximized,
                ReportPath = ReportConstance.PHIEU_NHAP_KHO_TEMPLATE
            };

            //Bind data source
            //IList<TongHopBenhAnSource> sources = new List<TongHopBenhAnSource>() { source };
            report.SetDataSource(phieuNhap, ReportConstance.PHIEU_NHAP_KHO_SOURCE);
            report.SetDataSource(phieuNhap.ChiTietPhieuNhaps, ReportConstance.PHIEU_NHAP_KHO_CHI_TIET_SOURCE);
            //report.SetDataSource(source.TongHopLamSang, ReportConstance.TongHopBenhAnLamSangSource);
            //report.SetDataSource(source.TongHopXetNghiem, ReportConstance.TongHopBenhAnXetNghiemSource);
            report.Show();
        }
    }
}
using System;
using System.Windows.Forms;
using BV.BUS;
using BV.DataModel;
using BV.Reporting;
using Common.Winforms.UserControls;

namespace BV.QLKHO.PhieuNhapThuoc
{
    public partial class PhieuNhapForm : FormBase
    {
        public PhieuNhapKho phieuNhap = new PhieuNhapKho();

        public PhieuNhapForm()
        {
            InitializeComponent();
        }

        public void InitData(Guid phieuId)
        {
            phieuNhapThuocCtrl1.InitControl(phieuId);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            phieuNhap = new PhieuNhapKho();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SavePhieuNhapNCC();
            DialogResult = DialogResult.OK;
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
            report.SetDataSource(phieuNhap.PhieuNhapChiTiet, ReportConstance.PHIEU_NHAP_KHO_CHI_TIET_SOURCE);
            //report.SetDataSource(source.TongHopLamSang, ReportConstance.TongHopBenhAnLamSangSource);
            //report.SetDataSource(source.TongHopXetNghiem, ReportConstance.TongHopBenhAnXetNghiemSource);
            report.Show();
        }

        private void btnSaveContinue_Click(object sender, EventArgs e)
        {
            //SavePhieuNhapNCC();
            phieuNhapThuocCtrl1.ClearForm();
        }

        private void SavePhieuNhapNCC()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                
                phieuNhap = phieuNhapThuocCtrl1.PhieuNhapData();
                //Save data
                BusKho.SavePhieuNhapKhoTuNhaCungCap(phieuNhap);
                //PrintPhieuNhap();
               
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

    }
}
using System;
using System.Linq;
using System.Windows.Forms;
using BV.BUS;
using BV.DataModel;
using BV.SharedComponent;
using Common.Winforms.UserControls;
using Infragistics.Win.UltraWinGrid;

namespace BV.QLKHO.KhoChan.XuatThuoc
{
    public partial class XuatThuocBNCtrl : UserControlBase
    {
        private int _loaiKho;

        public XuatThuocBNCtrl()
        {
            InitializeComponent();
        }

        public void InitControl(LoaiKhoType loaiKho)
        {
            _loaiKho = (int) loaiKho;
            var lstKho = BusApp.GetDanhMuc<Kho>().Where(k => k.LoaiKhoId == _loaiKho).ToList();
            cboKho.DataSource = lstKho;
            cboKho.ValueMember = "MaKho";
            cboKho.DisplayMember = "TenKho";
            cboKho.DisplayLayout.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand);
        }


        private void cboKho_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            cboKho.UltraCommbo_InitializeLayout(sender, e);
            if (e.Layout.Bands.Count > 0)
                foreach (var clm in e.Layout.Bands[0].Columns)
                    if (clm.Key == "MaKho")
                        clm.Header.Caption = @"Mã";
                    else if (clm.Key == "TenKho")
                        clm.Header.Caption = @"Tên";
                    else
                        clm.Hidden = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
        }
    }
}
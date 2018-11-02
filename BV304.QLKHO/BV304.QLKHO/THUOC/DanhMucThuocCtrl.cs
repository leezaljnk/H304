using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BV.DataConnector;
using BV.DataModel;

namespace BV.QLKHO.THUOC
{
    public partial class DanhMucThuocCtrl : UserControl
    {
        private List<Thuoc_BoYTe> _DanhMucThuocBYT;
        private List<Thuoc304> _DanhMucThuoc304;
        private List<HoTriLieu> _HoTriLieu;

        public DanhMucThuocCtrl()
        {
            InitializeComponent();
        }

        internal void InitControlUI()
        {
            _DanhMucThuoc304 = KhoUtil.GetDanhMuc<Thuoc304>();
            _HoTriLieu = KhoUtil.GetDanhMuc<HoTriLieu>();
            foreach (var t in _DanhMucThuoc304)
            {
                var item = new object[] { t.ID, t.TEN_THUOC, t.HAM_LUONG, t.HOAT_CHAT, t.HO_TRI_LIEU, t.DUONG_DUNG, t.DonViID };
                int i = dataGridView1.Rows.Add(item);
                dataGridView1.Rows[i].Tag = t;
            }
        }

        private void toolbarGeneral1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (e.ClickedItem.Name == "add")
                {
                    ThongTinThuocForm oForm = new ThongTinThuocForm();
                    oForm.InitThongTin(null);
                    if (oForm.ShowDialog(this) == DialogResult.OK)
                    {
                        var t = oForm.Entity;
                        var item = new object[] { t.ID, t.TEN_THUOC, t.HAM_LUONG, t.HOAT_CHAT, t.HO_TRI_LIEU, t.DUONG_DUNG, t.DonViID };
                        int i = dataGridView1.Rows.Add(item);
                        dataGridView1.Rows[i].Tag = t;
                    }
                }
                else if (e.ClickedItem.Name == "edit")
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var row = dataGridView1.SelectedRows[0];
                        Thuoc304 oThuoc = row.Tag as Thuoc304;
                        ThongTinThuocForm oForm = new ThongTinThuocForm();
                        oForm.InitThongTin(oThuoc);
                        if (oForm.ShowDialog(this) == DialogResult.OK)
                        {
                            var t = oForm.Entity;
                            row.Cells[0].Value = t.ID;
                            row.Cells[1].Value = t.TEN_THUOC;
                            row.Cells[2].Value = t.HAM_LUONG;
                            row.Cells[3].Value = t.HOAT_CHAT;
                            row.Cells[4].Value = t.HO_TRI_LIEU;
                            row.Cells[5].Value = t.DUONG_DUNG;
                            row.Cells[6].Value = t.DonViID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void ultraCombo1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            if(e.Layout.Bands.Count > 0)
            {
                foreach (var clm in e.Layout.Bands[0].Columns)
                {
                    if (clm.Header.Caption == "TEN_THUOC")
                    {
                        clm.Header.Caption = "Tên Thuốc";
                        //clm.Width = ultraCombo1.Width;
                    }
                    //else if (clm.Header.Caption == "HAM_LUONG")
                    //{
                    //    clm.Header.Caption = "Hàm Lượng";
                    //}
                    //else if (clm.Header.Caption == "DONG_GOI")
                    //{
                    //    clm.Header.Caption = "Đóng Gói";
                    //}
                    //else
                    //{
                    //    clm.Hidden = true;
                    //}
                } 
            }
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show(this, "Có lỗi xảy ra, vui lòng thử lại hoặc liên hệ với người quản trị hệ thống." + Environment.NewLine + "Lỗi: " + ex.Message, "Quản lý thuốc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

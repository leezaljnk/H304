using BV.DataModel;
using BV.DataModel.KhoChung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV.QLKHO.THUOC
{
    public partial class ThongTinThuocFormBYT : Form
    {
        public THUOC_6061 Entity;

        bool bComboValueChanged = false;
        bool bComboDropDownVisible = false;

        public ThongTinThuocFormBYT()
        {
            InitializeComponent();
        }

        public void InitData()
        {
            var _DanhMucThuocBYT = KhoUtil.GetDanhMuc<THUOC_6061>();
            ultraCombo1.DataSource = _DanhMucThuocBYT;
            ultraCombo1.DisplayMember = "TEN_THUOC";
            ultraCombo1.ValueMember = "THUOC_ID";
        }

        private void ultraCombo1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            if (e.Layout.Bands.Count > 0)
            {
                foreach (var clm in e.Layout.Bands[0].Columns)
                {
                    if (clm.Key == "SO_DANG_KY")
                    {
                        clm.Header.Caption = "Số Đăng Ký";
                    }
                    else if (clm.Key == "TEN_THUOC")
                    {
                        clm.Width = 200;
                        clm.Header.Caption = "Tên Thuốc";
                    }
                    else if (clm.Key == "HAM_LUONG")
                    {
                        clm.Header.Caption = "Hàm Lượng";
                    }
                    else if (clm.Key == "HOAT_CHAT")
                    {
                        clm.Header.Caption = "Hoạt Chất";
                    }
                    else if (clm.Key == "DONG_GOI")
                    {
                        clm.Header.Caption = "Đóng Gói";
                    }
                    else
                    {
                        clm.Hidden = true;
                    }
                }
            }
        }

        


        private void ultraCombo1_ValueChanged(object sender, EventArgs e)
        {
            bComboValueChanged = true;
            if (ultraCombo1.SelectedRow != null && !bComboDropDownVisible)
            {
                ShowThuocInfo();                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ultraCombo1.SelectedRow == null)
            {
                errorProvider1.SetError(ultraCombo1, "chưa chọn thuốc");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }



        private void ultraCombo1_AfterCloseUp(object sender, EventArgs e)
        {
            bComboDropDownVisible = false;
            if (bComboValueChanged && ultraCombo1.SelectedRow != null)
            {
                ShowThuocInfo();
                bComboValueChanged = true;
            }
        }

        private void ultraCombo1_AfterDropDown(object sender, EventArgs e)
        {
            bComboDropDownVisible = true;
        }

        private void ShowThuocInfo()
        {
            int id = (int)ultraCombo1.Value;
            var oThuoc = KhoUtil.GetDanhMuc<THUOC_6061>().FirstOrDefault(t => t.THUOC_ID == id);

            txtSoDangKy.Text = oThuoc.SO_DANG_KY;
            txtHoatChat.Text = oThuoc.HOAT_CHAT;
            txtHamLuong.Text = oThuoc.HAM_LUONG;

            var lstDuongDung = KhoUtil.GetDanhMuc<ThuocDuongDung>();
            var item = lstDuongDung.FirstOrDefault(t => t.ID == oThuoc.MA_DUONG_DUNG);
            txtDuongDung.Text = item?.DienGiai ?? "";
            txtDongGoi.Text = oThuoc.DONG_GOI;

            Entity = oThuoc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ultraCombo1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(ultraCombo1, "");

            if (ultraCombo1.Text.Trim().Length < 3)
            {
                ultraCombo1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            }
            else if (ultraCombo1.Text.Trim().Length == 3)
            {
                ultraCombo1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            }
        }
    }
}

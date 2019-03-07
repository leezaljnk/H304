using System;
using System.Drawing;
using System.Windows.Forms;
using BV.DataModel;
using BV.QLKHO.KhoChan.NhapThuoc;
using BV.QLKHO.KhoChan.ThuHoiThuoc;
using BV.QLKHO.KhoChan.XuatThuoc;
using BV.QLKHO.THUOC;
using Common.Winforms.UserControls;

namespace BV.QLKHO
{
    public partial class KhoForm : FormBase
    {
        public KhoForm()
        {
            InitializeComponent();
        }

        private void thuocVtytToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var view = new DanhMucThuocCtrl();
                view.CloseView += View_CloseView;
                view.InitControlUI();

                AddUserControl("Danh Mục Thuốc", view);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void View_CloseView(object sender, EventArgs e)
        {
            if (!(sender is UserControl ctrl)) return;
            var removeTabPage = CheckTabPage(ctrl.Name);
            if (removeTabPage == null) return;
            tabMain.TabPages.Remove(removeTabPage);
            removeTabPage.Dispose();
        }

        private TabPage CheckTabPage(string tabName)
        {
            foreach (TabPage item in tabMain.TabPages)
                if (item.Name == tabName)
                    return item;
            return null;
        }

        private void AddUserControl(string tabName, UserControl ctrl)
        {
            var newTabPage = CheckTabPage(tabName);
            if (newTabPage == null)
            {
                newTabPage = new TabPage();

                tabMain.SuspendLayout();
                newTabPage.SuspendLayout();


                newTabPage.Controls.Add(ctrl);
                newTabPage.Location = new Point(4, 22);
                newTabPage.Name = ctrl.Name;
                newTabPage.Padding = new Padding(3);
                newTabPage.Size = new Size(515, 309);
                newTabPage.TabIndex = 0;
                newTabPage.Text = tabName;
                newTabPage.UseVisualStyleBackColor = true;

                ctrl.Dock = DockStyle.Fill;
                ctrl.Location = new Point(3, 3);
                ctrl.Name = ctrl.Name;
                ctrl.Size = new Size(688, 367);
                ctrl.TabIndex = 0;

                tabMain.Controls.Add(newTabPage);

                newTabPage.ResumeLayout();
                tabMain.ResumeLayout(true);
            }

            tabMain.SelectedTab = newTabPage;
        }


        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oForm = new ThongTinThuocFormTest();
            oForm.InitData();
            oForm.ShowDialog(this);
        }

 
        private void mnuDanhMucNCC_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var view = new DanhMucNhaCungCapCtrl();
                view.CloseView += View_CloseView;
                view.InitControlUI();

                AddUserControl("Danh Mục Nhà Cung Cấp", view);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void mnuKhoChan_NhapTuNCC_Click(object sender, EventArgs e)
        {
            var oForm = new PhieuNhapForm();
            oForm.InitData(Guid.Empty);
            oForm.ShowDialog(this);
        }

        private void mnuKhoChan_ThuHoiTuTruc_Click(object sender, EventArgs e)
        {
            var oForm = new ThuHoiThuocForm();
            oForm.ShowDialog(this);
        }

        private void mnuKhoChan_XuatThuocTuThien_Click(object sender, EventArgs e)
        {

        }

        private void mnuKhoChan_XuatBNNoiTru_Click(object sender, EventArgs e)
        {
            var oForm = new XuatThuocBenhNhanForm();
            oForm.InitData(LoaiKhoType.KhoChan);
            oForm.ShowDialog(this);
        }

        private void mnuKhoChan_XuatBNNgoaiTru_Click(object sender, EventArgs e)
        {
            var oForm = new XuatThuocBenhNhanForm();
            oForm.InitData(LoaiKhoType.KhoLe);
            oForm.ShowDialog(this);
        }
    }
}
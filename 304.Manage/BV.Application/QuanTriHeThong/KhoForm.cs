using System;
using System.Drawing;
using System.Windows.Forms;
using BV.QLKHO.THUOC;
using Common.Winforms.UserControls;

namespace BV.QuanTriHeThong
{
    public partial class KhoForm : FormBase
    {
        public KhoForm()
        {
            InitializeComponent();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                //var view = new DanhMucThuocCtrl();
                //view.CloseView += View_CloseView;
                //view.InitControlUI();

                //AddUserControl("Danh Mục Thuốc", view);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void View_CloseView(object sender, EventArgs e)
        {
            var ctrl = sender as UserControl;
            var removeTabPage = CheckTabPage(ctrl.Name);
            if (removeTabPage != null)
            {
                tabMain.TabPages.Remove(removeTabPage);
                removeTabPage.Dispose();
                removeTabPage = null;
            }
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

        private void Ctrl_CloseView(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            //var p1 = this.PointToScreen(textBox1.Location);
            //var p = textBox1.PointToClient(Point.Empty);
            //oFom.PointToClient(textBox1.Location);
            //oFom.Location = new Point(p1.X + 30, p1.Y + 30);
            //oFom.Update();
            //oFom.Show();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.CanFocus = true;
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ThongTinThuocFormTest oForm = new ThongTinThuocFormTest();
            //oForm.InitData();
            //oForm.ShowDialog(this);
        }

        private void nhậpTừNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dmKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var view = new DanhMucKhoaCtrl();
                view.CloseView += View_CloseView;
                view.InitControlUI();

                AddUserControl("Danh Mục Khoa", view);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void dmPKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var view = new DanhMucPhongKhamCtrl();
                view.CloseView += View_CloseView;
                view.InitControlUI();

                AddUserControl("Danh Mục Phòng Khám", view);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
    }
}
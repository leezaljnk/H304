using BV.QLKHO.PhieuNhapThuoc;
using BV.QLKHO.THUOC;
using BV.SharedComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV.QLKHO
{
    public partial class KhoForm : Form
    {
        public KhoForm()
        {
            InitializeComponent();
        }

        private void thuocVtytToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                var view = new DanhMucThuocCtrl();
                view.CloseView += View_CloseView;
                view.InitControlUI();

                AddUserControl("Danh Mục Thuốc", view);
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void View_CloseView(object sender, EventArgs e)
        {
            UserControl ctrl = sender as UserControl;
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
            {
                if (item.Name == tabName) return item;
            }
            return null;
        }

        private void AddUserControl(string tabName, UserControl ctrl)
        {
            TabPage newTabPage = CheckTabPage(tabName);
            if (newTabPage == null)
            {
                newTabPage = new System.Windows.Forms.TabPage();

                tabMain.SuspendLayout();
                newTabPage.SuspendLayout();

                
                newTabPage.Controls.Add(ctrl);
                newTabPage.Location = new System.Drawing.Point(4, 22);
                newTabPage.Name = ctrl.Name;
                newTabPage.Padding = new System.Windows.Forms.Padding(3);
                newTabPage.Size = new System.Drawing.Size(515, 309);
                newTabPage.TabIndex = 0;
                newTabPage.Text = tabName;
                newTabPage.UseVisualStyleBackColor = true;

                ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
                ctrl.Location = new System.Drawing.Point(3, 3);
                ctrl.Name = ctrl.Name;
                ctrl.Size = new System.Drawing.Size(688, 367);
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

        public void HandleException(Exception ex)
        {
            this.Cursor = Cursors.Default;
            //TODO: ghi log client vào đây
            //CommonFunction.WriteLog(ex.Message);
            MessageBox.Show(this, ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ThongTinThuocFormTest oForm = new ThongTinThuocFormTest();
            oForm.InitData();
            oForm.ShowDialog(this);
        }

        private void nhậpTừNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuNhapForm oForm = new PhieuNhapThuoc.PhieuNhapForm();
            oForm.InitData(Guid.Empty);
            oForm.ShowDialog(this); 
        }

        private void mnuDanhMucNCC_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                var view = new DanhMucNhaCungCapCtrl();
                view.CloseView += View_CloseView;
                view.InitControlUI();

                AddUserControl("Danh Mục Nhà Cung Cấp", view);
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void danhMucKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

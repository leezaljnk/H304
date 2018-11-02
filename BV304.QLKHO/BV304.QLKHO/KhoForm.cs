using BV.QLKHO.THUOC;
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

        private void danhMụcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                var view = new DanhMucThuocCtrl();
                view.InitControlUI();

                AddUserControl("Danh Mục Thuốc", view);
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                HandleException(ex);
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

                tabMain.Controls.Add(newTabPage);
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

                newTabPage.ResumeLayout();
                tabMain.ResumeLayout(false);

            }
            tabMain.SelectedTab = newTabPage;
        }

        public void HandleException(Exception ex)
        {
            this.Cursor = Cursors.Default;
            //TODO: ghi log client vào đây
            //CommonFunction.WriteLog(ex.Message);
            MessageBox.Show(this, ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        Form2 oFom = new Form2();

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
            oFom.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.CanFocus = true;
        }
    }
}

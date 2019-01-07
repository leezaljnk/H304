/*****************************************************
 *****************************************************
 *****************Tooltip with image******************
 *******************Written By NTD********************
 *********************06-08-2013**********************
 *****************************************************
 ****************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Common.Winforms
{
    public partial class ToolTipCtl : Form
    {
        public ToolTipCtl()
        {
            InitializeComponent();
        }

        private int time_off { get; set; }

        public int line_height { get; set; }

        private int time = 0;

        private int time_out = 0;

        private int time_of = 0;

        private Control ownerp { get; set; }

        private Control _parent { get; set; }

        /// <summary>
        /// Shows the form with the specified owner to the user.
        /// </summary>
        /// <param name="txt">String input can contain tag img and n</param>
        /// <param name="owner">Any object that implements Control and represents the top-level window that will own this form.</param>
        /// <param name="img">List of image type of Image. You can create collection ListImage and add it in here</param>
        /// <param name="t_of">Time to display tooltip. After this time, tooltip will be closed.</param>
        /// <returns>void</returns>
        public void Show(String txt, Control owner, List<Image> img, int t_of)
        {
            if (ownerp != owner)
            {
                if (ownerp != owner) checkBox1.Checked = false;
                ownerp = owner;
                this.Opacity = 0;
                time_off = t_of;
                AutoSize = false;
                Height = 5;
                Width = 5;
                owner.Click += new EventHandler(owner_Click);
                owner.MouseLeave += new EventHandler(owner_MouseLeave);
                AddImgString(txt, img);
                AutoSize = true;
                time_out = 0;
                timer2.Stop();
                this.time = 0;
                this.Left = Cursor.Position.X + 2;
                this.Top = Cursor.Position.Y + 2;
                if (Left + Width > Screen.PrimaryScreen.Bounds.Width)
                    Left = Screen.PrimaryScreen.Bounds.Width - Width;
                if (Top + Height > Screen.PrimaryScreen.Bounds.Height)
                    Top = Screen.PrimaryScreen.Bounds.Height - Height;
                timer1.Start();
                this.Show();
                ownerp.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_of = time_off + 18;
            if (time >= time_off + 10)
            {
                if (time_of <= time && this.Opacity >= 0.1D)
                    this.Opacity -= 0.1D;
                if (this.Opacity <= 0)
                {
                    timer1.Stop();
                    time = 0;
                    this.Hide();
                    ownerp = null;
                }
                if (time_of <= time) time_of += 2;
            }
            else
            {
                if (time < 40 && this.Opacity <= 0.9D)
                    this.Opacity += 0.1D;
            }
            time++;
        }

        void owner_MouseLeave(object sender, EventArgs e)
        {
                time_out = 0;
                timer2.Start();
        }

        void owner_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                this.Opacity = 0;
                timer1.Stop();
                time = 0;
                this.Hide();
                ownerp = null;

            }
        }

        private void AddImgString(string txt, List<Image> img)
        {
            pn.Controls.Clear();
            pn.BackColor = Color.Transparent;
            if (txt.IndexOf("<img>") == -1 && txt.IndexOf("\n") == -1)
            {
                Label lbl = new Label();
                lbl.Text = txt;
                lbl.Font = this.Font;
                lbl.BackColor = Color.Transparent;
                lbl.AutoSize = true;
                pn.Controls.Add(lbl);
                lbl.Left = 5;
                lbl.Top = 5;
            }
            else
            {
                int i = 0;
                string test_string = txt;
                int fpos = 0;
                int imgpos = 0;
                int brpos = 0;
                bool br = false;
                Control lastCtl = null;
                List<Control> lct = new List<Control>();
                bool end_while = false;
                int max_height_line = 0;
                do
                {
                    imgpos = test_string.IndexOf("<img>");
                    brpos = test_string.IndexOf("\n");
                    fpos = brpos < 0 ? imgpos : imgpos > brpos ? brpos : imgpos;
                    if (brpos >= 0 && fpos < 0) fpos = brpos;
                    if ((imgpos >= 0 && imgpos < brpos) || brpos < 0) //img
                    {
                        if (fpos > 0)   //add text if exist
                        {
                            Label lbl = new Label();
                            lbl.Text = test_string.Substring(0, fpos);
                            lbl.Font = this.Font;
                            lbl.BackColor = Color.Transparent;
                            lbl.AutoSize = true;
                            lbl.TextAlign = ContentAlignment.MiddleCenter;
                            pn.Controls.Add(lbl);
                            lct.Add(lbl);
                            if (lastCtl != null)
                            {
                                if (!br)
                                {
                                    lbl.Left = lastCtl.Left + lastCtl.Width + 3;
                                    lbl.Top = lastCtl.Top;
                                }
                                else
                                {
                                    lbl.Left = 5;
                                    lbl.Top = lastCtl.Top + lastCtl.Height + 1;
                                    br = false;
                                }
                                if (line_height == 0 && max_height_line < lbl.Height) max_height_line = lbl.Height;
                            }
                            else
                            {
                                lbl.Left = lbl.Top = 5;
                            }
                            lastCtl = lbl;
                        }
                        if (imgpos < 0 && brpos < 0)
                        {
                            if (test_string.Length > 0)
                            {
                                Label lbl = new Label();
                                lbl.Text = test_string.Substring(0);
                                lbl.Font = this.Font;
                                lbl.BackColor = Color.Transparent;
                                lbl.AutoSize = true;
                                lbl.TextAlign = ContentAlignment.MiddleCenter;
                                pn.Controls.Add(lbl);
                                lct.Add(lbl);
                                if (lastCtl != null)
                                {
                                    if (!br)
                                    {
                                        lbl.Left = lastCtl.Left + lastCtl.Width + 3;
                                        lbl.Top = lastCtl.Top;
                                    }
                                    else
                                    {
                                        lbl.Left = 5;
                                        lbl.Top = lastCtl.Top + lastCtl.Height + 1;
                                        br = false;
                                    }
                                    if (line_height == 0 && max_height_line < lbl.Height) max_height_line = lbl.Height;
                                }
                                else
                                {
                                    lbl.Left = lbl.Top = 5;
                                }
                                foreach (Control ctl in lct)
                                {
                                    if (ctl.GetType() == typeof(Label))
                                    {
                                        if (line_height == 0)
                                            ctl.MinimumSize = new Size(0, max_height_line);
                                        else
                                            ctl.MinimumSize = new Size(0, line_height);
                                    }
                                    else //pic
                                    {
                                        decimal rate = (decimal)ctl.Height / (decimal)ctl.Width;
                                        if (line_height == 0)
                                        {
                                            ctl.Height = max_height_line;
                                            ctl.Width = (int)Math.Round((decimal)max_height_line / rate);
                                        }
                                        else
                                        {
                                            ctl.Height = line_height;
                                            ctl.Width = (int)Math.Round((decimal)line_height / rate);
                                        }
                                    }
                                }
                            }
                            end_while = true; //trg hop k tim thay img va br nua ket thuc vong lap
                        }
                        if (fpos >= 0)
                        {
                            if (img.Count >= i) //bo qua the img thua
                            {
                                PictureBox pic = new PictureBox();
                                pic.Image = img[i];
                                pic.BackColor = Color.Transparent;
                                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                                if (line_height == 0)
                                {
                                    pic.Height = img[i].Height;
                                    pic.Width = img[i].Width;
                                }
                                else
                                {
                                    decimal rate = (decimal)img[i].Height / (decimal)img[i].Width;
                                    pic.Height = line_height;
                                    pic.Width = (int)Math.Round((decimal)line_height / rate);
                                }
                                i++;
                                pn.Controls.Add(pic);
                                lct.Add(pic);
                                if (lastCtl != null)
                                {
                                    if (!br)
                                    {
                                        pic.Left = lastCtl.Left + lastCtl.Width + 3;
                                        pic.Top = lastCtl.Top;
                                    }
                                    else
                                    {
                                        pic.Left = 5;
                                        pic.Top = lastCtl.Top + lastCtl.Height + 1;
                                        br = false;
                                    }
                                }
                                else
                                {
                                    pic.Left = pic.Top = 5;
                                }
                                if (max_height_line < pic.Height) max_height_line = pic.Height;
                                lastCtl = pic;
                                test_string = test_string.Substring(fpos + 5);
                            }
                        }
                    }
                    else //br
                    {
                        if (fpos == 0)
                        {
                            Label lbl = new Label();
                            lbl.Text = " ";
                            pn.Controls.Add(lbl);
                            lct.Add(lbl);
                            if (lastCtl != null)
                            {
                                if (!br)
                                {
                                    lbl.Left = lastCtl.Left + lastCtl.Width + 3;
                                    lbl.Top = lastCtl.Top;
                                }
                                else
                                {
                                    lbl.Left = 5;
                                    lbl.Top = lastCtl.Top + lastCtl.Height + 1;
                                    br = false;
                                }
                            }
                            else
                            {
                                lbl.Left = lbl.Top = 5;
                            }
                            foreach (Control ctl in lct)
                            {
                                if (ctl.GetType() == typeof(Label))
                                {
                                    if (line_height == 0)
                                        ctl.MinimumSize = new Size(0, max_height_line);
                                    else
                                        ctl.MinimumSize = new Size(0, line_height);
                                }
                                else //pic
                                {
                                    decimal rate = (decimal)ctl.Height / (decimal)ctl.Width;
                                    if (line_height == 0)
                                    {
                                        ctl.Height = max_height_line;
                                        ctl.Width = (int)Math.Round((decimal)max_height_line / rate);
                                    }
                                    else
                                    {
                                        ctl.Height = line_height;
                                        ctl.Width = (int)Math.Round((decimal)line_height / rate);
                                    }
                                }
                            }
                            lct = new List<Control>();
                            max_height_line = 0;
                            lastCtl = lbl;
                            test_string = test_string.Substring(fpos + 2);
                            br = true;
                        }
                        if (fpos > 0)   //add text if exist
                        {
                            Label lbl = new Label();
                            lbl.Text = test_string.Substring(0, fpos);
                            lbl.Font = this.Font;
                            lbl.BackColor = Color.Transparent;
                            lbl.AutoSize = true;
                            lbl.TextAlign = ContentAlignment.MiddleCenter;
                            pn.Controls.Add(lbl);
                            lct.Add(lbl);
                            if (lastCtl != null)
                            {
                                if (!br)
                                {
                                    lbl.Left = lastCtl.Left + lastCtl.Width + 3;
                                    lbl.Top = lastCtl.Top;
                                }
                                else
                                {
                                    lbl.Left = 5;
                                    lbl.Top = lastCtl.Top + lastCtl.Height + 1;
                                    br = false;
                                }
                            }
                            else
                            {
                                lbl.Left = lbl.Top = 5;
                            }
                            foreach (Control ctl in lct)
                            {
                                if (ctl.GetType() == typeof(Label))
                                {
                                    if (line_height == 0)
                                        ctl.MinimumSize = new Size(0, max_height_line);
                                    else
                                        ctl.MinimumSize = new Size(0, line_height);
                                }
                                else //pic
                                {
                                    decimal rate = (decimal)ctl.Height / (decimal)ctl.Width;
                                    if (line_height == 0)
                                    {
                                        ctl.Height = max_height_line;
                                        ctl.Width = (int)Math.Round((decimal)max_height_line / rate);
                                    }
                                    else
                                    {
                                        ctl.Height = line_height;
                                        ctl.Width = (int)Math.Round((decimal)line_height / rate);
                                    }
                                }
                            }
                            lct = new List<Control>();
                            max_height_line = 0;
                            lastCtl = lbl;
                            test_string = test_string.Substring(fpos + 2);
                            br = true;
                        }
                    }
                }
                while (!end_while);
            }
        }

        private void ToolTipCtl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.PowderBlue, ButtonBorderStyle.Solid);
        }

        private void pn_MouseHover(object sender, EventArgs e)
        {
            time_out = 0;
            timer2.Stop();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            time_out = 0;
            timer2.Stop();
        }

        private void ToolTipCtl_MouseHover(object sender, EventArgs e)
        {
            time_out = 0;
            timer2.Stop();
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            time_out = 0;
            timer2.Stop();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Stop();
                time = 0;
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (time_out > 10)
            {
                this.checkBox1.Checked = false;
                this.Opacity = 0;
                timer2.Stop();
                timer1.Stop();
                time = 0;
                this.Hide();
                ownerp = null;

            }
            time_out++;
        }

        bool hold = false;
        Point pt = new Point();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                hold = true;
                pt = e.Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked && e.Button == System.Windows.Forms.MouseButtons.Left && hold)
            {
                this.Cursor = Cursors.Default;
                //this.Top += Cursor.Position.X - pt.X;
                //this.Left += Cursor.Position.Y - pt.Y;
                //pt.X = Cursor.Position.X;
                //pt.Y = Cursor.Position.Y;
                this.Location = new Point(e.X + Left - pt.X, e.Y + Top - pt.Y);
            }else if(checkBox1.Checked && !hold)
                this.Cursor = Cursors.SizeAll;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                hold = false;
            }
        }

    }
}

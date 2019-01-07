
using ComboboxReadOnly;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Winforms
{
    public static class InitControls
    {
        public static void SetTextInvoke(this Control ctr, string text)
        {
            if (ctr.InvokeRequired)
            {
                ctr.BeginInvoke(new MethodInvoker(
                    () =>
                    {
                        ctr.Text = text;
                    }));
            }
            else
            {
                ctr.Text = text;
            }
        }

        public static void ListItemInvoke(this ListView lsvProcess, ListViewItem item, string text, int colIndex)
        {
            if (lsvProcess.InvokeRequired)
            {
                lsvProcess.BeginInvoke(new MethodInvoker(
                    () =>
                    {
                        item.SubItems[colIndex].Text = text;
                    }));
            }
            else
            {
                item.SubItems[colIndex].Text = text;
            }
            //Application.DoEvents();
        }
        public static void ListItemInvoke(this ListView lsvProcess, ListViewItem item, string text, int colIndex, Color color)
        {
            if (lsvProcess.InvokeRequired)
            {
                lsvProcess.BeginInvoke(new MethodInvoker(
                    () =>
                    {
                        item.SubItems[colIndex].Text = text;
                        item.ForeColor = color;
                    }));
            }
            else
            {
                item.SubItems[colIndex].Text = text;
                item.ForeColor = color;
            }
            //Application.DoEvents();
        }
        public static void InitUserControl(this UserControl uct)
        {
            uct.AutoScaleMode = AutoScaleMode.None;
            uct.BackColor = SystemColors.Control;;
            uct.Font = new Font("Tahoma", 9.25F, FontStyle.Regular);
            uct.Padding = new Padding(3);

            throw new Exception("Doing Common.Winforms.InitControls InitUserControl");
            //foreach (Control control in uct.Controls)
            //{
            //    SetBackColorRecursive(control);
            //    if (control is UserControl)
            //    {
            //        foreach (Control ctr in control.Controls)
            //        {
            //            if (ctr is ToolStrip)
            //                SetControlTextForToolstrip((ToolStrip)ctr, "GeneralCommandToolbar");
            //            //control.Font = new Font("Times New Roman", control.Font.SizeInPoints * heightRatio * widthRatio);
            //        }
            //    }
            //    if (control is GroupBox || control is Panel)
            //    {
            //        control.BackColor = SystemColors.Control;;
            //    }
            //    SetBackColorRecursive(control);
            //}

        }

        public static void InitUserControl(this Form uct)
        {
            uct.AutoScaleMode = AutoScaleMode.None;
            uct.BackColor = SystemColors.Control;;
            uct.Font = new Font("Tahoma", 9.25F, FontStyle.Regular);
            uct.Padding = new Padding(3);
            foreach (Control control in uct.Controls)
            {
                SetBackColorRecursive(control);
                if (control is UserControl)
                {
                    foreach (Control ctr in control.Controls)
                    {
                        throw new Exception("Doing aaa");
                        //if (ctr is ToolStrip)
                        //    SetControlTextForToolstrip((ToolStrip)ctr, "GeneralCommandToolbar");
                    }
                }
                if (control is GroupBox || control is Panel)
                {
                    control.BackColor = SystemColors.Control;;
                }
                SetBackColorRecursive(control);
            }
        }

        public static void InitUserControl(this UserControl uct, Color BackColor)
        {
            uct.BackColor = BackColor;
            uct.Font = new Font("Tahoma", 9.25F, FontStyle.Regular);
        }

        public static void InitTabControl(this TabControl uct)
        {
            foreach (TabPage page in uct.TabPages)
            {
                page.BackColor = SystemColors.Control;;
                page.Font = new Font("Tahoma", 9.25F, FontStyle.Regular);
            }
        }
                public static void InitButton(Button btnName, string strText, String strTooltip)
        {
            ToolTip tl = new ToolTip();
            btnName.Text = strText;
            tl.SetToolTip(btnName, strTooltip);
        }
       
        public static void InitCombo(ComboBox cboName, string strTooltip, bool isList)
        {
            cboName.Font = new Font("Tahoma", 9.25F, FontStyle.Regular);
            cboName.DropDownStyle = isList ? ComboBoxStyle.DropDownList : ComboBoxStyle.DropDown;
            ToolTip tl = new ToolTip();
            tl.SetToolTip(cboName, strTooltip);
        }
        
        public static void InitMaskedText(MaskedTextBox mskName, string strTooltip, string strMask)
        {
            ToolTip tl = new ToolTip();
            mskName.Mask = strMask;
            tl.SetToolTip(mskName, strTooltip);
        }
        public static void SetColorRichText(this RichTextBox rtext, int Start, int Length, Color cl)
        {
            rtext.SelectionStart = Start;
            rtext.SelectionLength = Length;
            rtext.SelectionColor = cl;
        }
        public static void InitDataGridView(this DataGridView dgv)
        {
            DataGridViewCellStyle alternateStyle = new DataGridViewCellStyle();
            //alternateStyle.BackColor = Color.FromArgb(224, 224, 224);
            //dgv.AlternatingRowsDefaultCellStyle = alternateStyle;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.Gray;
            headerStyle.Font = new Font("Tahoma", 9.25F, FontStyle.Bold);
            headerStyle.ForeColor = SystemColors.WindowText;
            headerStyle.SelectionBackColor = SystemColors.Highlight;
            headerStyle.SelectionForeColor = SystemColors.HighlightText;
            headerStyle.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.25F, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle = headerStyle;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.BackgroundColor = SystemColors.Window;
            dgv.MultiSelect = false;
            dgv.ScrollBars = ScrollBars.Both;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RefreshEdit();
        }
        public static void InitDataGridView(this DataGridView dgv, bool ReadOnly)
        {
            DataGridViewCellStyle alternateStyle = new DataGridViewCellStyle();
            //alternateStyle.BackColor = Color.FromArgb(224, 224, 224);
            //dgv.AlternatingRowsDefaultCellStyle = alternateStyle;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.Gray;
            headerStyle.Font = new Font("Tahoma", 9.25F, FontStyle.Bold);
            headerStyle.ForeColor = SystemColors.WindowText;
            headerStyle.SelectionBackColor = SystemColors.Highlight;
            headerStyle.SelectionForeColor = SystemColors.HighlightText;
            headerStyle.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.25F, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle = headerStyle;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.BackgroundColor = SystemColors.Window;
            dgv.MultiSelect = false;
            dgv.ScrollBars = ScrollBars.Both;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = ReadOnly;
            //dgv.RowHeadersVisible = false;
            
        }        
        public static void SetReadonly(this UserControl control, bool value)
        {
            foreach (Control ctr in control.Controls)
            {
                if (ctr is Panel)
                    ((Panel)ctr).SetReadonly(value);                
                if (ctr is MaskedTextBox)
                {
                    ((MaskedTextBox)ctr).ReadOnly = value;
                    ((MaskedTextBox)ctr).BackColor = Color.White;
                }                
                if (ctr is CheckBox)
                {
                    ((CheckBox)ctr).Enabled = !value;
                    // ((CheckBox)ctr).BackColor = Color.White;
                }
                if (ctr is TextBox)
                {
                    ((TextBox)ctr).ReadOnly = value;
                    ((TextBox)ctr).BackColor = Color.White;
                }
                if (ctr is RichTextBox)
                {
                    ((RichTextBox)ctr).ReadOnly = value;
                    ((RichTextBox)ctr).BackColor = Color.White;
                }
                if (ctr is ComboBox)
                {
                    ((ComboBox)ctr).Enabled = !value;
                    ((ComboBox)ctr).BackColor = Color.White;
                }

                if (ctr is NumericUpDown)
                {
                    ((NumericUpDown)ctr).Enabled = !value;
                    ((NumericUpDown)ctr).BackColor = Color.White;
                }
                if (ctr is LinkLabel)
                {
                    ((LinkLabel)ctr).Enabled = !value;
                    ((LinkLabel)ctr).BackColor = Color.White;
                    ((LinkLabel)ctr).ForeColor = Color.Black;
                }
                if (ctr is Button)
                {
                    ((Button)ctr).Enabled = !value;
                    // ((NumericUpDown)ctr).BackColor = Color.White;
                }
                if (ctr is ComboBox)
                {
                    ((ComboBox)ctr).Enabled = !value;
                    ((ComboBox)ctr).BackColor = Color.White;
                }
            }
        }
        public static void SetReadonly(this Panel grb, bool value)
        {
            foreach (Control ctr in grb.Controls)
            {
                if (ctr is Panel)
                    ((Panel)ctr).SetReadonly(value);                
                if (ctr is MaskedTextBox)
                {
                    ((MaskedTextBox)ctr).ReadOnly = value;
                    ((MaskedTextBox)ctr).BackColor = Color.White;
                }                
                if (ctr is CheckBox)
                {
                    ((CheckBox)ctr).Enabled = !value;
                    // ((CheckBox)ctr).BackColor = Color.White;
                }
                if (ctr is TextBox)
                {
                    ((TextBox)ctr).ReadOnly = value;
                    ((TextBox)ctr).BackColor = Color.White;
                }
                if (ctr is RichTextBox)
                {
                    ((RichTextBox)ctr).ReadOnly = value;
                    ((RichTextBox)ctr).BackColor = Color.White;
                }
                if (ctr is ComboBox)
                {
                    ((ComboBox)ctr).Enabled = !value;
                    ((ComboBox)ctr).BackColor = Color.White;
                }

                if (ctr is NumericUpDown)
                {
                    ((NumericUpDown)ctr).Enabled = !value;
                    ((NumericUpDown)ctr).BackColor = Color.White;
                }
                if (ctr is LinkLabel)
                {
                    ((LinkLabel)ctr).Enabled = !value;
                    ((LinkLabel)ctr).BackColor = Color.White;
                    ((LinkLabel)ctr).ForeColor = Color.Black;
                }
                if (ctr is Button)
                {
                    ((Button)ctr).Enabled = !value;
                    // ((NumericUpDown)ctr).BackColor = Color.White;
                }
                if (ctr is ComboBox)
                {
                    ((ComboBox)ctr).Enabled = !value;
                    ((ComboBox)ctr).BackColor = Color.White;
                }

            }
        }
        public static void SetReadonly(this GroupBox grb, bool value)
        {
            foreach (Control ctr in grb.Controls)
            {
                if (ctr is GroupBox)
                    ((GroupBox)ctr).SetReadonly(value);
                if (ctr is Panel)
                    ((Panel)ctr).SetReadonly(value);              
                if (ctr is MaskedTextBox)
                {
                    ((MaskedTextBox)ctr).ReadOnly = value;
                    ((MaskedTextBox)ctr).BackColor = Color.White;
                }                
                if (ctr is CheckBox)
                {
                    ((CheckBox)ctr).Enabled = !value;
                    // ((CheckBox)ctr).BackColor = Color.White;
                }
                if (ctr is RadioButton)
                {
                    ((RadioButton)ctr).Enabled = !value;
                    //((RadioButton)ctr).BackColor = Color.White ;
                }
                if (ctr is TextBox)
                {
                    ((TextBox)ctr).ReadOnly = value;
                    ((TextBox)ctr).BackColor = Color.White;
                }
                if (ctr is RichTextBox)
                {
                    ((RichTextBox)ctr).ReadOnly = value;
                    ((RichTextBox)ctr).BackColor = Color.White;
                }
                if (ctr is NumericUpDown)
                {
                    ((NumericUpDown)ctr).ReadOnly = value;
                    ((NumericUpDown)ctr).BackColor = Color.White;
                }
                if (ctr is ComboboxReadOnly.ComboboxReadOnly)
                {
                    ((ComboboxReadOnly.ComboboxReadOnly)ctr).ReadOnly = value;
                    ((ComboboxReadOnly.ComboboxReadOnly)ctr).BackColor = Color.White;
                }
                if (ctr is NumericUpDown)
                {
                    ((NumericUpDown)ctr).Enabled = !value;
                    ((NumericUpDown)ctr).BackColor = Color.White;
                }
                if (ctr is LinkLabel)
                {
                    ((LinkLabel)ctr).Enabled = !value;
                    //((LinkLabel)ctr).BackColor = Color.White;
                    ((LinkLabel)ctr).ForeColor = Color.Black;
                }
                if (ctr is Button)
                {
                    ((Button)ctr).Enabled = !value;
                    // ((NumericUpDown)ctr).BackColor = Color.White;
                }                
                if (ctr is ComboBox)
                {
                    ((ComboBox)ctr).Enabled = !value;
                    ((ComboBox)ctr).BackColor = Color.White;
                }
                
            }
        }
        
        public static void SetReadonlyGroupBox(bool value, params GroupBox[] groupBoxes)
        {
            foreach (GroupBox groupBox in groupBoxes)
                groupBox.SetReadonly(value);
        }
        public static void SetReadonlyTextBox(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.ReadOnly = true;
                textBox.BackColor = Color.White;
            }
        }

        public static void SetReadonly(this TextBox ctr, bool value)
        {
            ctr.ReadOnly = value;
            ctr.BackColor = Color.White;
        }       

        public static void SetReadOnly(this MaskedTextBox mask,bool value)
        {
            mask.ReadOnly = value;
            mask.BackColor = Color.White;            
        }       
        public static void TabDrawItem(TabControl tabMain, DrawItemEventArgs e)
        {
            //get tabpage
            TabPage tabPages = tabMain.TabPages[e.Index];
            Graphics graphics = e.Graphics;
            Brush textBrush = new SolidBrush(Color.White); //fore color brush
            Rectangle tabBounds = tabMain.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
            {
                graphics.FillRectangle(Brushes.DodgerBlue, e.Bounds); //fill background color
            }
            else
            {
                textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                //e.DrawBackground();
            }
            Font tabFont = new Font("Tahoma", 9.25F, FontStyle.Regular);
            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;
            // draw text
            //graphics.DrawString(Resources.GetString(tabPages.Name, tabPages.Text), tabFont, textBrush, tabBounds, new StringFormat(strFormat));
            graphics.Dispose();
            textBrush.Dispose();
        }
        public static ErrorProvider errpro = new ErrorProvider();
        public static void SetError(this Control ctrName, string strError)
        {
            errpro.SetError(ctrName, strError);
            ctrName.Focus();
        }

        public static void ClearError(this Control ctrName)
        {
            //Sonlt- clear all error in control
            foreach (Control ctr in ctrName.Controls)
            {
                errpro.SetError(ctr, "");
            }
            errpro.Clear();
        }

        public static void SetToolTip(this Control ctl, string strText)
        {
            ToolTip tl = new ToolTip();
            tl.SetToolTip(ctl, strText);
        }
        public static void SetBackColorRecursive(this Control control)
        {
            SetBackColor(control);
            foreach (Control ctl in control.Controls)
            {                
                if (ctl is SplitContainer)
                {
                    ctl.BackColor = SystemColors.Control;;
                    SetBackColorRecursive(ctl);
                }                
                if (ctl is TabControl)
                {
                    ctl.BackColor = SystemColors.Control;;
                    SetBackColorRecursive(ctl);
                }
                if (ctl is GroupBox)
                {
                    ctl.BackColor = SystemColors.Control;;
                    SetBackColorRecursive(ctl);
                }
                else if (ctl is Panel)
                {
                    ctl.BackColor = SystemColors.Control;;
                    SetBackColorRecursive(ctl);
                }                
            }
        }
        public static void SetBackColor(this Control ctl)
        {
            
            if (ctl is SplitContainer)
            {
                ctl.BackColor = SystemColors.Control;;
            }
            
            if (ctl is TabControl)
            {
                ctl.BackColor = SystemColors.Control;;
            }
            if (ctl is GroupBox)
            {
                ctl.BackColor = SystemColors.Control;;
            }
            else if (ctl is Panel)
            {
                ctl.BackColor = SystemColors.Control;;
            }            
        }
        
        /// <summary>
        /// Gan value cho combo
        /// </summary>
        /// <param name="cbo"></param>
        /// <param name="value"></param>
        public static void SetSelectedValue(this ComboBox cbo, object value)
        {
            if (value == null)
            {
                cbo.SelectedIndex = -1;
            }
            else
            {
                cbo.SelectedValue = value;
            }
        }



        /// <summary>
        /// Gan data source cho ComboBox
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="cbo"></param>
        /// <param name="source"></param>
        /// <param name="display"></param>
        /// <param name="value"></param>
        public static void DataSourceBind<TEntity>(this ComboBox cbo, IList<TEntity> source, string display, string value)
            where TEntity : class
        {
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            List<TEntity> lstSource = new List<TEntity>(source);
            //cbo.Items.Clear();
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.FlatStyle = FlatStyle.Flat;
            cbo.DataSource = lstSource;
            if (lstSource.Count > 0)
                cbo.SelectedIndex = -1;
        }
        public static void DataSourceBind(this ComboBox cbo, DataTable dt, string display, string value)
        {
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.FlatStyle = FlatStyle.Flat;
            cbo.DataSource = dt;
            if (dt.Rows.Count > 0)
                cbo.SelectedIndex = 0;
        }

        public struct ColumnInfo
        {
            public string PropertyName
            { set; get; }
            public string PropertyValue
            { set; get; }

            public void GetColumnInfo(string msg)
            {
                string[] s = msg.Split(new char[] { ':' });
                this.PropertyName = string.Empty;
                this.PropertyValue = string.Empty;
                if (s.Length >= 2)
                {
                    this.PropertyName = s[0];
                    this.PropertyValue = s[1].Trim();
                    if (this.PropertyName.ToLower() == "name" || this.PropertyName.ToLower() == "caption")
                        this.PropertyValue = this.PropertyValue.Substring(1, s[1].Length - 2);
                }
            }
        }

        private static string GetColumnName(string[] columnInfoString)
        {
            ColumnInfo columnInfo = new ColumnInfo();
            string result = string.Empty;
            for (int i = 0; i < columnInfoString.Length; i++)
            {
                columnInfo.GetColumnInfo(columnInfoString[i]);
                if (columnInfo.PropertyName.ToLower() == "name")
                {
                    result = columnInfo.PropertyValue;
                    break;
                }
            }
            return result;
        }
        public static void SetNodeFontBold(this TreeNode node)
        {
            if (node == null) return;
            if (node.NodeFont != null)
                node.NodeFont = new Font(node.NodeFont, FontStyle.Bold);
            else
                node.NodeFont = new Font("Tahoma", 9.25F, FontStyle.Bold);
            node.Text = node.Text + string.Empty;
        }
    }

    public enum RadColumnType : int
    {
        Text = 0,
        Combo = 1,
        Decimal = 2,
        Maskup = 3,
        Check = 4
    }

    public class ColumnSetting
    {
        public string ColName { get; set; }
        public string FieldName { get; set; }
        public string ColumnHeader { get; set; }
        public int Width { get; set; }
        public bool Hide { get; set; }
        public bool IsPinned { get; set; }
        public bool NotAllowResize { get; set; }
        public RadColumnType ColumnType { get; set; }
    }
}

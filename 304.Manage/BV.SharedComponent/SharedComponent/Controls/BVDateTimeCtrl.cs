using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV.SharedComponent.Controls
{
    public partial class BVDateTimeCtrl : UserControl
    {
        public event EventHandler ValueChanged;
        public event EventHandler InvalidValueChanged;

        private string _DateTimeFormat = "dd/MM/yyyy";
        private bool _ManualSetvalue = false;
        /// <summary>
        /// Date time format
        /// </summary>
        public string Format
        {
            set
            {
                dateTimePicker1.Format = DateTimePickerFormat.Time;
                _DateTimeFormat = value;
            }
        }
        public string ValueText
        {
            set
            {
                _ManualSetvalue = true;
                textBox1.Text = value;

                DateTime dtValue = DateTime.Now;
                bool bValid = DateTime.TryParseExact(textBox1.Text.Trim(), this._DateTimeFormat, null, System.Globalization.DateTimeStyles.AdjustToUniversal, out dtValue);

                dateTimePicker1.Value = bValid ? dtValue : DateTime.Now;
                _ManualSetvalue = false;
            }
            get { return textBox1.Text; }
        }

        public DateTime? Value
        {
            set
            {
                _ManualSetvalue = true;
                if (value == null)
                {
                    textBox1.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                }
                else
                {
                    textBox1.Text = value.Value.ToString(_DateTimeFormat);
                    dateTimePicker1.Value = value.Value;
                }

                _ManualSetvalue = false;
            }
            get
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    DateTime dtValue = DateTime.Now;
                    bool bValid = DateTime.TryParseExact(textBox1.Text.Trim(), this._DateTimeFormat, null, System.Globalization.DateTimeStyles.AdjustToUniversal, out dtValue);
                    if (bValid)
                    {
                        return dtValue;
                    }
                }

                return null;
            }
        }

        public bool IsValidDateTimeType
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    DateTime dtValue = DateTime.Now;
                    bool bValid = DateTime.TryParseExact(textBox1.Text.Trim(), this._DateTimeFormat, null, System.Globalization.DateTimeStyles.AdjustToUniversal, out dtValue);
                    return bValid;
                }

                return false;
            }
        }

        public BVDateTimeCtrl()
        {
            InitializeComponent();

            //_DateTimeFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!_ManualSetvalue)
            {
                textBox1.Text = dateTimePicker1.Value.ToString(_DateTimeFormat);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Auto convert string to Date follow format: Format = dd / MM / yyyy, 231215 => 23 / 12 / 2015
            string strText = textBox1.Text.Replace(" ", string.Empty);

            float fValueCheck = 0;


            if (strText.Length == 6 && float.TryParse(strText, out fValueCheck))
            {
                string sDateTime = strText.Insert(2, "/").Insert(5, "/20");
                textBox1.Text = sDateTime;
                textBox1.SelectionStart = textBox1.Text.Length;
                DateTime dtValue = DateTime.Now;
                bool bValid = DateTime.TryParseExact(sDateTime, _DateTimeFormat, null, System.Globalization.DateTimeStyles.AdjustToUniversal, out dtValue);
                if (bValid)
                {
                    _ManualSetvalue = true;
                    dateTimePicker1.Value = dtValue;
                    _ManualSetvalue = false;
                }
                else
                {
                    if (InvalidValueChanged != null)
                    {
                        InvalidValueChanged(this, e);
                    }
                }
            }
            else
            {
                if (ValueChanged != null)
                {
                    ValueChanged(this, e);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            string keyInput = e.KeyChar.ToString();

            if (Char.IsDigit(e.KeyChar))
            {
                // Digits are OK
            }
            else if (e.KeyChar == '/' || e.KeyChar == ':')
            {
                // Date time separator is OK
            }
            else if (e.KeyChar == '\b')
            {
                // Backspace key is OK
            }
            else if (e.KeyChar == ' ')
            {
                // Spacebar key is OK
            }
            else
            {
                // Swallow this invalid key and beep
                e.Handled = true;
                //    MessageBeep();
            }
        }
    }
}

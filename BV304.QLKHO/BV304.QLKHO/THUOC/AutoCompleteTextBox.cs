using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Text.RegularExpressions;

namespace BV.QLKHO.THUOC
{
    public class AutoCompleteTextBox : TextBox
    {
        public event EventHandler ItemValueChanged;
        private ListBox _ListSuggestion;

        private bool _isAdded;
        private String _formerValue = String.Empty;

        List<object> m_lstDataSources = new List<object>();
        List<object> m_lstListBoxSources = new List<object>();

        //Store value if object as user
        List<string> m_lstStringValues = new List<string>();

        public string DisplayMember { get; set; }

        public string ValueMember { get; set; }

        /// <summary>
        /// If true, must set ValueMember property
        /// </summary>
        public bool ObjectAsUser { get; set; }

        public bool MultiSelect { get; set; }

        public Control MainControl { get;set; }
        public bool FixedSize { get; set; }
        private string _value = string.Empty;

        private void OnValueChanged()
        {
            if (ItemValueChanged != null) ItemValueChanged(this, new EventArgs());
        }

        public string Value
        {
            set
            {
                if (value == null)
                {
                    value = "";
                }
                if (value == _value) return;
                m_lstStringValues = new List<string>();
                if (this.ObjectAsUser)
                {
                    string strAddText = "";
                    foreach (string item in value.Split(';'))
                    {
                        if (!string.IsNullOrWhiteSpace(item))
                        {
                            string strTextInsert = GetUserName(item.Trim());
                            strAddText += strTextInsert + "; ";
                            m_lstStringValues.Add(item.Trim());
                        }
                    }

                    this.Text = strAddText.Trim(new char[] { ' ', ';' });
                    _formerValue = this.Text;
                }
                else
                {
                    if (!MultiSelect)
                    {
                        string strTextInsert = GetUserName(value.Trim());
                        if (!string.IsNullOrWhiteSpace(strTextInsert))
                            value = strTextInsert;
                    }

                     this.Text = value;
                    _formerValue = this.Text;
                }
                _value = value;
                OnValueChanged();
            }

            get
            {
                if (string.IsNullOrWhiteSpace(this.Text)) return string.Empty;
                if (this.ObjectAsUser)
                {
                    string strText = "";
                    foreach (var value in m_lstStringValues)
                    {
                        strText += value + "; ";
                    }

                    return strText.Trim(new char[] { ' ', ';' });
                }
                else
                {
                    return this.Text.Trim(new char[] { ' ', ';' });
                }
            }
        }

        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
        }

        private string GetUserName(string strUserID)
        {
            if (string.IsNullOrWhiteSpace(strUserID) || m_lstDataSources.Count <= 0)
            {
                return "";
            }

            //Get text insert
            Type objectType = m_lstDataSources[0].GetType();
            foreach (var srcItem in m_lstDataSources)
            {
                string strTextValue = GetFieldValue(srcItem, objectType, this.ValueMember);
                if (strTextValue.Equals(strUserID, StringComparison.OrdinalIgnoreCase))
                {
                    return GetFieldValue(srcItem, objectType, this.DisplayMember);
                }
            }

            return "";
        }

        public void AddValue(string sValue)
        {
            if (string.IsNullOrWhiteSpace(sValue))
                return;

            bool bInsert = true;
            foreach (var item in m_lstStringValues)
            {
                if (item.Equals(sValue, StringComparison.OrdinalIgnoreCase))
                {
                    bInsert = false;
                    break;
                }
            }

            if (bInsert)
            {
                m_lstStringValues.Add(sValue);

                //Get value add string
                string strValue = this.Value;

                //Set value back to display
                this.Value = strValue;                
            }
        }

        public void AddValue(List<string> lstValuesID)
        {
            if (lstValuesID.Count < 1)
                return;

            List<string> lstAdded = new List<string>();

            foreach (var item in lstValuesID)
            {
                bool bInsert = true;
                foreach (var sValue in m_lstStringValues)
                {
                    if (item.Equals(sValue, StringComparison.OrdinalIgnoreCase))
                    {
                        bInsert = false;
                        break;
                    }
                }

                if (bInsert)
                {
                    lstAdded.Add(item);                    
                }
            }

            if (lstAdded.Count > 0)
            {
                m_lstStringValues.AddRange(lstAdded);
                
                //Get value add string
                string strValue = this.Value;

                //Set value back to display
                this.Value = strValue;
            }
        }

        public List<Object> Sources
        {
            set
            {
                if (value == null || value.Count < 1)
                    return;

                m_lstDataSources = value;
            }

            get
            {
                return m_lstDataSources;
            }
        }

        public AutoCompleteTextBox()
        {
            InitializeComponent();
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);

            //BuildListBox();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            //SetScrollBar();
            _ListSuggestion.Width = Width - 20;
        }

        #region visibility of suggest box

        protected override void OnLostFocus(EventArgs e)
        {
            // _suggLb can only getting focused by clicking (because TabStop is off)
            // --> click-eventhandler 'SuggLbOnClick' is called
            if (!_ListSuggestion.Focused)
                HideSuggBox();

            base.OnLostFocus(e);
        }

        private void HideSuggBox()
        {
            _ListSuggestion.Visible = false;
        }

        #endregion

        void AutoCompleteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.FixedSize)
            {
                return;
            }
            if (this.MultiSelect)
            {
                if (!this.Multiline)
                    this.Multiline = true;

                //Amount of padding to add
                const int padding = 3;
                //get number of lines (first line is 0)
                int numLines = this.GetLineFromCharIndex(this.TextLength) + 1;

                //set height (height of one line * number of lines + spacing)
                int border = this.Height - this.ClientSize.Height;

                //get border thickness
                int nMinimumHeight = this.Font.Height + padding + border;

                if (numLines > 1)
                {
                    this.Multiline = true;

                    int nHeight = this.Font.Height * numLines + padding + border;
                    nHeight = nHeight > nMinimumHeight ? nHeight : nMinimumHeight;
                    this.Height = nHeight;
                }
                else
                {
                    //this.Multiline = false;
                    this.Height = nMinimumHeight;
                    this.ScrollBars = System.Windows.Forms.ScrollBars.None;
                }
            }            

        }

        

        private void BuildListBox()
        {
            if (!_isAdded)
            {
                Control oParrentControl = this.MainControl;
                if (oParrentControl == null)
                {
                    throw new Exception("Please set MainControl for " + this.Name);
                }

                oParrentControl.Controls.Add(_ListSuggestion);
                _ListSuggestion.TabIndex = this.TabIndex;

                _isAdded = true;
            }

            if (_isAdded)
            {
                
                Point oPoin = this.GetPositionFromCharIndex(this.SelectionStart - 1);

                int pY = this.Parent.Location.Y;

                _ListSuggestion.Width = Width - 12;
                _ListSuggestion.Left = this.Left + 12;
                _ListSuggestion.Top = pY + this.Top + oPoin.Y + 20;
                _ListSuggestion.BringToFront();
            }
        }

        private void ResetListBox()
        {
            _ListSuggestion.Visible = false;
        }

        private void GetValueFromListSuggestion()
        {
            if (_ListSuggestion.SelectedIndex == -1) return;
            ResetListBox();

            //Get value insert
            object oSelectedItem = m_lstListBoxSources[_ListSuggestion.SelectedIndex];

            //Get text insert
            string strTextInsert = "";
            if (oSelectedItem is string)
            {
                strTextInsert = oSelectedItem as string;
            }
            else
            {
                Type objectType = m_lstDataSources[0].GetType();
                strTextInsert = GetFieldValue(oSelectedItem, objectType, this.DisplayMember);

                if (ObjectAsUser)
                {
                    string strValue = GetFieldValue(oSelectedItem, objectType, this.ValueMember);
                    m_lstStringValues.Add(strValue);
                    _value = strValue;
                }
            }

            InsertWord(strTextInsert);
        }

        void AutoCompleteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check if allow press ';' to separate item in list
            if (e.KeyChar == ';')
            {
                if (!this.MultiSelect)
                {
                    e.Handled = true;
                    return;
                }

                if (this.ObjectAsUser && this.Text.Split(';').Length > m_lstStringValues.Count)
                {
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                int iSelectionStart = this.SelectionStart;
                string text = this.Text;

                //item1; item2; ite
                //Check if cursor is indicating to the "ite" text, return
                string strTemp = text.Substring(0, iSelectionStart);
                string[] arrSplitString = strTemp.Split(';');
                if (arrSplitString.Length <= m_lstStringValues.Count)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void AutoCompleteTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.Text == "")
            {
                _formerValue = "";
                _ListSuggestion.Visible = false;
                return;
            }

            if (ObjectAsUser)
            {
                //Check if cursor is indicating to the "ite" text, return
                string strTemp = this.Text.Substring(0, this.SelectionStart);
                string[] arrSplitString = strTemp.Split(';');
                if (arrSplitString.Length > m_lstStringValues.Count)
                {
                    UpdateListBox();
                }
            }
            else
                UpdateListBox();
        }

        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    if (_ListSuggestion.Visible)
                        return true;

                    return false;
                case Keys.Tab:
                    if (_ListSuggestion.Visible)
                        return true;

                    return false;
                default:
                    return base.IsInputKey(keyData);
            }
        }

        public List<string> GetValuesFromSuggestionText()
        {
            List<string> lstItems = new List<string>();

            string strTextValue = this.Text.Trim();

            string[] arrValue = strTextValue.Split(';');

            foreach (string sValue in arrValue)
            {
                lstItems.AddRange(SplitByLength(sValue.Trim(), 0));
            }

            return lstItems;
        }

        private List<string> SplitByLength(string sInput, int nLength)
        {
            List<string> lstItems = new List<string>();

            if (nLength > 0 && MultiSelect)
            {
                int nInputLeng = sInput.Length;
                int nStartIndex = 0;
                while (true)
                {
                    if (nStartIndex + nLength >= nInputLeng)
                    {
                        lstItems.Add(sInput.Substring(nStartIndex, nInputLeng - nStartIndex));
                        break;
                    }
                    else
                    {
                        lstItems.Add(sInput.Substring(nStartIndex, nLength));
                        nStartIndex += nLength;
                    }
                }
            }
            else
            {
                lstItems.Add(sInput);
            }

            return lstItems;
        }

        private void AutoCompleteTextBox_KeyDown(object sender, KeyEventArgs e)
        {
           switch (e.KeyCode)
            {
                case Keys.Tab:
                case Keys.Enter:
                    //if (_isAdded && _ListSuggestion.Visible)
                    //{
                    //    GetValueFromListSuggestion();
                    //}
                    GetValueFromListSuggestion();
                    e.SuppressKeyPress = true;
                    //this.Focus();

                    //if (!this.MultiSelect)
                    //{
                    //    SendKeys.Send("{TAB}");
                    //}

                    break;

                case Keys.Down:
                    if (_ListSuggestion.Visible && _ListSuggestion.SelectedIndex < _ListSuggestion.Items.Count - 1)
                    {
                        _ListSuggestion.SelectedIndex++;
                        e.SuppressKeyPress = true;
                    }

                    break;

                case Keys.Up:
                    if (_ListSuggestion.Visible && _ListSuggestion.SelectedIndex > 0)
                    {
                        _ListSuggestion.SelectedIndex--;
                        e.SuppressKeyPress = true;
                    }

                    break;

                case Keys.Escape:
                    ResetListBox();
                    e.SuppressKeyPress = true;
                    break;

                case Keys.Left:
                case Keys.Right:

                    ResetListBox();

                    if (ObjectAsUser)
                    {
                        int iSelectionStart = this.SelectionStart;
                        string text = this.Text;

                        //abc; def; aa
                        //Check if cursor is indicating to the selected item
                        string strTemp = text.Substring(0, iSelectionStart);
                        if (strTemp.Split(';').Length > m_lstStringValues.Count)
                            return;

                        //Get position start
                        int pos = this.SelectionStart;
                        int posStart = text.LastIndexOf(';', (pos < 1) ? 0 : pos - 1);
                        posStart = (posStart == -1) ? 0 : posStart;

                        //Get index of wort in the textbox
                        string sWord = GetWord().Trim();
                        int wordIndex = text.IndexOf(sWord, posStart);

                        if (e.KeyCode == Keys.Left && iSelectionStart > wordIndex && iSelectionStart <= wordIndex + sWord.Length)
                        {
                            this.SelectionStart = wordIndex;
                            e.SuppressKeyPress = true;
                        }

                        if (e.KeyCode == Keys.Right && iSelectionStart >= wordIndex && iSelectionStart < wordIndex + sWord.Length)
                        {
                            this.SelectionStart = wordIndex + sWord.Length;
                            e.SuppressKeyPress = true;
                        }
                    }

                    break;

                case Keys.Back:
                case Keys.Delete:
                    if (ObjectAsUser)
                    {
                        int iSelectionStart = this.SelectionStart;
                        string text = this.Text;

                        //item1; item2; ite
                        //Check if cursor is indicating to the "ite" text, return
                        string strTemp = text.Substring(0, iSelectionStart);
                        string[] arrSplitString = strTemp.Split(';');
                        if (arrSplitString.Length > m_lstStringValues.Count)
                            return;

                        //If cursor indicate to " item2", test with " item2"
                        //Get position start
                        int pos = this.SelectionStart;
                        int posStart = text.LastIndexOf(';', (pos < 1) ? 0 : pos - 1);
                        posStart = (posStart == -1) ? 0 : posStart + 1;

                        //Get position end
                        int posEnd = text.IndexOf(';', iSelectionStart);
                        posEnd = (posEnd == -1) ? this.Text.Length : posEnd;

                        //Get leng of item2, include space charactor " item2"
                        int length = ((posEnd - posStart) < 0) ? 0 : posEnd - posStart;

                        //Get word " item2"
                        string sWord = text.Substring(posStart, length);

                        //Get index of word "item2"
                        int wordIndex = text.IndexOf(sWord.Trim(), posStart);

                        //Check if delete " item2" or space charactor in "item2"
                        bool bDeleteItem = false;
                        if (e.KeyCode == Keys.Back)
                        {
                            //Back
                            if (pos == posStart)
                            {
                                //Do nothing
                                e.SuppressKeyPress = true;
                                return;
                            }
                            else
                                bDeleteItem = (iSelectionStart > wordIndex && iSelectionStart <= wordIndex + sWord.Length);
                        }
                        else
                        {
                            //Delete 
                            if (pos == posEnd)
                            {
                                //Do nothing
                                e.SuppressKeyPress = true;
                                return;
                            }
                            else
                                bDeleteItem = iSelectionStart >= wordIndex && iSelectionStart < wordIndex + sWord.Length;

                        }

                        if (bDeleteItem)
                        {
                            String firstPart = text.Substring(0, posStart).TrimStart();
                            //if (!string.IsNullOrWhiteSpace(firstPart))
                            //    firstPart = firstPart.TrimEnd(';');

                            string lastPart = text.Substring(posEnd, text.Length - posEnd).TrimStart(';');
                            //if (!string.IsNullOrWhiteSpace(lastPart))
                            //    lastPart = lastPart.TrimStart(';');

                            String updatedText = firstPart.TrimEnd(';') + ";" + lastPart.TrimStart(';');
                            if (string.IsNullOrWhiteSpace(firstPart) || string.IsNullOrWhiteSpace(lastPart))
                                updatedText = firstPart + lastPart;

                            this.Text = updatedText.TrimStart();
                            _formerValue = this.Text;

                            if (e.KeyCode == Keys.Back)
                                this.SelectionStart = firstPart.Length;
                            else
                                this.SelectionStart = this.Text.Length - lastPart.Length + 1;

                            //Delete item value
                            m_lstStringValues.RemoveAt(arrSplitString.Length - 1);

                            e.SuppressKeyPress = true;
                        }

                        //Delete space in " item2"
                    }

                    break;
            }
        }

        void ListSuggestion_Click(object sender, EventArgs e)
        {
            //Application.DoEvents();
            GetValueFromListSuggestion();

            //this.Focus();
        }

        private string GetFieldValue(object item, Type objectType, string fieldName)
        {
            string fieldValue = "";
            PropertyInfo pi = objectType.GetProperty(fieldName);
            if (pi != null)
            {
                fieldValue = pi.GetValue(item, null).ToString();
            }
            else
            {
                FieldInfo fi = objectType.GetField(fieldName);
                if (fi != null)
                {
                    fieldValue = fi.GetValue(item).ToString();
                }
            }

            return fieldValue;
        }

        private List<string> FindRelationObjects(string word)
        {
            List<string> lstDisplay = new List<string>();
            m_lstListBoxSources = new List<object>();

            if (m_lstDataSources.Count < 1)
                return lstDisplay;

            //Source is string
            if (m_lstDataSources[0] is String)
            {
                foreach (var item in m_lstDataSources)
                {
                    string strValue = (string)item;
                    if (strValue.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        m_lstListBoxSources.Add(strValue);
                        lstDisplay.Add(strValue);
                    }

                    if (lstDisplay.Count > 20)
                    {
                        break;
                    }
                }
            }
            else
            {
                Type objectType = m_lstDataSources[0].GetType();
                foreach (var item in m_lstDataSources)
                {
                    //Get property's value as DisplayMember
                    string strItemDisplay = GetFieldValue(item, objectType, this.DisplayMember);

                    //For detail
                    if (this.ObjectAsUser)
                    {
                        //Get property's value as ValueMember, display format as "Login Name <login id>"
                        string strValue = GetFieldValue(item, objectType, this.ValueMember);
                        strItemDisplay = $"{strValue} ({strItemDisplay})";
                        //if (!strItemDisplay.Equals(strValue, StringComparison.OrdinalIgnoreCase))
                        //    strItemDisplay += " <" + strValue + ">";
                    }

                    if (strItemDisplay.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        m_lstListBoxSources.Add(item);
                        lstDisplay.Add(strItemDisplay);
                    }

                    if (lstDisplay.Count > 20)
                    {
                        break;
                    }
                }
            }

            return lstDisplay;
        }

        private void UpdateListBox()
        {
            if (this.Text != _formerValue)
            {
                _formerValue = this.Text;
                String word = GetWord();

                if (word.Length > 0)
                {
                    string strSearchText = word.TrimStart();

                    if (word.Length > 1 && string.IsNullOrWhiteSpace(word))
                        strSearchText = word;

                    List<string> lstDisplayItems = FindRelationObjects(strSearchText);

                    if (lstDisplayItems.Count > 0)
                    {
                        BuildListBox();
                        _ListSuggestion.Visible = true;


                        _ListSuggestion.Items.Clear();
                        foreach (var item in lstDisplayItems)
                        {
                            _ListSuggestion.Items.Add(item);
                        }

                        _ListSuggestion.SelectedIndex = 0;

                        _ListSuggestion.Height = 0;
                        _ListSuggestion.Width = 0;
                        //this.Focus();
                        using (Graphics graphics = _ListSuggestion.CreateGraphics())
                        {
                            for (int i = 0; i < _ListSuggestion.Items.Count; i++)
                            {
                                if (i > 8)
                                    break;

                                _ListSuggestion.Height += _ListSuggestion.GetItemHeight(i);
                                // it item width is larger than the current one
                                // set it to the new max item width
                                // GetItemRectangle does not work for me
                                // we add a little extra space by using '_'
                                //int itemWidth = (int)graphics.MeasureString(((String)_listBox.Items[i]) + "_", _listBox.Font).Width;
                                //_listBox.Width = (_listBox.Width < itemWidth) ? itemWidth : _listBox.Width;

                                _ListSuggestion.Width = Width - 12;
                            }
                        }
                    }
                    else
                    {
                        ResetListBox();
                    }
                }
                else
                {
                    ResetListBox();
                }
            }
        }

        private String GetWord()
        {
            String text = this.Text;
            int pos = this.SelectionStart;

            int posStart = text.LastIndexOf(';', (pos < 1) ? 0 : pos - 1);
            posStart = (posStart == -1) ? 0 : posStart + 1;
            int posEnd = text.IndexOf(';', pos);
            posEnd = (posEnd == -1) ? text.Length : posEnd;

            int length = ((posEnd - posStart) < 0) ? 0 : posEnd - posStart;

            return text.Substring(posStart, length);
        }

        private void InsertWord(String newTag)
        {
            String text = this.Text;
            int pos = this.SelectionStart;

            int posStart = text.LastIndexOf(';', (pos < 1) ? 0 : pos - 1);

            posStart = (posStart == -1) ? 0 : posStart + 1;
            int posEnd = text.IndexOf(';', pos);

            String firstPart = (text.Substring(0, posStart) + " " + newTag).TrimStart();
            
            String updatedText = firstPart + ((posEnd == -1) ? "" : text.Substring(posEnd, text.Length - posEnd));


            this.Text = updatedText;
            _formerValue = this.Text;
            this.SelectionStart = firstPart.Length;

            this.Focus();
            OnValueChanged();
        }

        private void InitializeComponent()
        {
            this._ListSuggestion = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _ListSuggestion
            // 
            this._ListSuggestion.Location = new System.Drawing.Point(0, 0);
            this._ListSuggestion.Name = "_ListSuggestion";
            this._ListSuggestion.Size = new System.Drawing.Size(120, 96);
            this._ListSuggestion.TabIndex = 0;
            this._ListSuggestion.Click += new System.EventHandler(this.ListSuggestion_Click);
            // 
            // AutoCompleteTextBox
            // 
            this.TextChanged += new System.EventHandler(this.AutoCompleteTextBox_TextChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AutoCompleteTextBox_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoCompleteTextBox_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AutoCompleteTextBox_KeyUp);
            this.Validated += new System.EventHandler(this.AutoCompleteTextBox_Validated);
            this.ResumeLayout(false);

        }

        private void AutoCompleteTextBox_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void AutoCompleteTextBox_Validated(object sender, EventArgs e)
        {
            
        }
        public string GetValueDescription()
        {
            if (m_lstDataSources.Count < 1)
            {
                return "";
            }
            string strText = "";
            string[] arrValue = this.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var itemID in arrValue)
            {
                Type objectType = m_lstDataSources[0].GetType();
                foreach (var item in m_lstDataSources)
                {
                    if (GetFieldValue(item, objectType, this.DisplayMember).Equals(itemID.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        //Get property's value as DisplayMember
                        strText += GetFieldValue(item, objectType, this.ValueMember) + "; ";

                        break;
                    }
                }
            }

            return strText.Trim(new char[] { ';', ' ' });
        }

        
    }
}

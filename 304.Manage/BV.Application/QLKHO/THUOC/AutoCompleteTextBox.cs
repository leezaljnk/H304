using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BV.QLKHO.THUOC
{
    public class AutoCompleteTextBox : TextBox
    {
        private string _formerValue = string.Empty;

        private bool _isAdded;
        private ListBox _ListSuggestion;
        private string _value = string.Empty;

        private List<object> m_lstDataSources = new List<object>();
        private List<object> m_lstListBoxSources = new List<object>();

        //Store value if object as user
        private List<string> m_lstStringValues = new List<string>();

        public AutoCompleteTextBox()
        {
            InitializeComponent();
        }

        public string DisplayMember { get; set; }

        public string ValueMember { get; set; }

        /// <summary>
        ///     If true, must set ValueMember property
        /// </summary>
        public bool ObjectAsUser { get; set; }

        public bool MultiSelect { get; set; }

        public Control MainControl { get; set; }
        public bool FixedSize { get; set; }

        public string Value
        {
            set
            {
                if (value == null) value = "";
                if (value == _value) return;
                m_lstStringValues = new List<string>();
                if (ObjectAsUser)
                {
                    var strAddText = "";
                    foreach (var item in value.Split(';'))
                        if (!string.IsNullOrWhiteSpace(item))
                        {
                            var strTextInsert = GetUserName(item.Trim());
                            strAddText += strTextInsert + "; ";
                            m_lstStringValues.Add(item.Trim());
                        }

                    Text = strAddText.Trim(' ', ';');
                    _formerValue = Text;
                }
                else
                {
                    if (!MultiSelect)
                    {
                        var strTextInsert = GetUserName(value.Trim());
                        if (!string.IsNullOrWhiteSpace(strTextInsert))
                            value = strTextInsert;
                    }

                    Text = value;
                    _formerValue = Text;
                }

                _value = value;
                OnValueChanged();
            }

            get
            {
                if (string.IsNullOrWhiteSpace(Text)) return string.Empty;
                if (ObjectAsUser)
                {
                    var strText = "";
                    foreach (var value in m_lstStringValues) strText += value + "; ";

                    return strText.Trim(' ', ';');
                }

                return Text.Trim(' ', ';');
            }
        }

        public List<object> Sources
        {
            set
            {
                if (value == null || value.Count < 1)
                    return;

                m_lstDataSources = value;
            }

            get => m_lstDataSources;
        }

        public event EventHandler ItemValueChanged;

        private void OnValueChanged()
        {
            if (ItemValueChanged != null) ItemValueChanged(this, new EventArgs());
        }

        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
        }

        private string GetUserName(string strUserID)
        {
            if (string.IsNullOrWhiteSpace(strUserID) || m_lstDataSources.Count <= 0) return "";

            //Get text insert
            var objectType = m_lstDataSources[0].GetType();
            foreach (var srcItem in m_lstDataSources)
            {
                var strTextValue = GetFieldValue(srcItem, objectType, ValueMember);
                if (strTextValue.Equals(strUserID, StringComparison.OrdinalIgnoreCase))
                    return GetFieldValue(srcItem, objectType, DisplayMember);
            }

            return "";
        }

        public void AddValue(string sValue)
        {
            if (string.IsNullOrWhiteSpace(sValue))
                return;

            var bInsert = true;
            foreach (var item in m_lstStringValues)
                if (item.Equals(sValue, StringComparison.OrdinalIgnoreCase))
                {
                    bInsert = false;
                    break;
                }

            if (bInsert)
            {
                m_lstStringValues.Add(sValue);

                //Get value add string
                var strValue = Value;

                //Set value back to display
                Value = strValue;
            }
        }

        public void AddValue(List<string> lstValuesID)
        {
            if (lstValuesID.Count < 1)
                return;

            var lstAdded = new List<string>();

            foreach (var item in lstValuesID)
            {
                var bInsert = true;
                foreach (var sValue in m_lstStringValues)
                    if (item.Equals(sValue, StringComparison.OrdinalIgnoreCase))
                    {
                        bInsert = false;
                        break;
                    }

                if (bInsert) lstAdded.Add(item);
            }

            if (lstAdded.Count > 0)
            {
                m_lstStringValues.AddRange(lstAdded);

                //Get value add string
                var strValue = Value;

                //Set value back to display
                Value = strValue;
            }
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

        private void AutoCompleteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FixedSize) return;
            if (MultiSelect)
            {
                if (!Multiline)
                    Multiline = true;

                //Amount of padding to add
                const int padding = 3;
                //get number of lines (first line is 0)
                var numLines = GetLineFromCharIndex(TextLength) + 1;

                //set height (height of one line * number of lines + spacing)
                var border = Height - ClientSize.Height;

                //get border thickness
                var nMinimumHeight = Font.Height + padding + border;

                if (numLines > 1)
                {
                    Multiline = true;

                    var nHeight = Font.Height * numLines + padding + border;
                    nHeight = nHeight > nMinimumHeight ? nHeight : nMinimumHeight;
                    Height = nHeight;
                }
                else
                {
                    //this.Multiline = false;
                    Height = nMinimumHeight;
                    ScrollBars = ScrollBars.None;
                }
            }
        }


        private void BuildListBox()
        {
            if (!_isAdded)
            {
                var oParrentControl = MainControl;
                if (oParrentControl == null) throw new Exception("Please set MainControl for " + Name);

                oParrentControl.Controls.Add(_ListSuggestion);
                _ListSuggestion.TabIndex = TabIndex;

                _isAdded = true;
            }

            if (_isAdded)
            {
                var oPoin = GetPositionFromCharIndex(SelectionStart - 1);

                var pY = Parent.Location.Y;

                _ListSuggestion.Width = Width - 12;
                _ListSuggestion.Left = Left + 12;
                _ListSuggestion.Top = pY + Top + oPoin.Y + 20;
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
            var oSelectedItem = m_lstListBoxSources[_ListSuggestion.SelectedIndex];

            //Get text insert
            var strTextInsert = "";
            if (oSelectedItem is string)
            {
                strTextInsert = oSelectedItem as string;
            }
            else
            {
                var objectType = m_lstDataSources[0].GetType();
                strTextInsert = GetFieldValue(oSelectedItem, objectType, DisplayMember);

                if (ObjectAsUser)
                {
                    var strValue = GetFieldValue(oSelectedItem, objectType, ValueMember);
                    m_lstStringValues.Add(strValue);
                    _value = strValue;
                }
            }

            InsertWord(strTextInsert);
        }

        private void AutoCompleteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check if allow press ';' to separate item in list
            if (e.KeyChar == ';')
            {
                if (!MultiSelect)
                {
                    e.Handled = true;
                    return;
                }

                if (ObjectAsUser && Text.Split(';').Length > m_lstStringValues.Count) e.Handled = true;
            }
            else
            {
                var iSelectionStart = SelectionStart;
                var text = Text;

                //item1; item2; ite
                //Check if cursor is indicating to the "ite" text, return
                var strTemp = text.Substring(0, iSelectionStart);
                var arrSplitString = strTemp.Split(';');
                if (arrSplitString.Length <= m_lstStringValues.Count) e.Handled = true;
            }
        }

        private void AutoCompleteTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (Text == "")
            {
                _formerValue = "";
                _ListSuggestion.Visible = false;
                return;
            }

            if (ObjectAsUser)
            {
                //Check if cursor is indicating to the "ite" text, return
                var strTemp = Text.Substring(0, SelectionStart);
                var arrSplitString = strTemp.Split(';');
                if (arrSplitString.Length > m_lstStringValues.Count) UpdateListBox();
            }
            else
            {
                UpdateListBox();
            }
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
            var lstItems = new List<string>();

            var strTextValue = Text.Trim();

            var arrValue = strTextValue.Split(';');

            foreach (var sValue in arrValue) lstItems.AddRange(SplitByLength(sValue.Trim(), 0));

            return lstItems;
        }

        private List<string> SplitByLength(string sInput, int nLength)
        {
            var lstItems = new List<string>();

            if (nLength > 0 && MultiSelect)
            {
                var nInputLeng = sInput.Length;
                var nStartIndex = 0;
                while (true)
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
                        var iSelectionStart = SelectionStart;
                        var text = Text;

                        //abc; def; aa
                        //Check if cursor is indicating to the selected item
                        var strTemp = text.Substring(0, iSelectionStart);
                        if (strTemp.Split(';').Length > m_lstStringValues.Count)
                            return;

                        //Get position start
                        var pos = SelectionStart;
                        var posStart = text.LastIndexOf(';', pos < 1 ? 0 : pos - 1);
                        posStart = posStart == -1 ? 0 : posStart;

                        //Get index of wort in the textbox
                        var sWord = GetWord().Trim();
                        var wordIndex = text.IndexOf(sWord, posStart);

                        if (e.KeyCode == Keys.Left && iSelectionStart > wordIndex &&
                            iSelectionStart <= wordIndex + sWord.Length)
                        {
                            SelectionStart = wordIndex;
                            e.SuppressKeyPress = true;
                        }

                        if (e.KeyCode == Keys.Right && iSelectionStart >= wordIndex &&
                            iSelectionStart < wordIndex + sWord.Length)
                        {
                            SelectionStart = wordIndex + sWord.Length;
                            e.SuppressKeyPress = true;
                        }
                    }

                    break;

                case Keys.Back:
                case Keys.Delete:
                    if (ObjectAsUser)
                    {
                        var iSelectionStart = SelectionStart;
                        var text = Text;

                        //item1; item2; ite
                        //Check if cursor is indicating to the "ite" text, return
                        var strTemp = text.Substring(0, iSelectionStart);
                        var arrSplitString = strTemp.Split(';');
                        if (arrSplitString.Length > m_lstStringValues.Count)
                            return;

                        //If cursor indicate to " item2", test with " item2"
                        //Get position start
                        var pos = SelectionStart;
                        var posStart = text.LastIndexOf(';', pos < 1 ? 0 : pos - 1);
                        posStart = posStart == -1 ? 0 : posStart + 1;

                        //Get position end
                        var posEnd = text.IndexOf(';', iSelectionStart);
                        posEnd = posEnd == -1 ? Text.Length : posEnd;

                        //Get leng of item2, include space charactor " item2"
                        var length = posEnd - posStart < 0 ? 0 : posEnd - posStart;

                        //Get word " item2"
                        var sWord = text.Substring(posStart, length);

                        //Get index of word "item2"
                        var wordIndex = text.IndexOf(sWord.Trim(), posStart);

                        //Check if delete " item2" or space charactor in "item2"
                        var bDeleteItem = false;
                        if (e.KeyCode == Keys.Back)
                        {
                            //Back
                            if (pos == posStart)
                            {
                                //Do nothing
                                e.SuppressKeyPress = true;
                                return;
                            }

                            bDeleteItem = iSelectionStart > wordIndex && iSelectionStart <= wordIndex + sWord.Length;
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

                            bDeleteItem = iSelectionStart >= wordIndex && iSelectionStart < wordIndex + sWord.Length;
                        }

                        if (bDeleteItem)
                        {
                            var firstPart = text.Substring(0, posStart).TrimStart();
                            //if (!string.IsNullOrWhiteSpace(firstPart))
                            //    firstPart = firstPart.TrimEnd(';');

                            var lastPart = text.Substring(posEnd, text.Length - posEnd).TrimStart(';');
                            //if (!string.IsNullOrWhiteSpace(lastPart))
                            //    lastPart = lastPart.TrimStart(';');

                            var updatedText = firstPart.TrimEnd(';') + ";" + lastPart.TrimStart(';');
                            if (string.IsNullOrWhiteSpace(firstPart) || string.IsNullOrWhiteSpace(lastPart))
                                updatedText = firstPart + lastPart;

                            Text = updatedText.TrimStart();
                            _formerValue = Text;

                            if (e.KeyCode == Keys.Back)
                                SelectionStart = firstPart.Length;
                            else
                                SelectionStart = Text.Length - lastPart.Length + 1;

                            //Delete item value
                            m_lstStringValues.RemoveAt(arrSplitString.Length - 1);

                            e.SuppressKeyPress = true;
                        }

                        //Delete space in " item2"
                    }

                    break;
            }
        }

        private void ListSuggestion_Click(object sender, EventArgs e)
        {
            //Application.DoEvents();
            GetValueFromListSuggestion();

            //this.Focus();
        }

        private string GetFieldValue(object item, Type objectType, string fieldName)
        {
            var fieldValue = "";
            var pi = objectType.GetProperty(fieldName);
            if (pi != null)
            {
                fieldValue = pi.GetValue(item, null).ToString();
            }
            else
            {
                var fi = objectType.GetField(fieldName);
                if (fi != null) fieldValue = fi.GetValue(item).ToString();
            }

            return fieldValue;
        }

        private List<string> FindRelationObjects(string word)
        {
            var lstDisplay = new List<string>();
            m_lstListBoxSources = new List<object>();

            if (m_lstDataSources.Count < 1)
                return lstDisplay;

            //Source is string
            if (m_lstDataSources[0] is string)
            {
                foreach (var item in m_lstDataSources)
                {
                    var strValue = (string) item;
                    if (strValue.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        m_lstListBoxSources.Add(strValue);
                        lstDisplay.Add(strValue);
                    }

                    if (lstDisplay.Count > 20) break;
                }
            }
            else
            {
                var objectType = m_lstDataSources[0].GetType();
                foreach (var item in m_lstDataSources)
                {
                    //Get property's value as DisplayMember
                    var strItemDisplay = GetFieldValue(item, objectType, DisplayMember);

                    //For detail
                    if (ObjectAsUser)
                    {
                        //Get property's value as ValueMember, display format as "Login Name <login id>"
                        var strValue = GetFieldValue(item, objectType, ValueMember);
                        strItemDisplay = $"{strValue} ({strItemDisplay})";
                        //if (!strItemDisplay.Equals(strValue, StringComparison.OrdinalIgnoreCase))
                        //    strItemDisplay += " <" + strValue + ">";
                    }

                    if (strItemDisplay.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        m_lstListBoxSources.Add(item);
                        lstDisplay.Add(strItemDisplay);
                    }

                    if (lstDisplay.Count > 20) break;
                }
            }

            return lstDisplay;
        }

        private void UpdateListBox()
        {
            if (Text != _formerValue)
            {
                _formerValue = Text;
                var word = GetWord();

                if (word.Length > 0)
                {
                    var strSearchText = word.TrimStart();

                    if (word.Length > 1 && string.IsNullOrWhiteSpace(word))
                        strSearchText = word;

                    var lstDisplayItems = FindRelationObjects(strSearchText);

                    if (lstDisplayItems.Count > 0)
                    {
                        BuildListBox();
                        _ListSuggestion.Visible = true;


                        _ListSuggestion.Items.Clear();
                        foreach (var item in lstDisplayItems) _ListSuggestion.Items.Add(item);

                        _ListSuggestion.SelectedIndex = 0;

                        _ListSuggestion.Height = 0;
                        _ListSuggestion.Width = 0;
                        //this.Focus();
                        using (var graphics = _ListSuggestion.CreateGraphics())
                        {
                            for (var i = 0; i < _ListSuggestion.Items.Count; i++)
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

        private string GetWord()
        {
            var text = Text;
            var pos = SelectionStart;

            var posStart = text.LastIndexOf(';', pos < 1 ? 0 : pos - 1);
            posStart = posStart == -1 ? 0 : posStart + 1;
            var posEnd = text.IndexOf(';', pos);
            posEnd = posEnd == -1 ? text.Length : posEnd;

            var length = posEnd - posStart < 0 ? 0 : posEnd - posStart;

            return text.Substring(posStart, length);
        }

        private void InsertWord(string newTag)
        {
            var text = Text;
            var pos = SelectionStart;

            var posStart = text.LastIndexOf(';', pos < 1 ? 0 : pos - 1);

            posStart = posStart == -1 ? 0 : posStart + 1;
            var posEnd = text.IndexOf(';', pos);

            var firstPart = (text.Substring(0, posStart) + " " + newTag).TrimStart();

            var updatedText = firstPart + (posEnd == -1 ? "" : text.Substring(posEnd, text.Length - posEnd));


            Text = updatedText;
            _formerValue = Text;
            SelectionStart = firstPart.Length;

            Focus();
            OnValueChanged();
        }

        private void InitializeComponent()
        {
            _ListSuggestion = new ListBox();
            SuspendLayout();
            // 
            // _ListSuggestion
            // 
            _ListSuggestion.Location = new Point(0, 0);
            _ListSuggestion.Name = "_ListSuggestion";
            _ListSuggestion.Size = new Size(120, 96);
            _ListSuggestion.TabIndex = 0;
            _ListSuggestion.Click += ListSuggestion_Click;
            // 
            // AutoCompleteTextBox
            // 
            TextChanged += AutoCompleteTextBox_TextChanged;
            KeyDown += AutoCompleteTextBox_KeyDown;
            KeyPress += AutoCompleteTextBox_KeyPress;
            KeyUp += AutoCompleteTextBox_KeyUp;
            Validated += AutoCompleteTextBox_Validated;
            ResumeLayout(false);
        }

        private void AutoCompleteTextBox_TextAlignChanged(object sender, EventArgs e)
        {
        }

        private void AutoCompleteTextBox_Validated(object sender, EventArgs e)
        {
        }

        public string GetValueDescription()
        {
            if (m_lstDataSources.Count < 1) return "";
            var strText = "";
            var arrValue = Text.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var itemID in arrValue)
            {
                var objectType = m_lstDataSources[0].GetType();
                foreach (var item in m_lstDataSources)
                    if (GetFieldValue(item, objectType, DisplayMember)
                        .Equals(itemID.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        //Get property's value as DisplayMember
                        strText += GetFieldValue(item, objectType, ValueMember) + "; ";

                        break;
                    }
            }

            return strText.Trim(';', ' ');
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
    }
}
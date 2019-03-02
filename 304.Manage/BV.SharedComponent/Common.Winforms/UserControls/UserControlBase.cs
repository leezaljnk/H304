﻿using System;
using System.Windows.Forms;

namespace Common.Winforms.UserControls
{
    public partial class UserControlBase : UserControl
    {
        public delegate void CloseView(string viewName);

        public CloseView OnCloseView;

        public UserControlBase()
        {
            InitializeComponent();
        }

        public event KeyEventHandler KeyPreviewEventHandler;

        protected override bool ProcessKeyPreview(ref Message m)
        {
            const int WM_KEYDOWN = 0x100;
            const int WM_CHAR = 0x102;
            const int WM_SYSCHAR = 0x106;
            const int WM_SYSKEYDOWN = 0x104;
            const int WM_IME_CHAR = 0x286;

            KeyEventArgs e = null;

            if (m.Msg != WM_CHAR && m.Msg != WM_SYSCHAR && m.Msg != WM_IME_CHAR)
            {
                e = new KeyEventArgs((Keys) (int) (long) m.WParam | ModifierKeys);
                if (m.Msg == WM_KEYDOWN || m.Msg == WM_SYSKEYDOWN)
                    if (e.KeyCode == Keys.Enter)
                        base.ProcessTabKey(true);

                KeyPreviewEventHandler?.Invoke(this, e);

                if (e.Handled) return e.Handled;
            }

            return base.ProcessKeyPreview(ref m);
        }

        public void HandleException(Exception ex)
        {
            Cursor = Cursors.Default;
            CommonFunction.WriteLog(Text+": "+ex.Message);
            MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void HandleException(string message)
        {
            Cursor = Cursors.Default;
            CommonFunction.WriteLog(Text + ": " + message);
            MessageBox.Show(this, message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
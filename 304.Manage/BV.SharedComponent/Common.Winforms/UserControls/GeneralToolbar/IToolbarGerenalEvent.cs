using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Winforms.UserControls.GeneralToolbar
{
    public interface IToolbarGerenalEvent
    {
        void OnAdd();
        void OnEdit();
        void OnDelete();
        void OnSave();
        void OnCancel();
        void OnPrint();
        void OnSearch();
        void OnHelp();
        void OnClose();
        void OnRefresh();        
    }
}

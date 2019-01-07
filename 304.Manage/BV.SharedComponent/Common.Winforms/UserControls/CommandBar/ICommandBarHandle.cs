using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Winforms.UserControls.CommandBar
{
    public interface ICommandBarHandle
    {
        void OnSave();
        void OnDelete();
        void OnRefresh();
        void OnClose();
        void OnHelp();
        void OnSearch();
    }
}

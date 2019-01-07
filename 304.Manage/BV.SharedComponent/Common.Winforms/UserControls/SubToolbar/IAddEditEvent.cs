using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Winforms.UserControls.SubToolbar
{
    public interface IAddEditEvent
    {
        void OnAdd();
        void OnEdit();
        void OnSave();
        void OnDelete();
        void OnRefresh();
        void OnClose();
        void OnHelp();
        void OnSearch();
        void OnPrint();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Winforms.UserControls.CatalogToolbar
{
    public interface IToolbarCatalogEvent
    {
        void OnAdd();
        void OnEdit();
        void OnDelete();        
        void OnPrint();
        void OnSearch();
        void OnHelp();
        void OnClose();
        void OnRefresh();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Winforms.UserControls.AddRemoveCommand
{
    public interface IAddRemoveEvent
    {
        void OnAdd();
        void OnRemove();
    }
}

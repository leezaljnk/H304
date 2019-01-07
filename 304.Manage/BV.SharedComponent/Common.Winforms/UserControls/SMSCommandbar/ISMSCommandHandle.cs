using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Winforms.UserControls.SMSCommandbar
{
    public interface ISMSCommandHandle
    {
        void OnSave();
        void OnSMS();
        void OnSwicth();
        void OnClose();
        void OnSearch();
    }
}

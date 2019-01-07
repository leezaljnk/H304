using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Winforms
{
    public enum KEYVALUE : int
    {
        HELP = 112, //F1
        ADDNEW = 113, //F2
        EDIT = 114, //F3
        DELETE = 115, //F4
        SAVE = 116, //F5
        CANCEL = 117,//F6
        SEARCH = 118,//F7
        PRINT = 119,//F8
        EXIT = 121,//F10
        ENTER = 13,
        REFRESH = 120 // F9
    }
    public enum ActionTypes : int
    {
        Nostatus = 0,
        Insert = 1,
        Update = 2,
        Delete = 3,
        Refresh = 4,
        PrintOnly = 5,
        EditOnly = 6,
        CloseOnly = 7,
        SearchOnly = 8,
        ReadOnly = 9,
        AddOnly = 10,
        AddAndBrowse = 11,
        Start = 12,
        RefreshInEditMode = 13
    }

    public class NgayThangNam
    {
        public int? Ngay { get; set; }
        public int? Thang { get; set; }
        public int? Nam { get; set; }

        public NgayThangNam()
        {
           
        }
        public NgayThangNam(int? ngay, int? thang, int? nam)
        {
            Ngay = ngay;
            Thang = thang;
            Nam = nam;
        }
        public string ToNgayThangNam()
        {
            string value = "{0}/{1}/{2}";
            value = string.Format(value, (Ngay == null ? string.Empty : Ngay.Value.ToString()).PadRight(2, ' '),
                (Thang == null ? string.Empty : Thang.Value.ToString()).PadRight(2, ' '),
                (Nam == null ? string.Empty : Nam.Value.ToString()).PadRight(4, ' '));
            return value;
        }
    }
    public static class CONSTANT
    {
        public const string BUTTON_ADDNEW = "btnAddNew";
        public const string BUTTON_EDIT = "btnEdit";
        public const string BUTTON_DELETE = "btnDelete";
        public const string BUTTON_SAVE = "btnSave";
        public const string BUTTON_CANCEL = "btnCancel";
        public const string BUTTON_SEARCH = "btnSearch";
        public const string BUTTON_PRINT = "btnPrint";

        public const string POPUP_SAVED = "IsPopUpSaved";
        public const string POPUP_ADD = "PopUpAdd";
        public const string IS_LOAD_DATA = "NeedLoadData";
    }

    public enum ActionMethod : int
    {
        ADDNEW = 1,
        EDIT = 2,
        DELETE = 3,
        SAVE = 4,
        CANCEL = 5
    }
    public enum ROLETYPES
    {
        Admin = 1,
        Modify = 2,
        View = 3,
        Only = 4,
    }
}

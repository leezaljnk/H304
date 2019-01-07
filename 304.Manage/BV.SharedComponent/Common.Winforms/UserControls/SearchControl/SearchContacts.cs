using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Winforms.UserControls.SearchControl
{
    public class ColumnFilter
    {
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public string Description { get; set; }
        public string Lookup { get; set; }
        public bool? IsBrowse { get; set; }
    }

    public class Operators
    {
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public string MethodCall { get; set; }
    }

    public class Rule
    {
        public int OperatorId { get; set; }
        public int DataTypeGroupId { get; set; }
    }

    public class DataType
    {
        public string DataTypeId { get; set; }
        public int DataTypeGroupId { get; set; }
    }

    public class DataTypeGroup
    {
        public int DataTypeGroupId { get; set; }
        public string Description { get; set; }
    }

    public class LookupType
    {
        public string ItemDisplay { get; set; }
        public string ItemValue { get; set; }
    }

    public class FieldExpression
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public string Value { get; set; }
        public bool IsOr { get; set; }
        public string Operator { get; set; }
    }
}

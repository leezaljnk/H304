using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;

namespace Common.Winforms
{
    public static class Converter
    {
        #region "Funtions Converter"
        public static string Encrypt(string input)
        {
            try
            {
                byte[] encrypt = new byte[input.Length];
                encrypt = Encoding.UTF8.GetBytes(input);
                return Convert.ToBase64String(encrypt);
            }
            catch
            {
                return input;
            }
        }
        public static string Decrypt(string input)
        {
            try
            {
                byte[] decrypt = Convert.FromBase64String(input);

                Decoder decoder = new UTF8Encoding().GetDecoder();
                char[] decodedChars = new char[decoder.GetCharCount(decrypt, 0, decrypt.Length)];
                decoder.GetChars(decrypt, 0, decrypt.Length, decodedChars, 0);
                return new String(decodedChars);
            }
            catch
            {
                return input;
            }
        }
        public static string StandardString(string strInput)
        {
            strInput = strInput.Trim().ToLower();
            while (strInput.Contains("  "))
                strInput = strInput.Replace("  ", " ");
            string strResult = "";
            string[] arrResult = strInput.Split(' ');
            foreach (string item in arrResult)
                strResult += item.Substring(0, 1).ToUpper() + item.Substring(1) + " ";
            return strResult.TrimEnd();
        }
        public static byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }
        /// <summary>
        /// Converter string to DateTime
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns></returns>
        public static DateTime? Obj2Date(object strDate)
        {
            if (strDate == null) return null;
            DateTime retVal = DateTime.Today;
            if (DateTime.TryParse(strDate.ToString(), out retVal))
            {
                if (retVal < (new DateTime(1900, 1, 1)) || retVal > (new DateTime(2100, 12, 31))) return null;
                return retVal;
            }
            return null;
        }
        public static DateTime Obj2DateTime(object strDate)
        {
            if (strDate == null) return DateTime.MinValue;
            DateTime retVal = DateTime.Today;
            if (DateTime.TryParse(strDate.ToString(), out retVal))
            {
                if (retVal < (new DateTime(1900, 1, 1)) || retVal > (new DateTime(2100, 12, 31))) return new DateTime(1900, 1, 1);
                return retVal;
            }
            return new DateTime(1900, 1, 1);
        }

        public static DateTime Obj2DateNoTime(object strDate)
        {
            if (strDate == null)
                return new DateTime(DateTime.MinValue.Year, DateTime.MinValue.Month, DateTime.MinValue.Day, 0, 0, 0, 0);
            DateTime retVal = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0, 0);
            if (DateTime.TryParse(strDate.ToString(), out retVal))
            {
                if (retVal < (new DateTime(1900, 1, 1, 0, 0, 0, 0)) || retVal > (new DateTime(2100, 12, 31, 0, 0, 0, 0)))
                    return new DateTime(1900, 1, 1, 0, 0, 0, 0);
                return new DateTime(retVal.Year, retVal.Month, retVal.Day, 0, 0, 0, 0);
            }
            return new DateTime(1900, 1, 1, 0, 0, 0, 0);
        }
        /// <summary>
        /// Validation input value
        /// </summary>
        /// <param name="inputVal"></param>
        /// <param name="minputVal"></param>
        /// <param name="maxVal"></param>
        /// <returns></returns>
        public static int? CheckValueInt(string inputVal, int minVal, int maxVal)
        {
            if (inputVal == null) return null;
            int retVal = 0;
            if (int.TryParse(inputVal.ToString(), out retVal))
            {
                if (retVal < minVal || retVal > maxVal) return null;
                return retVal;
            }
            return null;
        }
        /// <summary>
        /// Validation input value
        /// </summary>
        /// <param name="inputVal"></param>
        /// <param name="minputVal"></param>
        /// <param name="maxVal"></param>
        /// <returns></returns>
        public static bool CheckValueDecimal(string inputVal, Decimal minVal, Decimal maxVal)
        {
            if (inputVal == null) return false;
            decimal retVal = 0;
            if (decimal.TryParse(inputVal.ToString(), out retVal))
            {
                if (retVal < minVal || retVal > maxVal) return false;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Lam tron so
        /// </summary>
        /// <param name="format">
        /// Dinh dang lam tron so N0, N1,...
        /// </param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundDecimal(string format, decimal value)
        {
            decimal res = 0;
            if (format == string.Empty || !format.StartsWith("N")) return value;
            string num = format.Substring(1);
            if (obj2Int(num) == null) return value;
            res = Decimal.Round(value, Obj2Int(num));
            return res;
        }
        /// <summary>
        /// Trong C# không thể dùng hàm Round làm tròn vì có thể sai: Ví dụ: Round(7.25,1)=7.2 phải là 7.3 mới đúng
        /// </summary>
        /// <param name="value"></param>
        /// <param name="format">Dinh dang lam tron so N0, N1,...</param>
        /// <returns></returns>
        public static decimal RoundDecimal(decimal value, string format)
        {
            decimal res = 0;
            if (format == string.Empty || !format.StartsWith("N")) return value;
            string num = format.Substring(1);
            if (obj2Int(num) == null) return value;
            res = Decimal.Parse(value.ToString(format));
            return res;
        }
        /// <summary>
        /// Converter Int to String
        /// </summary>
        /// <param name="inputVal"></param>
        /// <returns></returns>
        public static string Int2String(int? inputVal)
        {
            return (inputVal.HasValue ? inputVal.ToString() : string.Empty);
        }

        /// <summary>
        /// Converter Int32 to String
        /// </summary>
        /// <param name="inputVal"></param>
        /// <returns></returns>
        public static string Int32toString(Int32? inputVal)
        {
            return (inputVal.HasValue ? inputVal.ToString() : string.Empty);
        }

        /// <summary>
        /// Converter String to Double
        /// </summary>
        /// <param name="objInput"></param>
        /// <returns></returns>
        public static double? String2DouBle(object objInput)
        {
            if (objInput == null || objInput.ToString() == string.Empty) return null;
            double retVal = 0;
            if (double.TryParse(objInput.ToString(), out retVal))
                return retVal;
            return null;
        }

        public static decimal? String2Decimal(object objInput)
        {
            if (objInput == null || objInput.ToString() == string.Empty) return null;
            decimal retVal = 0;
            if (decimal.TryParse(objInput.ToString(), out retVal))
                return retVal;
            return null;
        }

        /// <summary>
        /// Converter Int64 to String
        /// </summary>
        /// <param name="inputVal"></param>
        /// <returns></returns>
        public static string Int64toString(Int64? inputVal)
        {
            return (inputVal.HasValue ? inputVal.ToString() : string.Empty);
        }

        /// <summary>
        /// Converter object to string
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Obj2String(object obj)
        {
            return ((obj != null) ? obj.ToString() : string.Empty);
        }
        /// <summary>
        /// Converter object to string
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string obj2String(object obj)
        {
            return ((obj != null) ? obj.ToString() : null);
        }

        /// <summary>
        /// Converter Object to int
        /// </summary>
        /// <param name="objInput"></param>
        /// <returns></returns>
        public static int? obj2Int(object objInput)
        {
            if (objInput == null || objInput.ToString().Trim() == string.Empty) return null;
            int retVal = 0;
            if (int.TryParse(objInput.ToString(), out retVal))
                return retVal;
            return null;
        }
        /// <summary>
        /// Converter Object to int
        /// </summary>
        /// <param name="objInput"></param>
        /// <returns></returns>
        public static int Obj2Int(object objInput)
        {
            if (objInput == null || objInput.ToString().Trim() == string.Empty) return 0;
            int retVal = 0;
            int.TryParse(objInput.ToString(), out retVal);
            return retVal;
        }
        /// <summary>
        /// Converter Object to Short
        /// </summary>
        /// <param name="objInput"></param>
        /// <returns></returns>
        public static short? obj2Short(object objInput)
        {
            if (objInput == null || objInput.ToString().Trim() == string.Empty) return null;
            short retVal = 0;
            if (short.TryParse(objInput.ToString(), out retVal))
                return retVal;
            return null;
        }
        public static short Obj2Short(object objInput)
        {
            if (objInput == null || objInput.ToString().Trim() == string.Empty) return 0;
            short retVal = 0;
            short.TryParse(objInput.ToString(), out retVal);
            return retVal;
        }
        /// <summary>
        /// Converter Object to Int32
        /// </summary>
        /// <param name="objInput"></param>
        /// <returns></returns>
        public static Int32? obj2Int32(object objInput)
        {
            if (objInput == null || objInput.ToString().Trim() == string.Empty) return null;
            Int32 retVal = 0;
            if (Int32.TryParse(objInput.ToString(), out retVal))
                return retVal;
            return null;
        }
        /// <summary>
        /// Converter Object to Int64
        /// </summary>
        /// <param name="objInput"></param>
        /// <returns></returns>
        public static Int64? obj2Int64(object objInput)
        {
            if (objInput == null || objInput.ToString().Trim() == string.Empty) return null;
            Int64 retVal = 0;
            if (Int64.TryParse(objInput.ToString(), out retVal))
                return retVal;
            return null;
        }
        /// <summary>
        /// Converter Object to Int64
        /// </summary>
        /// <param name="objInput"></param>
        /// <returns></returns>
        public static Int64 Obj2Int64(object objInput)
        {
            Int64 retVal = 0;
            if (objInput == null || objInput.ToString().Trim() == string.Empty) return retVal;

            if (Int64.TryParse(objInput.ToString(), out retVal))
                return retVal;
            return retVal;
        }
        public static DataTable IListToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
        /// <summary>
        /// Converter Object to bool
        /// </summary>
        /// <param name="objInput"></param>
        /// <returns></returns>
        public static bool obj2Bool(object objInput)
        {
            if (objInput == null) return false;
            bool retVal = false;
            bool.TryParse(objInput.ToString(), out retVal);
            return retVal;
        }
        /// <summary>
        /// Converter Object to decimal
        /// </summary>
        /// <param name="objInput"></param>
        /// <returns></returns>
        public static decimal? obj2decimal(object objInput)
        {
            if (objInput == null || objInput.ToString().Trim() == string.Empty) return null;
            decimal retVal = 0.0M;
            if (decimal.TryParse(objInput.ToString(), out retVal))
                return retVal;
            return null;
        }
        /// <summary>
        /// Converter Object to decimal
        /// </summary>
        /// <param name="objInput"></param>
        /// <returns></returns>
        public static decimal Obj2decimal(object objInput)
        {
            if (objInput == null || objInput.ToString().Trim() == string.Empty) return 0.0M;
            decimal retVal = 0.0M;
            decimal.TryParse(objInput.ToString(), out retVal);
            return retVal;
        }

        /// <summary>
        /// Converter Object to double
        /// </summary>
        /// <param name="objInput"></param>
        /// <returns></returns>
        public static double? obj2double(object objInput)
        {
            if (objInput == null || objInput.ToString().Trim() == string.Empty) return null;
            double retVal = 0.0;
            if (double.TryParse(objInput.ToString(), out retVal))
                return retVal;
            return null;
        }
        public static double Obj2double(object objInput)
        {
            if (objInput == null || objInput.ToString().Trim() == string.Empty) return 0.0;
            double retVal = 0.0;
            if (double.TryParse(objInput.ToString(), out retVal))
                return retVal;
            return 0.0;
        }
        public static Guid Obj2Guid(object objInput)
        {
            try
            {
                return new Guid(objInput.ToString());
            }
            catch (Exception)
            {
                return Guid.Empty;
            }
        }

        public static Guid? obj2Guid(object objInput)
        {
            try
            {
                return new Guid(objInput.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        public static string convertDate2String(DateTime date)
        {

            string month = date.Month.ToString();
            string day = date.Day.ToString();
            if (month.Length == 1)
                month = "0" + month;
            if (day.Length == 1)
                day = "0" + day;

            return date.Year.ToString() + month + day;
        }
        public static string Decimal2String(object input, int decimalLength)
        {
            decimal val = Obj2decimal(input);
            if (val > 0)
            {
                string format = "N0" + decimalLength;
                return val.ToString(format);
            }
            else return string.Empty;

            //try
            //{
            //    if (decimalLength == 0)
            //    {
            //        //result = input.ToString
            //        result = String.Format("{0:0}", input);
            //    }
            //    else
            //    {
            //        string format = "{0:0.}";
            //        for (int i = 0; i < decimalLength; i++)
            //            format = format.Insert(5, "#");
            //        result = String.Format(format, input);
            //    }
            //    if (result == "0") result = String.Empty;
            //    return result;
            //}
            //catch
            //{
            //    return String.Empty;
            //}
        }
        public static string convertAMPM(string hour, string AmPm)
        {
            switch (AmPm)
            {
                case "AM":
                    return hour;
                case "SA":
                    return hour;
                case "CH":
                    switch (hour)
                    {
                        case "1":
                            return "13";
                        case "2":
                            return "14";
                        case "3":
                            return "15";
                        case "4":
                            return "16";
                        case "5":
                            return "17";
                        case "6":
                            return "18";
                        case "7":
                            return "19";
                        case "8":
                            return "20";
                        case "9":
                            return "21";
                        case "10":
                            return "22";
                        case "11":
                            return "23";
                        case "12":
                            return "24";
                        default:
                            break;
                    }
                    break;
                case "PM":
                    switch (hour)
                    {
                        case "1":
                            return "13";
                            break;
                        case "2":
                            return "14";
                            break;
                        case "3":
                            return "15";
                            break;
                        case "4":
                            return "16";
                            break;
                        case "5":
                            return "17";
                            break;
                        case "6":
                            return "18";
                            break;
                        case "7":
                            return "19";
                            break;
                        case "8":
                            return "20";
                            break;
                        case "9":
                            return "21";
                            break;
                        case "10":
                            return "22";
                            break;
                        case "11":
                            return "23";
                            break;
                        case "12":
                            return "24";
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            return hour;
        }               
       
        public static decimal TruncateFunction(decimal number, int digits)
        {
            decimal stepper = (decimal)(Math.Pow(10.0, (double)digits));
            int temp = (int)(stepper * number);
            return (decimal)temp / stepper;
        }
        
        /// <summary>


        #endregion
        public static bool ByteArray2File(string _FileName, byte[] _ByteArray)
        {
            try
            {
                System.IO.FileStream _fileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                _fileStream.Write(_ByteArray, 0, _ByteArray.Length);
                _fileStream.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
    public static class CountChar
    {
        public static int CharCount(String strSource, String strToCount)
        {
            int iCount = 0;
            int iPos = strSource.IndexOf(strToCount);
            while (iPos != -1)
            {
                iCount++;
                strSource = strSource.Substring(iPos + 1);
                iPos = strSource.IndexOf(strToCount);
            }
            return iCount;
        }
    }
    public static class CheckEmail
    {
        public static bool IsEmail(string Email)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(Email))
                return (true);
            else
                return (false);
        }
    }
    public class DateDifference
    {
        /// <summary>
        /// defining Number of days in month; index 0=> january and 11=> December
        /// february contain either 28 or 29 days, that's why here value is -1
        /// which wil be calculate later.
        /// </summary>
        private int[] monthDay = new int[12] { 31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        /// <summary>
        /// contain from date
        /// </summary>
        private DateTime fromDate;

        /// <summary>
        /// contain To Date
        /// </summary>
        private DateTime toDate;

        /// <summary>
        /// this three variable for output representation..
        /// </summary>
        private int year;
        private int month;
        private int day;

        public DateDifference(DateTime d1, DateTime d2)
        {
            int increment;

            if (d1 > d2)
            {
                this.fromDate = d2;
                this.toDate = d1;
            }
            else
            {
                this.fromDate = d1;
                this.toDate = d2;
            }

            /// 
            /// Day Calculation
            /// 
            increment = 0;

            if (this.fromDate.Day > this.toDate.Day)
            {
                increment = this.monthDay[this.fromDate.Month - 1];

            }
            /// if it is february month
            /// if it's to day is less then from day
            if (increment == -1)
            {
                if (DateTime.IsLeapYear(this.fromDate.Year))
                {
                    // leap year february contain 29 days
                    increment = 29;
                }
                else
                {
                    increment = 28;
                }
            }
            if (increment != 0)
            {
                day = (this.toDate.Day + increment) - this.fromDate.Day;
                increment = 1;
            }
            else
            {
                day = this.toDate.Day - this.fromDate.Day;
            }

            ///
            ///month calculation
            ///
            if ((this.fromDate.Month + increment) > this.toDate.Month)
            {
                this.month = (this.toDate.Month + 12) - (this.fromDate.Month + increment);
                increment = 1;
            }
            else
            {
                this.month = (this.toDate.Month) - (this.fromDate.Month + increment);
                increment = 0;
            }

            ///
            /// year calculation
            ///
            this.year = this.toDate.Year - (this.fromDate.Year + increment);

        }

        public override string ToString()
        {
            //return base.ToString();
            return this.year + " Year(s), " + this.month + " month(s), " + this.day + " day(s)";
        }

        public int Years
        {
            get
            {
                return this.year;
            }
        }

        public int Months
        {
            get
            {
                return this.month;
            }
        }

        public int Days
        {
            get
            {
                return this.day;
            }
        }

    }

    public static class DataConverter
    {
        public static DataTable ConvertToDataTable<T>(IList<T> obj)
        //where T:EntityObject
        {
            PropertyDescriptorCollection properties =
           TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();
            foreach (PropertyDescriptor pInfo in properties)
            {
                // Create a column in the DataTable for the property
                DataColumn column = new DataColumn(pInfo.Name, Nullable.GetUnderlyingType(pInfo.PropertyType) ?? pInfo.PropertyType);
                //column.DataType = Nullable.GetUnderlyingType(pInfo.PropertyType) ?? pInfo.PropertyType;
                table.Columns.Add(column);
            }

            foreach (T item in obj)
            {
                DataRow row = table.NewRow();
                // Iterate again on all the entities' properties
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }        
    }
    public class DataTableModify
    {
        /// <summary>
        /// Select Distinct field in datatable
        /// </summary>
        /// <param name="SourceTable">SourceTable</param>
        /// <param name="FieldNames">FieldNames</param>
        /// <returns>new DataTable</returns>
        public static DataTable SelectDistinct(DataTable SourceTable, params string[] FieldNames)
        {
            object[] lastValues;
            DataTable newTable;
            DataRow[] orderedRows;

            if (FieldNames == null || FieldNames.Length == 0)
                throw new ArgumentNullException("FieldNames");

            lastValues = new object[FieldNames.Length];
            newTable = new DataTable();

            foreach (string fieldName in FieldNames)
                newTable.Columns.Add(fieldName, SourceTable.Columns[fieldName].DataType);

            orderedRows = SourceTable.Select("", string.Join(", ", FieldNames));

            foreach (DataRow row in orderedRows)
            {
                if (!fieldValuesAreEqual(lastValues, row, FieldNames))
                {
                    newTable.Rows.Add(createRowClone(row, newTable.NewRow(), FieldNames));

                    setLastValues(lastValues, row, FieldNames);
                }
            }

            return newTable;
        }

        private static bool fieldValuesAreEqual(object[] lastValues, DataRow currentRow, string[] fieldNames)
        {
            bool areEqual = true;

            for (int i = 0; i < fieldNames.Length; i++)
            {
                if (lastValues[i] == null || !lastValues[i].Equals(currentRow[fieldNames[i]]))
                {
                    areEqual = false;
                    break;
                }
            }

            return areEqual;
        }

        private static DataRow createRowClone(DataRow sourceRow, DataRow newRow, string[] fieldNames)
        {
            foreach (string field in fieldNames)
                newRow[field] = sourceRow[field];

            return newRow;
        }

        private static void setLastValues(object[] lastValues, DataRow sourceRow, string[] fieldNames)
        {
            for (int i = 0; i < fieldNames.Length; i++)
                lastValues[i] = sourceRow[fieldNames[i]];
        }
    }
    public static class DateUtility
    {
        public static DateTime LastMonthDate(this DateTime date)
        {
            if (date.Month == 12)
                return date;
            DateTime dt = new DateTime(date.Year, date.Month + 1, 1).AddDays(-1);
            return dt;
        }
        public static DateTime FirstMonthDate(this DateTime date)
        {
            DateTime dt = new DateTime(date.Year, date.Month, 1);
            return dt;
        }
        public static DateTime FirstWeekDate(this DateTime date)
        {
            int iDay = MapDayOfWeek(date.DayOfWeek) - MapDayOfWeek(DayOfWeek.Monday);
            DateTime dt = date.AddDays(-iDay);
            return dt;
        }

        public static DateTime LastWeekDate(this DateTime date)
        {
            int iDay = MapDayOfWeek(DayOfWeek.Sunday) - MapDayOfWeek(date.DayOfWeek);
            DateTime dt = date.AddDays(iDay);
            return dt;
        }

        public static int MapDayOfWeek(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday:
                    return 2;
                case DayOfWeek.Tuesday:
                    return 3;
                case DayOfWeek.Wednesday:
                    return 4;
                case DayOfWeek.Thursday:
                    return 5;
                case DayOfWeek.Friday:
                    return 6;
                case DayOfWeek.Saturday:
                    return 7;
                case DayOfWeek.Sunday:
                    return 8;
                default:
                    return 0;
            }
        }

    }
}

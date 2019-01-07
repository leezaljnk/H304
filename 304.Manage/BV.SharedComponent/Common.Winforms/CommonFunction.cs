using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Common.Winforms
{
    public static class CommonFunction
    {
        //public static void UpdateAppSettingConfig(string key,string new_value)
        //{
        //    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //    if (ConfigurationManager.AppSettings.AllKeys.Contains(key))
        //    {
        //        config.AppSettings.Settings[key].Value = new_value;
        //    }

        //    config.Save(ConfigurationSaveMode.Modified);
        //    ConfigurationManager.RefreshSection("appSettings");
        //}

        //public static string GetAppSettingConfig(string key)
        //{
        //    string val = ConfigurationManager.AppSettings[key];
        //    return val;
        //}
        public static void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        public static byte[] Zip(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }
        public static byte[] ZipObj(object obj)
        {
            using (var memoryStream = new System.IO.MemoryStream())
            {
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(gZipStream, obj);
                }
                return memoryStream.ToArray();
            }
        }
        public static string Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }
        public static T UnzipObject<T>(byte[] bytes)
            where T:class
        {
            T obj;
            using (var mem2 = new MemoryStream(bytes))
            {
                using (var decompressor = new GZipStream(mem2, CompressionMode.Decompress))
                {
                    // The next line will throw SerializationException
                    obj = new BinaryFormatter().Deserialize(decompressor) as T;
                    return obj;
                }
            }
        }

        public static IList<decimal> StringCommon2DecimalList(string content)
        {
            IList<decimal> result = new List<decimal>();
            string[] pars = content.Split(',');
            for (int i = 0; i < pars.Length; i++)
            {
                result.Add(Converter.Obj2decimal(pars[i]));
            }
            return result;
        }

        public static string GetDecimalList2String(IList<decimal> list)
        {
            string value = string.Empty;
            foreach (decimal point in list)
            {
                value += point.ToString() + ",";
            }
            if (value != string.Empty && value.EndsWith(",")) value = value.Substring(0, value.Length - 1);
            return value;
        }
        public static long GetSizeVariable(object variable)
        {
            long size = 0;
            using (Stream s = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(s, variable);
                size = s.Length;
            }
            return size;
        }
        public static SoundPlayer SoundPlayer( string wav)
        {
            SoundPlayer soundPlayer = new System.Media.SoundPlayer(wav);
            soundPlayer.PlayLooping();
            return soundPlayer;
        }

        public static string GetMapImageFolder()
        {
            string imageFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            imageFolder = System.IO.Path.Combine(imageFolder, "4CDTS");
            if (!Directory.Exists(imageFolder))
            {
                Directory.CreateDirectory(imageFolder);
            }
            return imageFolder;
        }

        public static bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }

        public static Color GetAnnotLineColor(decimal temperature, decimal lowTemp, decimal highTemp)
        {
            if (temperature > highTemp)
            {
                temperature = highTemp;
            }

            if (temperature < lowTemp)
            {
                temperature = lowTemp;
            }
            //nowTemp = 30;	# realtime temperature reading
            //lowTemp = 0;		# user setting
            //highTemp = 100;	# user setting

            //nowColorIndex = 4 * (nowT - lowT) / (highT - lowT);
            //n = nowColorIndex;
            //r = 255 * min(max(min(n - 1.5, -n + 4.5), 0), 1);
            //g = 255 * min(max(min(n - 0.5, -n + 3.5), 0), 1);
            //b = 255 * min(max(min(n + 0.5, -n + 2.5), 0), 1);

            //nowColorRGB = (r, g, b)

            decimal nowColorIndex = 4 * (temperature - lowTemp) / (highTemp - lowTemp);
            decimal n = nowColorIndex;
            decimal r = 255 * Math.Min(Math.Max(Math.Min(n - 1.5m, -n + 4.5m), 0), 1);
            decimal g = 255 * Math.Min(Math.Max(Math.Min(n - 0.5m, -n + 3.5m), 0), 1);
            decimal b = 255 * Math.Min(Math.Max(Math.Min(n + 0.5m, -n + 2.5m), 0), 1);

            return Color.FromArgb((int)r, (int)g, (int)b);
        }
        public static string Substring(object str, int startIndex, int length)
        {
            if (str == null) return String.Empty;
            if (str.ToString().Length < length) return str.ToString();
            else return str.ToString().Substring(startIndex, length);
        }

        public static string TachHoVaTen(string fullName, out string hoDem)
        {
            hoDem = string.Empty;
            if (fullName.LastIndexOf(' ') > 0)
            {
                hoDem = fullName.Substring(0, fullName.LastIndexOf(' '));
                return fullName.Substring(fullName.LastIndexOf(' '), fullName.Length - fullName.LastIndexOf(' '));
            }
            else
                return fullName;
        }
        public static bool IsGuid(object str)
        {
            Guid g;
            try
            {
                g = new Guid(str.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsdateTime(object str)
        {
            try
            {
                DateTime date = Convert.ToDateTime(str.ToString());

                return true;

            }
            catch
            {
                return false;
            }
        }

        public static void SetDateValue(this MaskedTextBox mask, DateTime? value)
        {
            if (value == null)
            {
                mask.Text = "";
            }
            else
            {
                mask.Text = value.Value.ToString("dd/MM/yyyy");
            }
        }

        public static void SetDateValue(this MaskedTextBox mask, DateTime? value, string format)
        {
            if (value == null)
            {
                mask.Text = "";
            }
            else
            {
                mask.Text = value.Value.ToString(format);
            }
        }
        public static DateTime? GetDateValue(this MaskedTextBox mask)
        {
            string[] pars = mask.Text.Replace("-","/").Split('/');
            if (pars.Length != 3) return null;
            try
            {
                return new DateTime(Converter.Obj2Int(pars[2]), Converter.Obj2Int(pars[1]), Converter.Obj2Int(pars[0]));
            }
            catch 
            {
                return null;
            }
            
        }
        public static DateTime? GetDateValue(this MaskedTextBox mask, string format)
        {
            string[] pars = mask.Text.Replace("-", "/").Split('/');
            string content = mask.Text.Replace("-", "/");
            try
            {
                return DateTime.ParseExact(content, format, null);
            }
            catch 
            {
                return null;
            }            

        }
        public static NgayThangNam GetNgayThangNam(this MaskedTextBox mask)
        {
            NgayThangNam value = new NgayThangNam();
            string[] pars = mask.Text.Replace("-","/").Split('/');
            if (pars.Length != 3) return null;
            value.Ngay = Converter.obj2Int(pars[0]);
            value.Thang = Converter.obj2Int(pars[1]);
            value.Nam = Converter.obj2Int(pars[2]);
            return value;
        }
        public static void SetDateValue(this MaskedTextBox mask, int? year, int? month, int? day)
        {
            //string value = Converter.Obj2String(day).PadLeft(2, ' ') + "/" + Converter.Obj2String(month).PadLeft(2, ' ') + "/" + Converter.Obj2String(year);
            mask.Text = GetNgaySinh(day, month, year);
        }
        public static void SetDateValue(this MaskedTextBox mask, NgayThangNam value)
        {
            if (value == null) return;
            mask.SetDateValue(value.Nam, value.Thang, value.Ngay);
        }
        /// <summary>
        /// Get ngay sinh theo ngay, thang, nam
        /// </summary>
        /// <param name="ngay"></param>
        /// <param name="thang"></param>
        /// <param name="nam"></param>
        /// <returns></returns>
        public static string GetNgaySinh(int? ngay, int? thang, int? nam)
        {
            string sngay = (ngay == null ||ngay ==0) ? "  " : ((int)ngay).ToString().PadLeft(2, '0');
            string sthang = (thang == null || thang ==0) ? "  " : ((int)thang).ToString().PadLeft(2, '0');
            string snam = (nam == null||nam ==0) ? "  " : ((int)nam).ToString();
            return sngay + "/" + sthang + "/" + snam;
        }

        public static string GetPublicIP()
        {
            string a4 = string.Empty;
            try
            {
                string url = "http://checkip.dyndns.org";
                System.Net.WebRequest req = System.Net.WebRequest.Create(url);
                System.Net.WebResponse resp = req.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                string response = sr.ReadToEnd().Trim();
                string[] a = response.Split(':');
                string a2 = a[1].Substring(1);
                string[] a3 = a2.Split('<');
                a4 = a3[0];
            }
            catch
            {
                return a4;
            }
            return a4;
        }

        public static int GetQuarter(int thang)
        {
            int quarter = 0;
            if (thang <= 3)
                quarter = 1;
            else if (thang <= 6)
                quarter = 2;
            else if (thang <= 9)
                quarter = 3;
            else
                quarter = 4;
            return quarter;
        }
        /// <summary>
        /// Return min thang and out max thang
        /// </summary>
        /// <param name="quy"></param>
        /// <param name="thangMax"></param>
        /// <returns></returns>
        public static int GetThangByQuy(int quy, out int thangMax)
        {
            thangMax = 0;
            int thangMin = 0;
            switch (quy)
            {
                case 1:
                    thangMax = 3;
                    thangMin = 1;
                    break;
                case 2:
                    thangMax = 6;
                    thangMin = 4;
                    break;
                case 3:
                    thangMax = 9;
                    thangMin = 7;
                    break;
                case 4:
                    thangMax = 12;
                    thangMin = 10;
                    break;
                default:
                    thangMax = 3;
                    thangMin = 1;
                    break;
            }
            return thangMin;
        }

        public static void SerializeObject(string filename, System.Type oType, object objectToSerialize)
        {
            TextWriter textWriter = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(oType);
                textWriter = new StreamWriter(filename);
                serializer.Serialize(textWriter, objectToSerialize);

            }
            finally
            {
                if (textWriter != null)
                    textWriter.Close();
            }
        }

        public static object DeSerializeObject(string filename, System.Type oType)
        {
            TextReader textReader = null;
            object oBatch;
            try
            {
                XmlSerializer deserializer = new XmlSerializer(oType);
                textReader = new StreamReader(filename);

                oBatch = deserializer.Deserialize(textReader);
            }
            finally
            {
                if (textReader != null)
                    textReader.Close();
            }

            return oBatch;
        }

        public static string SerializeObjectToString(System.Type oType, object objectToSerialize)
        {
            TextWriter textWriter = null;
            MemoryStream oMemoryStream = new MemoryStream();
            try
            {
                XmlSerializer serializer = new XmlSerializer(oType);
                textWriter = new StreamWriter(oMemoryStream);
                serializer.Serialize(textWriter, objectToSerialize);
                return System.Text.Encoding.UTF8.GetString(oMemoryStream.ToArray());
            }
            finally
            {
                if (textWriter != null)
                    textWriter.Close();
            }
        }

        public static object DeSerializeObjectFromString(string value, System.Type oType)
        {
            TextReader textReader = null;
            object oBatch;
            try
            {
                XmlSerializer deserializer = new XmlSerializer(oType);
                textReader = new StringReader(value);

                oBatch = deserializer.Deserialize(textReader);
            }
            finally
            {
                if (textReader != null)
                    textReader.Close();
            }

            return oBatch;
        }

        public static void WriteLog(string message)
        {
            DateTime dateLog = DateTime.Now;
            string logFolder = Application.StartupPath + "\\Logs";
            string logFile = Application.StartupPath + "\\Logs\\ehr_log" + dateLog.ToString("yyyyMMdd") + ".txt";
            if (!Directory.Exists(logFolder)) Directory.CreateDirectory(logFolder);

            if (!File.Exists(logFile))
            {
                StreamWriter write = File.CreateText(logFile);
                write.WriteLine(dateLog.ToString() + '\t' + message);
                write.Close();
            }
            else
            { File.AppendAllText(logFile, dateLog.ToString() + '\t' + message); }
        }
    }
    public class PopupData
    {
        private string _PrimaryKey;
        public string PrimaryKey
        {
            get { return _PrimaryKey; }
            set { _PrimaryKey = value; }
        }
        private DataTable _DataSource;
        public DataTable DataSource
        {
            get { return _DataSource; }
            set { _DataSource = value; }
        }
        private string _ColumnName;
        public string ColumnName
        {
            get { return _ColumnName; }
            set { _ColumnName = value; }
        }
        private string _FieldName;
        public string FieldName
        {
            get { return _FieldName; }
            set { _FieldName = value; }
        }
        private string _Content;
        public string Content
        {
            get
            {
                if (_Content == null)
                    return string.Empty;
                else
                    return _Content;
            }
            set { _Content = value; }
        }
        public object ReturnValue
        {
            get;
            set;
        }
        public List<string> ReturnValueMultiCheck
        {
            get;
            set;
        }
        public Dictionary<string, object> SecondValue
        {
            get;
            set;
        }
        public int Type
        {
            get;
            set;
        }
        public string ResoucePrefix
        {
            get;
            set;
        }
        public string ViewName
        {
            get;
            set;
        }
        public string SecondReturnField
        {
            get;
            set;
        }
        public string ViewTitle;
    }
}

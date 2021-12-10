using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RSM.BAL.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using ZOI_DAL.Providers.Infrastructure;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static RSM.BAL.Utilities.Constants;

namespace RSM.BAL.Common
{
    public static class CommonFunctions
    {
        private const string
              ReportsUrl = @"BSEStarMFAPI/BSEStarMFServices.DownloadReport",
              PlaceOrderUrl = @"BSEStarMFAPI/BSEStarMFServices.PlaceOrder",
              InvestorDetailsUrl = @"InvestorAPI/InvestorService.DownloadReport",
              UpdateDetailsUrl = @"BSEStarMFAPI/BSEStarMFServices.UpdateMandateRegistration",
               PaymemtStatusUrl = @"BSEStarMFAPI/BSEStarMFExchangeServices.GetExchangeOrderStatus",
              PaymentGateWayUrl = @"BSEStarMFAPI/BSEStarMFExchangeServices.BSEStarMFPaymentGatewayService";

        private static string BaseUrl = "https://ekyc.rupeetracker.in/dhan-apis/services/DhanAdminapis.aspx/";

        //Post method API Call
        public static string postAPI(object json, string URL)
        {
            string response = "";
            try
            {
                var AuthenticateUserURL = BaseUrl + URL;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(AuthenticateUserURL);
                request.Method = "POST";
                request.ContentType = "application/json";
                using (Stream webStream = request.GetRequestStream())
                using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
                {
                    requestWriter.Write(json);
                }

                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    response = responseReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                //StackTrace CallStack = new StackTrace(ex, true);
                //ex.Data["ErrDescription"] = ex.Data["ErrDescription"] != null ? ex.Data["ErrDescription"] : string.Format("Error captured in {0} on Line No {1} of Method {2}", CallStack.GetFrame(0).GetFileName(), CallStack.GetFrame(0).GetFileLineNumber(), CallStack.GetFrame(0).GetMethod().ToString());
                //throw ex;
            }
            return response;
        }

        //Get Api CALL only pass the qurry string
        public static string getAPI(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BaseUrl + uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;



            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }



        #region COMMON

        public static bool LogRequest(string methodName, string requestUrl, string responseXML, Exception exception, string AddedBy, DateTime requestTime, DateTime responseTime)
        {
            Database db;
            StringBuilder _ErrMsg = new StringBuilder();
            bool retval = false;
            try
            {
                if (exception == null)
                {
                    _ErrMsg.Append("Process/Subprocess successful");
                }
                else
                {
                    _ErrMsg.Append("Exception Message: " + exception.Message + ".");
                    _ErrMsg.Append(" Exception StackTrace" + exception.StackTrace + ".");
                }
                SqlParameter[] objParam =
                        {
                            new SqlParameter("@Method", DbType.String){ Value = methodName},
                            new SqlParameter("@RequestUrl", DbType.String) { Value = requestUrl },
                            new SqlParameter("@ResponseXml", DbType.String) { Value = responseXML },
                            new SqlParameter("@Exception", DbType.String) { Value = Convert.ToString(_ErrMsg) },
                            new SqlParameter("@AddedBy", DbType.String) { Value = AddedBy },
                            new SqlParameter("@RequestTime", DbType.DateTime) { Value = requestTime },
                            new SqlParameter("@ResponseTime", DbType.DateTime) { Value = responseTime },
                         };

                int i = new ADODataFunction().ExecuteNonQuery(Procedures.BSESTarMFAPI, objParam);
                retval = i > 0;
            }
            catch (Exception)
            {
                retval = false;
            }
            finally
            {
                db = null;
                _ErrMsg = null;
            }
            return retval;
        }

        public static BSEResponse ExecuteRequest(string url, string json, string methodName, string userName)
        {
            string strresponse = "";
            BSEResponse response = null;
            Exception excep = null;
            List<string> jsonlst = new List<string>();
            DateTime requestTime = DateTime.Now, responseTime = DateTime.Now;
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GetConnectionString("BSEStarMFEndpoint") + url);
                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "POST";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    requestTime = DateTime.Now;
                    if (!string.IsNullOrEmpty(json))
                        streamWriter.Write(json);
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    strresponse = streamReader.ReadToEnd();
                    responseTime = DateTime.Now;
                    if (!string.IsNullOrEmpty(strresponse))
                    {
                        if (methodName == "PaymentGateWayService")
                        {
                            if (strresponse.Contains("html"))
                            {
                                strresponse = Regex.Unescape(Regex.Unescape(strresponse));
                                strresponse = Regex.Replace(strresponse, "<html>", "~<html>").Replace("</html>", "</html>~");
                                jsonlst = strresponse.Split(new char[] { '~' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                                //strresponse = Regex.Replace(strresponse, @"\n", "").Replace("=\"", "='").Replace("\" ", "' ").Replace("\">", "'>").Replace("  ", "");
                                jsonlst[1] = Regex.Replace(jsonlst[1], "\"", "'");
                                strresponse = string.Join("", jsonlst);

                            }

                        }
                        response = new JavaScriptSerializer().Deserialize<BSEResponse>(strresponse);
                        //CommonFunctions.WriteLog2("mf orderbook2 ExecuteRequest", new JavaScriptSerializer().Serialize(response), DateTime.Now, DateTime.Now);
                    }


                    // if (!string.IsNullOrEmpty(strresponse))
                    //  response = new JavaScriptSerializer().Deserialize<BSEResponse>(strresponse);
                }
            }
            catch (Exception ex)
            {
                excep = ex;
                throw;
            }
            finally
            {
                LogRequest(methodName, GetConnectionString("BSEStarMFEndpoint") + url + json, strresponse, excep, userName, requestTime, responseTime);
            }
            return response;
        }

        private static BSEResponse ExecuteGetRequest(string url, string methodName, string userName)
        {
            string strresponse = "";
            BSEResponse response = null;
            Exception excep = null;
            DateTime requestTime = DateTime.Now, responseTime = DateTime.Now;
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(GetConnectionString("BSEStarMFEndpoint") + url);
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    strresponse = streamReader.ReadToEnd();
                    responseTime = DateTime.Now;
                    if (!string.IsNullOrEmpty(strresponse))
                        response = new JavaScriptSerializer().Deserialize<BSEResponse>(strresponse);
                }
            }
            catch (Exception ex)
            {
                excep = ex;
                throw;
            }
            finally
            {
                LogRequest(methodName, GetConnectionString("BSEStarMFEndpoint") + url, strresponse, excep, userName, requestTime, responseTime);
            }
            return response;
        }

        public static List<MutualFunds> ConvertDionToAccordFunds(List<SchemeDetails> dion)
        {
            List<MutualFunds> accord = null;
            try
            {
                if (dion != null && dion.Count > 0)
                {
                    accord = dion.Select(d => new MutualFunds
                    {
                        FUND = d.AmcName,
                        S_NAME = d.SchemeName,
                        SCHEME_NAME = d.SchemeName,
                        LEGALNAME = d.SchemeName,
                        CATEGORY = d.SchemeType,
                        ASSETTYPE = d.SchemeType,
                        SCHEMECODE = Convert.ToInt32(d.Token),
                        AMCCODE = d.AMCCode,
                        MININVT = Convert.ToDouble(d.MinPurAmt),
                        NFO_OPEN = d.StartDate,
                        NFO_CLOSE = d.EndDate
                    }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return accord;
        }


        #endregion

        public static void LogError(Exception excep)
        {
            try
            {
                WriteLog(excep.Source, excep.Message, DateTime.Now, DateTime.Now, excep.StackTrace);
                //if (Constants.ElmahLogError == 1) discuss to tony 
                //{
                    Elmah.ErrorSignal.FromCurrentContext().Raise(excep);
                //}
            }
            catch (Exception)
            {
                /// throw;
            }
        }



        /// <summary>
        /// Get connection string by key from Config.JSON file
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public static string GetConnectionString(string keys)
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(), "Config.json");
            string json = File.ReadAllText(file);
            JObject jsonObject = JObject.Parse(json);
            string jsonValue = jsonObject != null && jsonObject.Count > 0 ? Convert.ToString(jsonObject[keys]) : string.Empty;
            return jsonValue;
        }
        public static void SetConfigValue(string key, string value)
        {
            //string json = HttpContext.Current.Server.MapPath("~/Config.json");
            //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

            //jsonObj= "new password";
            //string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            //File.WriteAllText("settings.json", output);
        }
        /// <summary>
        /// SERIALIZE LIST DATA TO JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lstData"></param>
        /// <returns>STRING ARRAY</returns>
        public static string[] serializeListData<T>(List<T> lstData)
        {
            try
            {
                string[] arr;
                var jsonSerialiser = new JavaScriptSerializer();
                var json = jsonSerialiser.Serialize(lstData);
                arr = new string[] { json };
                return arr;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string GetFriendlyURL(string title)
        {
            if (String.IsNullOrEmpty(title))
                return "";
            // replace spaces with single dash
            title = Regex.Replace(title, @"[\s+\*`~^\+#%&-\.]", "-");
            // if we end up with multiple dashes, collapse to single dash            
            title = Regex.Replace(title, @"\-{2,}", "-");
            // make it all lower case
            title = title.ToLower();
            // remove entities
            title = Regex.Replace(title, @"&\w+;", "");
            // remove anything that is not letters, numbers, dash, or space
            title = Regex.Replace(title, @"[^a-z0-9\-\s@!()$_]", "");
            // replace spaces
            title = title.Replace(' ', '-');
            // collapse dashes
            title = Regex.Replace(title, @"-{2,}", "-");
            // trim excessive dashes at the beginning
            title = title.TrimStart(new[] { '-' });
            // if it's too long, clip it
            if (title.Length > 80)
                title = title.Substring(0, 79);
            // remove trailing dashes
            title = title.TrimEnd(new[] { '-' });
            return title;
        }

        public static string stockGetFriendlyURL(string title)
        {
            if (String.IsNullOrEmpty(title))
                return "";
            // replace spaces with single dash
            title = Regex.Replace(title, @"[\s+\*`~^\+#%&-\.]", "~");
            // if we end up with multiple dashes, collapse to single dash            
            title = Regex.Replace(title, @"\-{2,}", "~");
            // make it all lower case
            title = title.ToLower();
            // remove entities
            // title = Regex.Replace(title, @"&\w+;", "");
            // remove anything that is not letters, numbers, dash, or space
            title = Regex.Replace(title, @"[^a-z0-9\-\s@!()$_]", "~");
            // replace spaces
            title = title.Replace(' ', '~');
            // collapse dashes
            title = Regex.Replace(title, @"-{2,}", "~");
            // trim excessive dashes at the beginning
            title = title.TrimStart(new[] { '~' });
            // if it's too long, clip it
            if (title.Length > 80)
                title = title.Substring(0, 79);
            // remove trailing dashes
            title = title.TrimEnd(new[] { '~' });
            return title;
        }

        /// <summary>
        /// FUNCTION TO CONVERT LIST TO DATA TABLE
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns>DATA TABLE</returns>
        public static DataTable ListtoDataTableConverter<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public static DataTable ListtoTypedDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, prop.PropertyType);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        /// <summary>
        /// Function to convert objects to datatable 
        /// </summary>
        /// <param name="objects"></param>
        /// <returns></returns>
        public static DataTable GetDataTableFromObjects(object[] objects)
        {
            if (objects != null && objects.Length > 0)
            {
                Type t = objects[0].GetType();
                DataTable dt = new DataTable(t.Name);
                foreach (PropertyInfo pi in t.GetProperties())
                {
                    dt.Columns.Add(new DataColumn(pi.Name));
                }
                foreach (var o in objects)
                {
                    DataRow dr = dt.NewRow();
                    foreach (DataColumn dc in dt.Columns)
                    {
                        dr[dc.ColumnName] = o.GetType().GetProperty(dc.ColumnName).GetValue(o, null);
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            return null;
        }

        public static List<T> DataTableToList<T>(DataTable table) where T : class, new()
        {
            List<T> list = new List<T>();
            try
            {
                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();
                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    list.Add(obj);
                }
            }
            catch
            {
                list = null;
            }

            return list;
        }

        //public static string DataTableToJson(DataTable table)
        //{
        //    string s = null;
        //    try
        //    {
        //        /// convert datatable to list using LINQ. Input
        //        var lst = table.AsEnumerable()
        //                    .Select(r => r.Table.Columns.Cast<DataColumn>()
        //                                    .Select(c => new KeyValuePair<string, object>(c.ColumnName, r[c.Ordinal])
        //                           ).ToDictionary(z => z.Key, z => z.Value)
        //                    ).ToList();

        //        /// now serialize it
        //        var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
        //        s = serializer.Serialize(lst);
        //    }
        //    catch (Exception)
        //    {
        //        s = null;
        //    }

        //    return s;
        //}

        public static Dictionary<int, string> EnumDictionary<T>()
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("Type must be an enum");
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .ToDictionary(t =>
                   (int)Convert.ChangeType(t, t.GetType()),
                   t => t.ToString()
                );
        }

        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        public static string Decrypt(string cipherText)
        {
            string DecryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(DecryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public static T DeserializeXML<T>(string xml)
        {
            T obj;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                StringReader stringReader = new StringReader(xml);
                XmlTextReader xmlTextReader = new XmlTextReader(stringReader);
                obj = (T)xmlSerializer.Deserialize(xmlTextReader);
            }
            catch (Exception)
            {
                throw;
            }
            return obj;
        }

        public static string GetIPAddress()
        {
            string IPAddress = "";

            try
            {
                string hostName = Dns.GetHostName(); // Retrive the Name of HOST
                IPAddress = Dns.GetHostByName(hostName).AddressList[0].ToString(); //Retrive IP Address
            }
            catch (Exception)
            {
                throw;
            }

            return IPAddress;
        }

        public static string UnixTimeStampToDateTime(double unixTimeStamp)
        {
            string strDateTime = string.Empty;
            try
            {

                DateTime dtDateTime = new DateTime(1970, 1, 1, 5, 30, 0, 0, System.DateTimeKind.Utc).AddSeconds(unixTimeStamp);
                strDateTime = dtDateTime.ToString("dd/MM/yyyy h:mm tt");
            }
            catch (Exception)
            {
                throw;
            }
            return strDateTime;
        }

        public static void WriteLog(string FunctionName, string Parameters, DateTime Start, DateTime End, string Message = "")
        {
            DateTime TimeStamp = DateTime.UtcNow;
            try
            {
                TimeSpan duration = Start - End;
                string strPath = "RSEC_Logs";
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), strPath)))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), strPath));
                }
                strPath = strPath + "/Logs_" + DateTime.Now.ToString("yyyy_MM");
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), strPath)))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), strPath));
                }
                strPath = strPath + "/LOG_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt";

                string strLog = string.Format("LogTime :- {0}\r\nFunation_Name : {1}\r\nParameters : {2}\r\nStart Time : {3}\r\nEnd : {4}\r\nDuration : {5}\r\nMessage : {6}\r\n\r\n\r\n", DateTime.Now, FunctionName, Parameters, Start, End, duration, Message);
                File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), strPath), strLog);


            }
            catch (Exception)
            {
                //throw exp;
            }
        }



        public static void WriteLog2(string FunctionName, string Parameters, DateTime Start, DateTime End, string Message = "")
        {
            DateTime TimeStamp = DateTime.UtcNow;
            try
            {
                TimeSpan duration = Start - End;
                string strPath = "IPO_Logs";
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), strPath)))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), strPath));
                }
                strPath = strPath + "/Logs_" + DateTime.Now.ToString("yyyy_MM");
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), strPath)))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), strPath));
                }
                strPath = strPath + "/LOG_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt";

                string strLog = string.Format("LogTime :- {0}\r\nFunation_Name : {1}\r\nParameters : {2}\r\nStart Time : {3}\r\nEnd : {4}\r\nDuration : {5}\r\nMessage : {6}\r\n\r\n\r\n", DateTime.Now, FunctionName, Parameters, Start, End, duration, Message);
                File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), strPath), strLog);


            }
            catch (Exception)
            {
                //throw exp;
            }
        }

        public static string ExecuteXMLRequest(string url, string method)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
                req.Method = method;
                req.ContentLength = 0;
                HttpWebResponse Resp = (HttpWebResponse)req.GetResponse();
                Stream respstream = Resp.GetResponseStream();
                StreamReader sr = new StreamReader(respstream);
                Regex reg = new Regex(@"<\?.+\?>");
                string responseReceived = sr.ReadToEnd();
                return reg.Replace(responseReceived, "").Replace("[", "").Replace("]", "").Replace("\"", "");
            }
            catch (WebException)
            {
                throw;
            }
            catch (Exception)
            { throw; }
        }

        public static string GetRequest(string url)
        {
            string strresponse = "";


            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentLength = 0;
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    strresponse = streamReader.ReadToEnd();
                    if (string.IsNullOrEmpty(strresponse))
                        strresponse = string.Empty;
                }
            }
            catch (Exception ex)
            {
                strresponse = string.Empty;
                //WriteLog("Getrequest", "URL:" + url + "\n" + ex.ToString() + "/n" + ex.StackTrace, DateTime.Now, DateTime.Now);
                throw;
            }

            return strresponse;
        }



        public static string SendGetRequest(string url)
        {
            string Response = string.Empty;
            try
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
                req.Method = "GET";
                req.ContentLength = 0;
                HttpWebResponse Resp = (HttpWebResponse)req.GetResponse();
                Stream respstream = Resp.GetResponseStream();
                StreamReader sr = new StreamReader(respstream);
                Regex reg = new Regex(@"<\?.+\?>");
                Response = sr.ReadToEnd();
                //return reg.Replace(responseReceived, "");
                // return responseReceived;
            }
            catch (Exception ex)
            {
                Response = string.Empty;
                //WriteLog("SendGetRequest new cdsl", url, DateTime.Now, DateTime.Now);
            }
            return Response;
        }

        public static string SendPostRequest(string Url, string Request)
        {
            var Response = string.Empty;
            try
            {
                WebRequest tRequest;
                tRequest = WebRequest.Create(Url);
                tRequest.Method = "post";
                tRequest.ContentType = "application/json";// " application/x-www-form-urlencoded;charset=UTF-8"; for plain text

                Byte[] byteArray = Encoding.UTF8.GetBytes(Request);
                tRequest.ContentLength = byteArray.Length;
                Stream dataStream = tRequest.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse tResponse = tRequest.GetResponse();

                dataStream = tResponse.GetResponseStream();
                StreamReader tReader = new StreamReader(dataStream);

                Response = tReader.ReadToEnd();
                tReader.Close();
                dataStream.Close();
                tResponse.Close();

            }
            catch (Exception ex)
            {
                Response = string.Empty;
                //WriteLog("SendPostRequest", Url + "\n" + Request + "\n" + ex.ToString() + "~~" + ex.StackTrace.ToString(), DateTime.Now, DateTime.Now);
            }

            return Response;

        }

        public static List<DateTime> CurrentFinancialYrDate()
        {
            DateTime today = DateTime.Now;
            List<DateTime> dtlst = new List<DateTime>();
            int StartYr, EndYr = 0;
            try
            {
                StartYr = today.Month > 4 ? today.Year : today.Year - 1;
                //EndYr = today.Month > 4 ? today.Year + 1 : today.Year - 1;
                EndYr = StartYr + 1;

                dtlst.Add(new DateTime(StartYr, 4, 1));
                dtlst.Add(new DateTime(EndYr, 3, 31));
            }
            catch (Exception ex)
            {
                dtlst.Clear();
                //WriteLog("CurrentFinancialYrDate", ex.ToString() + "\n" + ex.StackTrace.ToString(), DateTime.Now, DateTime.Now);
            }
            return dtlst;
        }

        // new common log start

        public static void commonlog(string FunctionName, string Parameters, DateTime Start, DateTime End, string path, string Message = "")
        {
            DateTime TimeStamp = DateTime.UtcNow;
            try
            {
                //    string islogprint = RsecBOL.ConnectionStringKeys.islogprint.ToString();
                //    if (islogprint.ToLower() == "yes")
                //    {
                //        TimeSpan duration = Start - End;
                //        string strPath = "~/RSEC_Logs/" + path;
                //        if (!Directory.Exists(HttpContext.Current.Server.MapPath(strPath)))
                //        {
                //            Directory.CreateDirectory(HttpContext.Current.Server.MapPath(strPath));
                //        }
                //        strPath = strPath + "/Logs_" + DateTime.Now.ToString("yyyy_MM");
                //        if (!Directory.Exists(HttpContext.Current.Server.MapPath(strPath)))
                //        {
                //            Directory.CreateDirectory(HttpContext.Current.Server.MapPath(strPath));
                //        }
                //        strPath = strPath + "/LOG_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt";

                //        string strLog = string.Format("LogTime :- {0}\r\nFunation_Name : {1}\r\nParameters : {2}\r\nStart Time : {3}\r\nEnd : {4}\r\nDuration : {5}\r\nMessage : {6}\r\n\r\n\r\n", DateTime.Now, FunctionName, Parameters, Start, End, duration, Message);

                //        File.AppendAllText(HttpContext.Current.Server.MapPath(strPath), strLog);

                //    }
            }
            catch (Exception)
            {
                //throw exp;
            }
        }


        // new common log end

        /// Third Party Lead API Integration Added by Arti 2020/11/11
        public static string GetRequestforThirdPartyProjects(string url)
        {

            string responseFromServer = string.Empty;
            try
            {

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebRequest request = WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                using (Stream dataStream = response.GetResponseStream())
                {

                    StreamReader reader = new StreamReader(dataStream);
                    responseFromServer = reader.ReadToEnd();
                    Console.WriteLine(responseFromServer);
                }


                response.Close();


            }
            catch (Exception ex)
            {
                //CommonFunctions.WriteLog("GetRequestforThirdPartyProjects ex", ex.ToString(), DateTime.Now, DateTime.Now);


            }

            return responseFromServer;

        }


    }
}
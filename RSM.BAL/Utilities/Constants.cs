using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace RSM.BAL.Utilities
{
    public static class Constants
    {
        public class Procedures
        {
            // procedure name
            public const string Get_Country = "Get_Countries";
            public const string BSESTarMFAPI = "Logs.BSESTarMFAPI";
        }

        public class SuccessMessage
        {
            public const string price_update = "Price Updated Successfully";
            public const string file_upload = "File uploaded successfully.";
            public const string data_insert = "Record Added Successfully";
            public const string data_update = "Record Updated Successfully";
            public const string skip_mannual_process = "Contract note manual process have postponed successfully.";
            public const string status_changed = "Status Updated Successfully";
            public const string read_pdf = "Contract note process completed successfully";
            public const string read_CDSL_pdf = "CDSL file read completed successfully";
            public const string read_CAMS_pdf = "CAMS file read completed successfully";
            public const string read_NSDL_pdf = "NSDL file read completed successfully";
            public const string permission_changed = "Permission Changed Successfully.";
            public const string transaction_type_mapping = "TransactionType Mapping Saved Successfully.";
        }


        public class DefaultValues
        {
            public const string MFSelfKYCCorrectionsSubject = "MF Self KYC Corrections";
            public const string EmailOTPSubject = "OTP Verification";

            public const string MFSelfKYCCorrectionsTemplateView = "EmailTemplates/MFSelfKYCCorrectionsTemplate.cshtml";
            public const string MFSelfKYCCorrectionsTemplateAbsoluteView = "~/Views/EmailTemplates/MFSelfKYCCorrectionsTemplate.cshtml";

            public const string EmailTemplateView = "EmailTemplates/EmailOTPTemplate.cshtml";
            public const string EmailTemplateAbsoluteView = "~/Views/EmailTemplates/EmailOTPTemplate.cshtml";
        }
        public class ResponseMessages
        {
            public const string Success = "Success";
            public const string Failed = "Failed";
            public const string ServerError = "Something went wrong";
            public const string NoDataAvailable = "No Data Available";
            public const string InvalidPDF = "Invalid PDF file, Please upload a valid PDF file";
            public const string InvalidRequest = "Invalid request";
            public const string PANRequired = "PAN number is required";
            public const string PasswordRequired = "Password is required";
        }

        public class AESKeys
        {
            public static string AES256EncryptString = "WHH4nv43Let4huxP6vBqoabnE7JkpibkMf6wCGRPJBc=";
            public static string AES256IVString = "bfcvJCbmwS0qaQRmamEyJg==";
        }
        public class ResponseStatus
        {
            public const string Success = "S";
            public const string Failed = "F";
            public const string Reset = "R";
            public const string Pending = "P";
        }

        public class ProcedureColumnName
        {
            public const string Status = "STATUS";
            public const string Message = "MESSAGE";
            public const string DownloadUrl = "DownLoadURL";
            public const string ID = "ID";
        }
        public static DateTime ConvertDate(string date)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime dateTime;
            DateTime.TryParseExact(date, new string[] { "MM/dd/yyyy", "MM-dd-yyyy", "MM.dd.yyyy", "dd MMM yyyy", "dd/MM/yyyy", "dd-MM-yyyy" }, provider, DateTimeStyles.None, out dateTime);
            return dateTime;
        }

        public static string EncryptInput(string data)
        {
            byte[] encrypted;
            using (AesManaged aesManaged = new AesManaged())
            {
                ICryptoTransform encryptor = aesManaged.CreateEncryptor(Convert.FromBase64String(AESKeys.AES256EncryptString), Convert.FromBase64String(AESKeys.AES256IVString));
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                            streamWriter.Write(data);
                        encrypted = memoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }

        public static string DecryptInput(string data)
        {
            using (AesManaged aesManaged = new AesManaged())
            {
                ICryptoTransform decryptor = aesManaged.CreateDecryptor(Convert.FromBase64String(AESKeys.AES256EncryptString), Convert.FromBase64String(AESKeys.AES256IVString));
                using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(data)))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cryptoStream))
                            data = reader.ReadToEnd();
                    }
                }
            }
            return data;
        }

        public static object setCache<T>(string key, T model, int expiryTime) where T : class
        {
            ObjectCache cache = MemoryCache.Default;
            if (!cache.Contains(key))
            {
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                if (expiryTime == 0)
                {
                    cacheItemPolicy.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(60.0);
                }
                else
                {
                    cacheItemPolicy.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(expiryTime);
                }
                return cache.Add(key, model, cacheItemPolicy);
            }
            else
            {
                return cache.Get(key);
            }
        }

        public static byte[] SerializeToBytes<T>(this T source)
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, source);
                return stream.ToArray();
            }
        }

        public async static Task SetAsync<T>(this IDistributedCache distributedCache, string key, T value, DistributedCacheEntryOptions options, CancellationToken token = default(CancellationToken))
        {
            try
            {
                await distributedCache.SetAsync(key, value.ToByteArray(), options, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T GetAsync<T>(this IDistributedCache distributedCache, string key, CancellationToken token = default(CancellationToken)) where T : class
        {
            try
            {
                var result = distributedCache.Get(key);
                return result.FromByteArray<T>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static byte[] ToByteArray(this object obj)
        {
            try
            {
                if (obj == null)
                {
                    return null;
                }
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    binaryFormatter.Serialize(memoryStream, obj);
                    return memoryStream.ToArray();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T FromByteArray<T>(this byte[] byteArray) where T : class
        {
            try
            {
                if (byteArray == null)
                {
                    return default(T);
                }
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (MemoryStream memoryStream = new MemoryStream(byteArray))
                {
                    return binaryFormatter.Deserialize(memoryStream) as T;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T ConvertDataSetToJson<T>(this System.Data.DataSet dataSet)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(dataSet.GetXml());
                return (T)Convert.ChangeType(JsonConvert.SerializeXmlNode(doc).Replace("null", "\"\"").Replace("'", "\'"), typeof(T));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetAppPath(IConfiguration configuration)
        {
            var APIPath = configuration.GetSection("AppPath");
            return APIPath.Value;
        }

        public static string GetApprovedURL(IConfiguration configuration)
        {
            var APIPath = configuration.GetSection("ApproveLinkUrl");
            return APIPath.Value;
        }

        public static List<Dictionary<string, object>> ConvertDataTableToJSON(DataTable datatable)
        {
            try
            {
                List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                Dictionary<string, object> row;
                foreach (DataRow dr in datatable.Rows)
                {
                    row = new Dictionary<string, object>();
                    foreach (DataColumn col in datatable.Columns)
                    {
                        row.Add(col.ColumnName, dr[col]);
                    }
                    rows.Add(row);
                }
                return rows;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string GetAccountsUserInfoUrl(IConfiguration configuration)
        {
            var userAccountInfoAPIPath = configuration.GetSection("AccountingUrl").GetSection("UserAccountInfoUrl");
            return userAccountInfoAPIPath.Value;
        }

        public static string GetTransactionApiUrl(IConfiguration configuration)
        {
            var transactionAPIPath = configuration.GetSection("AccountingUrl").GetSection("TransactionInfoUrl");
            return transactionAPIPath.Value;
        }
    }
}

using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using xOwl_Annotations;

namespace xOwl_Excel_Connector
{
    public class JsonLdDelegate<T> where T : Identifiable, new()
    {
        public T GetDataFromWorksheet(Worksheet worksheet)
        {
            if (worksheet == null)
            {
                return null;
            }
            T res = new T();
            PropertyInfo[] properties = typeof(T).GetProperties().OrderBy(p => p.MetadataToken).ToArray();
            //FIXME: exclude UUID !!!
            foreach(PropertyInfo property in properties)
            {
                CellConfiguration cellConfiguration = property.GetCustomAttribute<CellConfiguration>();
                int[] position = cellConfiguration.Position;
                Range range = worksheet.Cells[position[0], position[1]];
                property.SetValue(res, Convert.ChangeType(range.Value, property.PropertyType));
            }
            return res;
        }

        public List<T> GetDataFromRows(Range range)
        {
            if (range.Count == 0)
            {
                return new List<T>();
            }
            List<T> res = new List<T>();
            //Need to reorder properties properly
            PropertyInfo[] properties = typeof(T).GetProperties().OrderBy(p => p.MetadataToken).ToArray();
            T t;
            for (int i = 1; i <= range.Rows.Count; i++)
            {
                t = new T();
                int col = 1;
                properties[0].SetValue(t, System.Guid.NewGuid().ToString());
                for (int j = 1; j < properties.Length; j++)
                {
                    PropertyInfo property = properties[j];
                    CellConfiguration cellConfiguration = properties[i].GetCustomAttribute<CellConfiguration>();
                    property.SetValue(t, Convert.ChangeType(range.Cells[i, col++].Value, property.PropertyType));
                    if (cellConfiguration != null)
                    {
                        col += ((CellConfiguration)cellConfiguration).CellsAfter;
                        //TODO: process other cell properties
                    }
                }
                res.Add(t);
            }
            return res;
        }

        public List<T> GetDataFromCols(Range range)
        {
            //TODO
            throw new NotImplementedException();
        }
    }

    public class SparqlResultDelegate<T> where T : Identifiable, new()
    {
        public List<T> GetDataFromResponse(string response)
        {
            List<T> res = new List<T>();
            PropertyInfo[] properties = typeof(T).GetProperties().OrderBy(p => p.MetadataToken).ToArray();
            dynamic result = JsonConvert.DeserializeObject(response);
            PropertyInfo property;
            foreach (var r in result.results.bindings)
            {
                T t = new T();
                properties[0].SetValue(t, (string)r[typeof(T).Name.ToLower()].value);
                //we skip the uuid
                for (int i = 1; i < properties.Length; i++)
                {
                    property = properties[i];
                    property.SetValue(t, Convert.ChangeType(r[property.Name.ToLower()].value, property.PropertyType));
                }
                res.Add(t);
            }
            return res;
        }

        public void SetRowsFromData(Range range, List<T> data)
        {
            //TODO: set cells read only
            PropertyInfo[] properties = typeof(T).GetProperties().OrderBy(p => p.MetadataToken).ToArray();
            Range cell;
            //we skip the uuid
            int col = 0;
            for (int i = 1; i < properties.Length; i++)
            {
                cell = range.Cells[1, col + i];
                cell.Value = properties[i].Name.ToUpper();
                //TODO: use annotation instead to set cell style
                cell.Font.Bold = true;
                cell.Font.Color = ColorTranslator.ToOle(Color.White);
                cell.Interior.Color = ColorTranslator.ToOle(Color.Gray);
                CellConfiguration cellConfiguration = properties[i].GetCustomAttribute<CellConfiguration>();
                if (cellConfiguration != null)
                {
                    col += cellConfiguration.CellsAfter;
                    //TODO: process other cell properties
                }
            }
            col = 0;
            int row = 2;
            PropertyInfo property;
            object value;
            foreach (T t in data)
            {
                //we skip the uuid
                for (int i = 1; i < properties.Length; i++)
                {
                    property = properties[i];
                    value = property.GetValue(t);
                    range.Cells[row, col + i].Value = value;
                    CellConfiguration cellConfiguration = properties[i].GetCustomAttribute<CellConfiguration>();
                    if (cellConfiguration != null)
                    {
                        col += cellConfiguration.CellsAfter;
                        //TODO: process other cell properties
                    }
                }
                col = 0;
                row++;
            }
        }
    }

    public class XowlUtils
    {
        public static CookieContainer cookies = null;
        public static string api = null;

        /// <summary>
        /// <exception cref="WebException">Connection Failed</exception>
        /// </summary>
        /// <returns>Cookies for secured transactions</returns>
        public static CookieContainer Connect()
        {
            string xowlAddress = (string)Properties.Settings.Default["xowlAddress"];
            string xowlLogin = (string)Properties.Settings.Default["xowlLogin"];
            string xowlPassword = (string)Properties.Settings.Default["xowlPassword"];
            cookies = new CookieContainer();
            api = xowlAddress + "/api/";
            if (string.IsNullOrEmpty(xowlAddress) || string.IsNullOrEmpty(xowlAddress) || string.IsNullOrEmpty(xowlAddress))
            {
                new PrefForm().Show();
                return Connect();
            }
            // System.Diagnostics.Debug.WriteLine("Connecting to collaboration");
            string parameters = "login=" + xowlLogin;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(new Uri(XowlUtils.api + "kernel/security/login?" + parameters));
            req.CookieContainer = cookies;
            req.ContentType = "application/json";
            req.Method = "POST";
            string body = xowlPassword;
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(body);
            req.ContentLength = bytes.Length;
            System.IO.Stream os = req.GetRequestStream();
            os.Write(bytes, 0, bytes.Length);
            os.Close();
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            cookies.Add(resp.Cookies);
            return cookies;
        }

        //TODO: retrieve namespace using properties file
        public static List<Type> GetClassesFromNameSpace(string name)
        {
            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace.Equals(name)
                    select t;
            return q.ToList();
        }

        public static List<Artifact> RetrieveArtifacts(bool live)
        {
            string addr = api + "services/storage/artifacts";
            if (live)
            {
                addr += "/live";
            }
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(new Uri(addr));
            req.CookieContainer = cookies;
            req.ContentType = "application/json";
            req.Method = "GET";
            try
            {
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                cookies.Add(resp.Cookies);
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                string json = sr.ReadToEnd().Trim();
                return JsonConvert.DeserializeObject<List<Artifact>>(json);
            }
            catch (WebException ex)
            {
                //TODO: take into account the error code to execute appropriate actions
                Connect();
                return RetrieveArtifacts(live);
            }

        }

        public static string ArtifactToBase(Artifact a)
        {
            return a.Base;
        }

        public static string ArtifactToName(Artifact a)
        {
            return a.name;
        }

        public static string ToSparqlQuery(Type type)
        {
            StringBuilder sb = new StringBuilder();
            string className = type.Name;
            string baseUri = GetBaseUri(type);
            PropertyInfo[] properties = type.GetProperties().OrderBy(p => p.MetadataToken).ToArray();
            sb.Append("SELECT DISTINCT * WHERE { GRAPH ?g { ?");
            sb.Append(className.ToLower());
            sb.Append(" a <");
            sb.Append(baseUri + className);
            sb.Append(">;");
            for (int i = 1; i < properties.Length; i++)
            {
                PropertyInfo property = properties[i];
                string name = property.Name.ToLower();
                sb.Append("<" + baseUri + name + "> ?");
                sb.Append(name);
                if (i == properties.Length - 1)
                {
                    sb.Append(". ");
                }
                else
                {
                    sb.Append("; ");
                }
            }
            sb.Append("} }");
            return sb.ToString();
        }

        public static string GetBaseUri(Type type)
        {
            var businessClass = type.GetCustomAttribute(typeof(BusinessClass));
            if (businessClass != null)
            {
                return ((BusinessClass)businessClass).BaseUri;
            }
            else
            {
                return "http://xowl.org/freetype#";
            }
        }
    }
}

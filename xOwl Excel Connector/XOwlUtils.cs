using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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
            //FIXME: we need to keep track of data evolution => generating new uuid each times fails the comparison at server side
            PropertyInfo[] properties = typeof(T).GetProperties().OrderBy(p => p.MetadataToken).ToArray();
            //properties[0].SetValue(res, System.Guid.NewGuid().ToString());
            properties[0].SetValue(res, typeof(T).Name.ToLower()); //temporary
            PropertyInfo property;
            for (int i = 1; i < properties.Length; i++) 
            {
                property = properties[i];
                PushConfiguration cellConfiguration = property.GetCustomAttribute<PushConfiguration>();
                int[] position = cellConfiguration.Position;
                Range range = worksheet.Cells[position[0], position[1]];
                string value = range.Value.ToString();
                Type propertyType = property.PropertyType;
                if (propertyType.Name.Equals("Double"))
                {
                    //var dvalue = Double.Parse(value, new CultureInfo("en-US"));
                    var dvalue = Double.Parse(value, CultureInfo.CurrentUICulture);
                    property.SetValue(res, dvalue);
                }
                else if (propertyType.Name.Equals("Boolean"))
                {
                    var bvalue = Boolean.Parse(value);
                    property.SetValue(res, bvalue);
                }
                else
                {
                    property.SetValue(res, Convert.ChangeType(value, property.PropertyType));
                }
            }
            return res;
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

        public void SetCellsFromData(List<T> data, Worksheet worksheet)
        {
            Type type = typeof(T);

            BusinessClass businessClass = type.GetCustomAttribute<BusinessClass>();
            if (businessClass.Position.Equals(worksheet.Name))
            {
                this.SetCellsFromPushConfiguration(data, worksheet);
            } else
            {
                this.SetCellsFromPullConfiguration(data, worksheet);
            }
        }

        private void SetCellsFromPushConfiguration(List<T> data, Worksheet worksheet)
        {
            PropertyInfo[] properties = typeof(T).GetProperties().OrderBy(p => p.MetadataToken).ToArray();
            PropertyInfo property;
            object value;
            int[] position;
            PushConfiguration cellConfiguration;
            foreach (T t in data)
            {
                //we skip the uuid
                for (int i = 1; i < properties.Length; i++)
                {
                    property = properties[i];
                    value = property.GetValue(t);
                    cellConfiguration = property.GetCustomAttribute<PushConfiguration>();
                    if (cellConfiguration != null)
                    {
                        position = cellConfiguration.Position;
                        worksheet.Cells[position[0], position[1]].Value = value;
                        //TODO: process other cell properties
                    }
                }
            }
        }

        private void SetCellsFromPullConfiguration(List<T> data, Worksheet worksheet)
        {
            PropertyInfo[] properties = typeof(T).GetProperties().OrderBy(p => p.MetadataToken).ToArray();
            PropertyInfo property;
            object value;
            int[] position;
            CellConfiguration cellConfiguration = null;
            foreach (T t in data)
            {
                //we skip the uuid
                for (int i = 1; i < properties.Length; i++)
                {
                    property = properties[i];
                    value = property.GetValue(t);
                    //FIXME: avoid hard coding this
                    if (worksheet.Name.Equals("Donnees"))
                    {
                        cellConfiguration = property.GetCustomAttribute<PowerRamDataConfiguration>();
                    } else if (worksheet.Name.Equals("Actuator Key characteristics"))
                    {
                        cellConfiguration = property.GetCustomAttribute<ActuatorConfiguration>();
                    }
                    else if (worksheet.Name.Equals("Paramètre spec"))
                    {
                        cellConfiguration = property.GetCustomAttribute<StaticPerformanceConfiguration>();//TODO
                    }
                    else if (worksheet.Name.Equals("section bloc hyd"))
                    {
                        cellConfiguration = property.GetCustomAttribute<HydraulicBlockConfiguration>();
                    }
                    if (cellConfiguration != null)
                    {
                        position = cellConfiguration.Position;
                        worksheet.Cells[position[0], position[1]].Value = value;
                        //TODO: process other cell properties
                    }
                }
            }
        }
    }

    public class XowlUtils
    {
        public static CookieContainer cookies = null;
        public static string xowlApi = null;

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
            xowlApi = xowlAddress + "/api/";
            if (string.IsNullOrEmpty(xowlAddress) || string.IsNullOrEmpty(xowlAddress) || string.IsNullOrEmpty(xowlAddress))
            {
                new PrefForm().Show();
                return null;
            }
            // System.Diagnostics.Debug.WriteLine("Connecting to collaboration");
            string parameters = "login=" + xowlLogin;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(new Uri(XowlUtils.xowlApi + "kernel/security/login?" + parameters));
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
            string addr = xowlApi + "services/storage/artifacts";
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

        public static string ToSparqlQuery(Type type, Artifact artifact)
        {
            StringBuilder sb = new StringBuilder();
            string className = type.Name;
            string baseUri = GetBaseUri(type);
            PropertyInfo[] properties = type.GetProperties().OrderBy(p => p.MetadataToken).ToArray();
            sb.Append("SELECT DISTINCT * WHERE { GRAPH <");
            sb.Append(artifact.Identifier);
            sb.Append("> { ?");
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

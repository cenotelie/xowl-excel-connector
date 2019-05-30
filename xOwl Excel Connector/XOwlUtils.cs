using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Reflection;
using Newtonsoft.Json;
using Microsoft.Office.Interop.Excel;
using xOwl_Annotations;

namespace xOwl_Excel_Connector
{
    public partial class PushWizard : Form
    {
        private List<Artifact> artifacts;
        private void RetrieveArtifacts()
        {
            try
            {
                this.artifacts = XowlUtils.RetrieveArtifacts(this.cookies);
            }
            catch(WebException e)
            {
                this.isConnected = false;
            }
        }
    }

    public partial class PullWizard : Form
    {
        private List<Artifact> artifacts;
        private void RetrieveArtifacts()
        {
            try
            {
                this.artifacts = XowlUtils.RetrieveArtifacts(this.cookies);
            }
            catch (WebException e)
            {
                this.isConnected = false;
            }
        }
    }

    public class JsonLdDelegate<T> where T : Identifiable, new()
    {
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
                //we start at 1 because we don't process uuid
                for (int j = 1; j < properties.Length; j++)
                {
                    PropertyInfo property = properties[j];
                    var cellConfiguration = property.GetCustomAttribute(typeof(CellConfiguration));
                    property.SetValue(t, Convert.ChangeType(range.Cells[i, col++].Value, property.PropertyType));
                    if (cellConfiguration != null)
                    {
                        col += ((CellConfiguration)cellConfiguration).cellsAfter;
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

    public class XowlUtils
    {
        public static List<Type> GetClassesFromNameSpace(string name)
        {
            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace.Equals(name)
                    select t;
            return q.ToList();
        }

        /// <summary>
        /// <exception cref="WebException">Connection Failed</exception>
        /// </summary>
        /// <param name="cookies"></param>
        /// <returns>List of stored artifacts</returns>
        public static List<Artifact> RetrieveArtifacts(CookieContainer cookies)
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(new Uri(XOWLRibbon.api + "services/storage/artifacts"));
            req.CookieContainer = cookies;
            req.ContentType = "application/json";
            req.Method = "GET";
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            cookies.Add(resp.Cookies);
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string json = sr.ReadToEnd().Trim();
            return JsonConvert.DeserializeObject<List<Artifact>>(json);
        }

        public static string ArtifactToString(Artifact a)
        {
            return a.Base;
        }
    }
}

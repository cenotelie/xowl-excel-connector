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

namespace xOwl_Excel_Connector
{
    public partial class PushWizard : Form
    {
        private List<Artifact> artifacts;
        private void RetrieveArtifacts()
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(new Uri(XOWLRibbon.api + "services/storage/artifacts"));
            req.CookieContainer = this.cookies;
            req.ContentType = "application/json";
            req.Method = "GET";
            try
            {
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                this.cookies.Add(resp.Cookies);
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                string json = sr.ReadToEnd().Trim();
                this.artifacts = JsonConvert.DeserializeObject<List<Artifact>>(json);
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                this.isConnected = false;
            }
        }

        public static string ArtifactToString(Artifact a)
        {
            return a.Base;
        }
    }

    public class JsonLdDelegate<T> where T : Identifiable, new()
    {
        public List<T> GetDataFromRange(Range range)
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
                for (int j = 0; j < properties.Length; j++)
                {
                    //FIXME: take into account the type of the property when reading the value
                    properties[j].SetValue(t, range.Cells[i, col++].Value.ToString(), null);
                }
                res.Add(t);
            }
            return res;
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
    }
}

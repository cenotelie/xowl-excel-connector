using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
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

    public class RequirementsDelegate
    {
        public static List<Requirement> GetRequirementsFromRange(Range range)
        {
            if (range.Count == 0)
            {
                return new List<Requirement>();
            }
            List<Requirement> res = new List<Requirement>();
            Requirement req;
            for (int i = 1; i < range.Rows.Count; i++)
            {
                req = new Requirement();
                req.identifier = range.Cells[i, 1].Value.ToString();
                req.title = range.Cells[i, 2].Value.ToString();
                req.description = range.Cells[i, 3].Value.ToString();
                res.Add(req);
            }
            return res;
        }
    }
}

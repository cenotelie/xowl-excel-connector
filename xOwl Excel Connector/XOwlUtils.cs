using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

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
}

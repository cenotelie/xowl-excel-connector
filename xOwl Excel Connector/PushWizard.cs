using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace xOwl_Excel_Connector
{
    public partial class PushWizard : Form
    {

        private bool isConnected = false;
        private CookieContainer cookies;
        private List<Artifact> artifacts;

        public PushWizard(bool isConnected, CookieContainer cookies)
        {
            InitializeComponent();
            this.isConnected = isConnected;
            this.cookies = cookies;
            this.RetrieveArtifacts();
            //TODO collect all bases as a set
            this.baseArtifactsLB.DataSource = this.artifacts.ConvertAll(new Converter<Artifact, string>(ArtifactToString));
            //this.baseArtifactsLB.DisplayMember = "Name";
            //this.baseArtifactsLB.ValueMember = "Identifier";
        }
        
        public static string ArtifactToString(Artifact a)
        {
            //TODO: maybe set into a partial class
            return a.Base;
        }

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

        private void ArtifactNameValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.artifactNameTB.Text.Trim()))
            {
                e.Cancel = true;
                this.nameError.SetError(this.artifactNameTB, "Bad Name");
            }
            else
            {
                e.Cancel = false;
                this.nameError.SetError(this.artifactNameTB, null);
            }
        }

        private void ArtifactVersionValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.artifactVersionTB.Text.Trim()))
            {
                e.Cancel = true;
                this.nameError.SetError(this.artifactVersionTB, "Bad Version");
            }
            else
            {
                e.Cancel = false;
                this.nameError.SetError(this.artifactVersionTB, null);
            }
        }

        private void PushArtifact_Click(object sender, EventArgs e)
        {
            if (this.isConnected && this.ValidateChildren())
            {
                this.DoPushArtifact();
                this.Close();
            }
        }

        private void DoPushArtifact()
        {
            System.Diagnostics.Debug.WriteLine("Pushing data to collaboration");

            string name = this.artifactNameTB.Text.Trim();
            string type = this.archetypesLB.Text; //TODO: process type
            string archetype = "org.xowl.platform.kernel.artifacts.ArtifactArchetypeFree";
            string baseArtifact = Uri.EscapeDataString(this.baseArtifactsLB.Text);
            string superseded = this.supersededLB.Text;
            string version = this.artifactVersionTB.Text.Trim();

            string parameters = $"name={name}&base={baseArtifact}&version={version}&archetype={archetype}";
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(new Uri(XOWLRibbon.api + "connectors/generics/sw?" + parameters));
            req.CookieContainer = this.cookies;
            req.ContentType = "application/ld+json";
            req.Method = "POST";
            string body = "{ \"@graph\": [{ \"@id\":\"http://xowl.org/requirements#REQ001\", \"http://xowl.org/requirements#description\": \"REQ001 description\"}]}";
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(body);
            req.ContentLength = bytes.Length;
            System.IO.Stream os = req.GetRequestStream();
            os.Write(bytes, 0, bytes.Length);
            os.Close();
            try
            {
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                string r = sr.ReadToEnd().Trim();
                //TODO: use local storage to store artifacts (create corresponding class before)
                System.Diagnostics.Debug.WriteLine(r);
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

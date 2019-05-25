using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace xOwl_Excel_Connector
{
    public partial class PushWizard : Form
    {

        private bool isConnected = false;
        private CookieContainer cookies;

        public PushWizard(bool isConnected, CookieContainer cookies)
        {
            InitializeComponent();
            this.isConnected = isConnected;
            this.cookies = cookies;
            this.RetrieveArtifacts();
            this.archetypesLB.SelectedIndex = 0;
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
            //retrieve parameters
            string name = this.artifactNameTB.Text.Trim();
            string type = this.archetypesLB.SelectedItem.ToString(); //TODO: process type
            string archetype = "org.xowl.platform.kernel.artifacts.ArtifactArchetypeFree";
            string version = this.artifactVersionTB.Text.Trim();
            string baseArtifact = Uri.EscapeDataString("http://xowl.org/data/" + type);
            string parameters;
            if (this.supersededLB.Items.Count == 0)
            {
                parameters = $"name={name}&base={baseArtifact}&version={version}&archetype={archetype}";
            } else
            {
                string superseded = this.supersededLB.SelectedItem.ToString();
                parameters = $"name={name}&base={baseArtifact}&version={version}&archetype={archetype}&superseded={superseded}";
            }
            //make the request
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(new Uri(XOWLRibbon.api + "connectors/generics/sw?" + parameters));
            req.CookieContainer = this.cookies;
            req.ContentType = "application/ld+json";
            req.Method = "POST";
            string body = this.generateJsonLD();
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

        private void Archetype_Selected(object sender, EventArgs e)
        {
            string type = this.archetypesLB.SelectedItem.ToString();
            string baseArtifact = Uri.EscapeDataString("http://xowl.org/data/" + type);
            this.supersededLB.DataSource = this.artifacts.Where<Artifact>(a => string.Equals(a.Base, baseArtifact)).ToList<Artifact>();
        }

        private String generateJsonLD()
        {
            //TODO: process cells to generate json ld => delegate cells to dedicated delegator
            return "{ \"@graph\": [{ \"@id\":\"http://xowl.org/requirements#REQ001\", \"http://xowl.org/requirements#description\": \"REQ001 description\"}]}";
        }
    }
}

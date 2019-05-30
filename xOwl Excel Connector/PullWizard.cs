using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using BusinessData;

namespace xOwl_Excel_Connector
{
    public partial class PullWizard : Form
    {
        private bool isConnected = false;
        private CookieContainer cookies;

        public PullWizard(bool isConnected, CookieContainer cookies)
        {
            InitializeComponent();
            this.isConnected = isConnected;
            this.cookies = cookies;
            this.archetypesLB.DataSource = XowlUtils.GetClassesFromNameSpace("BusinessData");
            this.archetypesLB.DisplayMember = "Name";
            this.archetypesLB.SelectedIndex = 0;
        }

        private void PullArtifact_Click(object sender, EventArgs e)
        {
            if (this.isConnected && this.ValidateChildren())
            {
                this.DoPullArtifact();
                this.Close();
            }
        }

        private void DoPullArtifact()
        {
            string parameters = "store=longTerm";
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(new Uri(XOWLRibbon.api + "services/storage/sparql?" + parameters));
            req.CookieContainer = this.cookies;
            req.ContentType = "application/sparql-query";
            req.Accept = "application/json";
            req.Method = "POST";
            //TODO: construct the request based on the selected archetype
            //FIXME: It seems that the selection of the artifact is useless here ! It shall actually be activated for live reasoning at server side using the web interface
            //It will be activate later through dedicated UI
            string sparqlRequest = "SELECT DISTINCT ?x ?y WHERE { GRAPH ?g { ?x <http://xowl.org/requirements#description> ?y } }";
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(sparqlRequest);
            req.ContentLength = bytes.Length;
            System.IO.Stream os = req.GetRequestStream();
            os.Write(bytes, 0, bytes.Length);
            os.Close();
            try
            {
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                string r = sr.ReadToEnd().Trim();
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

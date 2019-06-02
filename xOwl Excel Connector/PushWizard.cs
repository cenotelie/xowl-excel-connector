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

namespace xOwl_Excel_Connector
{
    public partial class PushWizard : Form
    {
        private List<Artifact> artifacts;

        public PushWizard()
        {
            InitializeComponent();
            this.artifacts = XowlUtils.RetrieveArtifacts(false);
            this.baseArtifactsLB.DataSource = new List<string>(new HashSet<string>(this.artifacts.ConvertAll(new Converter<Artifact, string>(XowlUtils.ArtifactToBase))));
            this.archetypesLB.DataSource = XowlUtils.GetClassesFromNameSpace("BusinessData");
            this.archetypesLB.DisplayMember = "Name";
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
            if (this.ValidateChildren())
            {
                this.DoPushArtifact();
                this.Close();
            }
        }

        private void DoPushArtifact()
        {
            System.Diagnostics.Debug.WriteLine("Pushing data to collaboration");

            string name = this.artifactNameTB.Text.Trim();
            Type type = (Type)this.archetypesLB.SelectedItem;
            string archetype = "org.xowl.platform.kernel.artifacts.ArtifactArchetypeFree";
            //FIXME: ensure unicity of version for the same name and within the same base
            string version = this.artifactVersionTB.Text.Trim();
            string baseArtifact, superseded, parameters;
            if (this.existingBABtn.Checked)
            {
                baseArtifact = Uri.EscapeDataString(this.baseArtifactsLB.SelectedItem.ToString());
                superseded = this.supersededLB.SelectedItem.ToString();
                parameters = $"name={name}&base={baseArtifact}&version={version}&archetype={archetype}&superseded={superseded}";
            }
            else
            {
                baseArtifact = Uri.EscapeDataString(this.newBATB.Text);
                parameters = $"name={name}&base={baseArtifact}&version={version}&archetype={archetype}";
            }
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(new Uri(XowlUtils.api + "connectors/generics/sw?" + parameters));
            req.CookieContainer = XowlUtils.cookies;
            req.ContentType = "application/ld+json";
            req.Accept = "application/json";
            req.Method = "POST";
            string body = this.JsonFromSelectecCells(type);
            byte[] bytes = Encoding.UTF8.GetBytes(body);
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
                //TODO: take into account the code of the exception to execute appropriate actions
                XowlUtils.Connect();
                DoPushArtifact();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExistingBase_Click(object sender, EventArgs e)
        {
            this.baseArtifactsLB.Enabled = true;
            this.newBATB.Enabled = false;
            this.supersededLB.Enabled = false;
        }

        private void NewBase_Click(object sender, EventArgs e)
        {
            this.baseArtifactsLB.Enabled = false;
            this.newBATB.Enabled = true;
            this.supersededLB.Enabled = false;
        }

        private void BaseArtifact_Selected(object sender, EventArgs e)
        {
            string selectedBA = this.baseArtifactsLB.Text;
            List<Artifact> filteredArtifacts = this.artifacts.Where<Artifact>(a => string.Equals(a.Base, selectedBA)).ToList<Artifact>();
            this.supersededLB.DataSource = filteredArtifacts;
            this.supersededLB.DisplayMember = "supersededDisplay";
            this.supersededLB.ValueMember = "identifier";
            this.supersededLB.Enabled = true;
        }

        private string JsonFromSelectecCells(Type type)
        {
            Range selection = Globals.ThisAddIn.Application.ActiveWindow.RangeSelection;
            Type genericClass = typeof(JsonLdDelegate<>);
            Type constructedClass = genericClass.MakeGenericType(type);
            ConstructorInfo constructedClassConstructor = constructedClass.GetConstructor(Type.EmptyTypes);
            object createdInstance = constructedClassConstructor.Invoke(new Object[] { });
            //TODO: take into account chosen alignment
            MethodInfo getData = constructedClass.GetMethod("GetDataFromRows");
            object res = getData.Invoke(createdInstance, new Object[] { selection });
            List<Identifiable> data = ((IEnumerable<Identifiable>)res).Cast<Identifiable>().ToList();
            StringBuilder sb = new StringBuilder();
            sb.Append("{\"@graph\":[");
            foreach (Identifiable identifiable in data)
            {
                sb.Append(identifiable.ToJsonLD());
                sb.Append(",");
            }
            sb.Length--;
            sb.Append("]}");
            return sb.ToString();
        }
    }
}

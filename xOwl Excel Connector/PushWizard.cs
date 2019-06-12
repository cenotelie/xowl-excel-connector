using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using xOwl_Annotations;

namespace xOwl_Excel_Connector
{
    public partial class PushWizard : Form
    {
        private List<Artifact> artifacts;

        public PushWizard()
        {
            InitializeComponent();
            if (XowlUtils.cookies == null)
            {
                XowlUtils.Connect();
            }
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
            HttpWebRequest xowlReq = (HttpWebRequest)HttpWebRequest.Create(new Uri(XowlUtils.xowlApi + "connectors/generics/sw?" + parameters));
            xowlReq.CookieContainer = XowlUtils.cookies;
            xowlReq.ContentType = "application/ld+json";
            xowlReq.Accept = "application/json";
            xowlReq.Method = "POST";
            string body = this.ToJsonLD(type);
            byte[] bytes = Encoding.UTF8.GetBytes(body);
            xowlReq.ContentLength = bytes.Length;
            System.IO.Stream os = xowlReq.GetRequestStream();
            os.Write(bytes, 0, bytes.Length);
            os.Close();
            try
            {
                HttpWebResponse resp = (HttpWebResponse)xowlReq.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                string r = sr.ReadToEnd().Trim();
                System.Diagnostics.Debug.WriteLine(r);
            }
            catch (WebException ex)
            {
                //TODO: take into account the code of the exception to execute appropriate actions
                XowlUtils.Connect();
                //DoPushArtifact();//FIXME: improve management of cookies
            }
            //FIXME: improve scheduling of notifications
            ActivitiProcessManager pm = new ActivitiProcessManager();
            pm.CompleteTaskForData(type);
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

        private string ToJsonLD(Type type)
        {
            Type genericClass = typeof(JsonLdDelegate<>);
            Type constructedClass = genericClass.MakeGenericType(type);
            ConstructorInfo constructedClassConstructor = constructedClass.GetConstructor(Type.EmptyTypes);
            object createdInstance = constructedClassConstructor.Invoke(new Object[] { });
            //TODO: take into account chosen alignment in case of simple mapping
            StringBuilder sb = new StringBuilder();
            BusinessClass businessClass = type.GetCustomAttribute<BusinessClass>();
            sb.Append("{\"@graph\":[");
            if (businessClass.IsComplex)
            {
                Worksheet worksheet = Globals.ThisAddIn.Application.Worksheets[businessClass.Position];
                MethodInfo getData = constructedClass.GetMethod("GetDataFromWorksheet");
                object res = getData.Invoke(createdInstance, new Object[] { worksheet });
                sb.Append(((Identifiable)res).ToJsonLD());
            } else
            {
                Range selection = Globals.ThisAddIn.Application.ActiveWindow.RangeSelection;
                MethodInfo getData = constructedClass.GetMethod("GetDataFromRows");
                object res = getData.Invoke(createdInstance, new Object[] { selection });
                List<Identifiable> data = ((IEnumerable<Identifiable>)res).Cast<Identifiable>().ToList();
                
                foreach (Identifiable identifiable in data)
                {
                    sb.Append(identifiable.ToJsonLD());
                    sb.Append(",");
                }
                sb.Length--;
            }
            sb.Append("]}");
            return sb.ToString();
        }
    }
}

using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            this.archetypesLB.DataSource = XowlUtils.GetClassesFromNameSpace("BusinessData");
            this.archetypesLB.DisplayMember = "Name";
            this.archetypesLB.SelectedIndex = 0;
        }

        private void ArtifactVersionValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.artifactVersionTB.Text.Trim()))
            {
                e.Cancel = true;
                this.versionError.SetError(this.artifactVersionTB, "Bad Version");
            }
            else
            {
                e.Cancel = false;
                this.versionError.SetError(this.artifactVersionTB, null);
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
            Type type = (Type)this.archetypesLB.SelectedItem;
            string archetype = "org.xowl.platform.kernel.artifacts.ArtifactArchetypeFree";
            //FIXME: ensure unicity of version for the same name and within the same base
            string baseUri = (string) Properties.Settings.Default["baseUri"];
            string name = type.Name.ToLower();
            string baseArtifact = baseUri + name;
            string version = this.artifactVersionTB.Text.Trim();
            string parameters;
            if (this.supersededLB.SelectedIndex == -1)
            {
                parameters = $"name={name}&base={baseArtifact}&version={version}&archetype={archetype}";
            }
            else
            {
                string superseded = this.supersededLB.SelectedItem.ToString();
                parameters = $"name={name}&base={baseArtifact}&version={version}&archetype={archetype}&superseded={superseded}";
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
                xowlReq = (HttpWebRequest)HttpWebRequest.Create(new Uri(XowlUtils.xowlApi + "connectors/generics/pull"));
                xowlReq.CookieContainer = XowlUtils.cookies;
                xowlReq.ContentType = "application/ld+json";
                xowlReq.Accept = "application/json";
                xowlReq.Method = "POST";
                resp = (HttpWebResponse)xowlReq.GetResponse();
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
            Worksheet worksheet = Globals.ThisAddIn.Application.Worksheets[businessClass.Position];
            MethodInfo getData = constructedClass.GetMethod("GetDataFromWorksheet");
            object res = getData.Invoke(createdInstance, new Object[] { worksheet });
            sb.Append(((Identifiable)res).ToJsonLD());
            sb.Append("]}");
            return sb.ToString();
        }

        private void ArchetypeSelected(object sender, EventArgs e)
        {
            Type type = (Type)this.archetypesLB.SelectedItem;
            string baseArtifact = (string)Properties.Settings.Default["baseUri"] + type.Name.ToLower();
            var filteredArtifacts = from a in artifacts where a.Base.Equals(baseArtifact) select a;
            this.supersededLB.DataSource = filteredArtifacts.ToList<Artifact>();
            this.supersededLB.DisplayMember = "Version";
            this.supersededLB.Enabled = true;
        }
    }
}

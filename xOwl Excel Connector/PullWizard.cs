using Microsoft.Office.Interop.Excel;
using System;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace xOwl_Excel_Connector
{
    public partial class PullWizard : Form
    {

        public PullWizard()
        {
            InitializeComponent();
            this.archetypesLB.DataSource = XowlUtils.GetClassesFromNameSpace("BusinessData");
            this.archetypesLB.DisplayMember = "Name";
            this.archetypesLB.SelectedIndex = 0;
        }

        private void PullArtifact_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DoPullArtifact();
                this.Close();
            }
        }

        private void DoPullArtifact()
        {
            string parameters = "store=liveTerm"; //FIXME: or long term if needed
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(new Uri(XowlUtils.api + "services/storage/sparql?" + parameters));
            req.CookieContainer = XowlUtils.cookies;
            req.ContentType = "application/sparql-query";
            req.Accept = "application/json";
            req.Method = "POST";
            //TODO: construct the request based on the selected archetype
            //FIXME: It seems that the selection of the artifact is useless here ! It shall actually be activated for live reasoning at server side using the web interface
            //It will be activate later through dedicated UI
            Type type = (Type)this.archetypesLB.SelectedItem;
            string sparqlRequest = XowlUtils.ToSparqlQuery(type);
            byte[] bytes = Encoding.UTF8.GetBytes(sparqlRequest);
            req.ContentLength = bytes.Length;
            System.IO.Stream os = req.GetRequestStream();
            os.Write(bytes, 0, bytes.Length);
            os.Close();
            try
            {
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                string r = sr.ReadToEnd().Trim();
                processJsonResponse(r, type);
                System.Diagnostics.Debug.WriteLine(r);
            }
            catch (WebException ex)
            {
                //TODO: take into account the code of the exception to execute appropriate actions
                XowlUtils.Connect();
                DoPullArtifact();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void processJsonResponse(string response, Type type)
        {
            Type genericClass = typeof(SparqlResultDelegate<>);
            Type constructedClass = genericClass.MakeGenericType(type);
            ConstructorInfo constructedClassConstructor = constructedClass.GetConstructor(Type.EmptyTypes);
            object createdInstance = constructedClassConstructor.Invoke(new Object[] { });
            //TODO: take into account chosen alignment
            MethodInfo getData = constructedClass.GetMethod("GetDataFromResponse");
            object res = getData.Invoke(createdInstance, new Object[] { response });
            Range selection = Globals.ThisAddIn.Application.ActiveWindow.RangeSelection;
            MethodInfo setRows = constructedClass.GetMethod("SetRowsFromData");
            setRows.Invoke(createdInstance, new Object[] { selection, res });
        }
    }
}

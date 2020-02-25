﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Net;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using xOwl_Annotations;

namespace xOwl_Excel_Connector
{
    public partial class PullWizard : Form
    {
        private List<Artifact> artifacts;

        public PullWizard()
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
            Artifact selectedArtifact = (Artifact) this.versionsLB.SelectedItem;
            Type type = (Type)this.archetypesLB.SelectedItem;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(new Uri(XowlUtils.xowlApi + "services/storage/sparql?store=longTerm"));
            req.CookieContainer = XowlUtils.cookies;
            req.ContentType = "application/sparql-query";
            req.Accept = "application/json";
            req.Method = "POST";
            string sparqlRequest = XowlUtils.ToSparqlQuery(type, selectedArtifact);
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
                //DoPullArtifact();//FIXME: improve management of cookies
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
            BusinessClass businessClass = type.GetCustomAttribute<BusinessClass>();
            MethodInfo getData = constructedClass.GetMethod("GetDataFromResponse");
            object res = getData.Invoke(createdInstance, new Object[] { response });
            //FIXME: we consider that the worksheet exists => create it otherwise
            Worksheet worksheet = Globals.ThisAddIn.Application.ActiveSheet;
            MethodInfo setCellsFromData = constructedClass.GetMethod("SetCellsFromData");
            setCellsFromData.Invoke(createdInstance, new Object[] { res, worksheet });
        }

        private void ArchetypeSelected(object sender, EventArgs e)
        {
            Type type = (Type)this.archetypesLB.SelectedItem;
            string baseArtifact = (string)Properties.Settings.Default["baseUri"] + type.Name.ToLower();
            var filteredArtifacts = from a in artifacts where a.Base.Equals(baseArtifact) select a;
            this.versionsLB.DataSource = filteredArtifacts.ToList<Artifact>();
            this.versionsLB.DisplayMember = "Version";
            this.versionsLB.Enabled = true;
        }
    }
}

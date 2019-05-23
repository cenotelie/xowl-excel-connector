using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Microsoft.Office.Tools.Ribbon;

namespace xOwl_Excel_Connector
{
    public partial class XOWLRibbon
    {

        private bool isConnected;
        private CookieContainer cookies;
        private const string api = "https://integration.xowl.org/api/";

        private void PrefBtn_Click(object sender, RibbonControlEventArgs e) => new PrefForm().Show();

        private void XOWLRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
               | SecurityProtocolType.Tls11
               | SecurityProtocolType.Tls12
               | SecurityProtocolType.Ssl3;
            this.isConnected = false;
            this.cookies = new CookieContainer();
        }

        private void ConnectBtn_Click(object sender, RibbonControlEventArgs e)
        {
            //TODO: deactivate button if properties not set properly
            if (isConnected) return;
            string xowlAddress = (string) Properties.Settings.Default["xowlAddress"];
            string xowlLogin = (string)Properties.Settings.Default["xowlLogin"];
            string xowlPassword = (string)Properties.Settings.Default["xowlPassword"];
            if (string.IsNullOrEmpty(xowlAddress) || string.IsNullOrEmpty(xowlAddress) || string.IsNullOrEmpty(xowlAddress))
            {
                return;
            }
            System.Diagnostics.Debug.WriteLine("Connecting to collaboration");
            string parameters = "login=" + xowlLogin;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(new Uri(api + "kernel/security/login?" + parameters));
            req.CookieContainer = this.cookies;
            req.ContentType = "application/json";
            req.Method = "POST";
            string body = xowlPassword;
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(body);
            req.ContentLength = bytes.Length;
            System.IO.Stream os = req.GetRequestStream();
            os.Write(bytes, 0, bytes.Length);
            os.Close();
            try
            {
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                this.cookies.Add(resp.Cookies);
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                string r = sr.ReadToEnd().Trim();
                System.Diagnostics.Debug.WriteLine(r);
                this.isConnected = true;
                this.connectBtn.Enabled = false; //deactivate button once connected
                //TODO: retrieve info for all existing artifacts
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                this.isConnected = false;
            }
        }

        private void PushPersonBtn_Click(object sender, RibbonControlEventArgs e)
        {
            if (!isConnected)
            {
                return;
            }
            System.Diagnostics.Debug.WriteLine("Pushing data to collaboration");
            string name = "essai";
            string baseArtifact = Uri.EscapeDataString("http://xowl.org/platform/kernel/Artifact");
            string version = "1.0";
            string archetype = "com.holonshub.marketplace.domains.syseng.SysEngArchetypeRequirements";
            string parameters = $"name={name}&base={baseArtifact}&version={version}&archetype={archetype}";
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(new Uri(api + "connectors/generics/sw?" + parameters));
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
                System.Diagnostics.Debug.WriteLine(r);
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
    }
}

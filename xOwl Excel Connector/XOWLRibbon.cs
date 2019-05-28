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
        public static string api = "https://integration.xowl.org/api/";

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
            // System.Diagnostics.Debug.WriteLine("Connecting to collaboration");
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
                this.pushBtn.Enabled = true;
                this.pullBtn.Enabled = true;
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                this.isConnected = false;
            }
        }

        private void PushArtifact_Click(object sender, RibbonControlEventArgs e)
        {
            //Worksheet sheet = Globals.ThisAddIn.Application.ActiveSheet;
            new PushWizard(this.isConnected, this.cookies).Show();
        }

        private void PullArtifact_Click(object sender, RibbonControlEventArgs e)
        {
            new PullWizard(this.isConnected, this.cookies).Show();
        }
    }
}

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

        private void XOWLRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
               | SecurityProtocolType.Tls11
               | SecurityProtocolType.Tls12
               | SecurityProtocolType.Ssl3;
            XowlUtils.Connect();
        }

        private void PrefBtn_Click(object sender, RibbonControlEventArgs e) => new PrefForm().Show();

        private void PushArtifact_Click(object sender, RibbonControlEventArgs e) => new PushWizard().Show();

        private void PullArtifact_Click(object sender, RibbonControlEventArgs e) => new PullWizard().Show();
    }
}

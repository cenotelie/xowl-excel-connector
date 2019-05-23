using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace xOwl_Excel_Connector
{
    public partial class XOWLRibbon
    {

        private bool isConnected = false;

        private void PrefBtn_Click(object sender, RibbonControlEventArgs e) => new PrefForm().Show();

        private void XOWLRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void ConnectBtn_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}

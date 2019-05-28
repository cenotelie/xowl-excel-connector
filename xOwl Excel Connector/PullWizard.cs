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
            //TODO
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

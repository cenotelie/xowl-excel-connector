﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace xOwl_Excel_Connector
{
    public partial class PrefForm : Form
    {
        public PrefForm()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                string collabAddr = this.collabAddrRtb.Text.Trim();
                string activitiApi = this.activitiApiRtb.Text.Trim();//REST API
                string login = this.loginRtb.Text.Trim();
                string password = this.passwordRtb.Text.Trim();
                string baseUri = this.baseUriTB.Text.Trim();
                Properties.Settings.Default["xowlAddress"] = collabAddr;
                Properties.Settings.Default["activitiApi"] = activitiApi;
                Properties.Settings.Default["xowlLogin"] = login;
                Properties.Settings.Default["xowlPassword"] = password;
                Properties.Settings.Default["baseUri"] = baseUri;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void PrefForm_Load(object sender, EventArgs e)
        {
            this.collabAddrRtb.Text = (string)Properties.Settings.Default["xowlAddress"];
            this.activitiApiRtb.Text = (string)Properties.Settings.Default["activitiApi"];
            this.loginRtb.Text = (string)Properties.Settings.Default["xowlLogin"];
            this.passwordRtb.Text = (string)Properties.Settings.Default["xowlPassword"];
            this.baseUriTB.Text = (string)Properties.Settings.Default["baseUri"];
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XowlAddressValidating(object sender, CancelEventArgs e)
        {
            //TODO: process regex
            if (string.IsNullOrEmpty(this.collabAddrRtb.Text.Trim()))
            {
                e.Cancel = true;
                this.badAddressError.SetError(this.collabAddrRtb, "Bad address");
            }
            else
            {
                e.Cancel = false;
                this.badAddressError.SetError(this.collabAddrRtb, null);
            }
        }

        private void XowlLoginValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.loginRtb.Text.Trim()))
            {
                e.Cancel = true;
                this.badLoginError.SetError(this.loginRtb, "Bad login");
            }
            else
            {
                e.Cancel = false;
                this.badLoginError.SetError(this.loginRtb, null);
            }
        }

        private void XowlPasswordValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.passwordRtb.Text.Trim()))
            {
                e.Cancel = true;
                this.badPasswordError.SetError(this.passwordRtb, "Bad password");
            }
            else
            {
                e.Cancel = false;
                this.badPasswordError.SetError(this.passwordRtb, null);
            }
        }

    }
}

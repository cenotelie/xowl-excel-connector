namespace xOwl_Excel_Connector
{
    partial class XOWLRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public XOWLRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.xowl = this.Factory.CreateRibbonTab();
            this.connexionGroup = this.Factory.CreateRibbonGroup();
            this.prefBtn = this.Factory.CreateRibbonButton();
            this.collaborationGroup = this.Factory.CreateRibbonGroup();
            this.pullMenu = this.Factory.CreateRibbonMenu();
            this.pushMenu = this.Factory.CreateRibbonMenu();
            this.pullPersonBtn = this.Factory.CreateRibbonButton();
            this.pushPersonBtn = this.Factory.CreateRibbonButton();
            this.connectBtn = this.Factory.CreateRibbonButton();
            this.xowl.SuspendLayout();
            this.connexionGroup.SuspendLayout();
            this.collaborationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // xowl
            // 
            this.xowl.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.xowl.Groups.Add(this.connexionGroup);
            this.xowl.Groups.Add(this.collaborationGroup);
            this.xowl.Label = "xOWL";
            this.xowl.Name = "xowl";
            // 
            // connexionGroup
            // 
            this.connexionGroup.Items.Add(this.prefBtn);
            this.connexionGroup.Items.Add(this.connectBtn);
            this.connexionGroup.Label = "Connexion";
            this.connexionGroup.Name = "connexionGroup";
            // 
            // prefBtn
            // 
            this.prefBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.prefBtn.Label = "Settings";
            this.prefBtn.Name = "prefBtn";
            this.prefBtn.OfficeImageId = "EditListItems";
            this.prefBtn.ShowImage = true;
            this.prefBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PrefBtn_Click);
            // 
            // collaborationGroup
            // 
            this.collaborationGroup.Items.Add(this.pullMenu);
            this.collaborationGroup.Items.Add(this.pushMenu);
            this.collaborationGroup.Label = "Collaboration";
            this.collaborationGroup.Name = "collaborationGroup";
            // 
            // pullMenu
            // 
            this.pullMenu.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.pullMenu.Items.Add(this.pullPersonBtn);
            this.pullMenu.Label = "Pull";
            this.pullMenu.Name = "pullMenu";
            this.pullMenu.OfficeImageId = "ImportHtmlDocument";
            this.pullMenu.ShowImage = true;
            // 
            // pushMenu
            // 
            this.pushMenu.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.pushMenu.Items.Add(this.pushPersonBtn);
            this.pushMenu.Label = "Push";
            this.pushMenu.Name = "pushMenu";
            this.pushMenu.OfficeImageId = "ExportHtmlDocument";
            this.pushMenu.ShowImage = true;
            // 
            // pullPersonBtn
            // 
            this.pullPersonBtn.Label = "Pull Person";
            this.pullPersonBtn.Name = "pullPersonBtn";
            this.pullPersonBtn.ShowImage = true;
            // 
            // pushPersonBtn
            // 
            this.pushPersonBtn.Label = "Push Person";
            this.pushPersonBtn.Name = "pushPersonBtn";
            this.pushPersonBtn.ShowImage = true;
            // 
            // connectBtn
            // 
            this.connectBtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.connectBtn.Label = "Connect";
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.OfficeImageId = "ViewOnlineConnection";
            this.connectBtn.ShowImage = true;
            this.connectBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ConnectBtn_Click);
            // 
            // XOWLRibbon
            // 
            this.Name = "XOWLRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.xowl);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.XOWLRibbon_Load);
            this.xowl.ResumeLayout(false);
            this.xowl.PerformLayout();
            this.connexionGroup.ResumeLayout(false);
            this.connexionGroup.PerformLayout();
            this.collaborationGroup.ResumeLayout(false);
            this.collaborationGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab xowl;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup connexionGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup collaborationGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton prefBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu pullMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton pullPersonBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu pushMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton pushPersonBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton connectBtn;
    }

    partial class ThisRibbonCollection
    {
        internal XOWLRibbon Ribbon1
        {
            get { return this.GetRibbon<XOWLRibbon>(); }
        }
    }
}

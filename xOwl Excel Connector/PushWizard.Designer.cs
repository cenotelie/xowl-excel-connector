﻿namespace xOwl_Excel_Connector
{
    partial class PushWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.artifactNameTB = new System.Windows.Forms.TextBox();
            this.archetypeLabel = new System.Windows.Forms.Label();
            this.archetypesLB = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.pushBtn = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.artifactVersionTB = new System.Windows.Forms.TextBox();
            this.baseArtifactLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.supersededLB = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newBABtn = new System.Windows.Forms.RadioButton();
            this.existingBABtn = new System.Windows.Forms.RadioButton();
            this.baseArtifactsLB = new System.Windows.Forms.ListBox();
            this.newBATB = new System.Windows.Forms.TextBox();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.versionError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionError)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.artifactNameTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.archetypeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.archetypesLB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.versionLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.artifactVersionTB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.baseArtifactLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.supersededLB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 362);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(4, 10);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // artifactNameTB
            // 
            this.artifactNameTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.artifactNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artifactNameTB.Location = new System.Drawing.Point(140, 7);
            this.artifactNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.artifactNameTB.Name = "artifactNameTB";
            this.artifactNameTB.Size = new System.Drawing.Size(498, 22);
            this.artifactNameTB.TabIndex = 5;
            this.artifactNameTB.Validating += new System.ComponentModel.CancelEventHandler(this.ArtifactNameValidating);
            // 
            // archetypeLabel
            // 
            this.archetypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.archetypeLabel.AutoSize = true;
            this.archetypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archetypeLabel.Location = new System.Drawing.Point(4, 55);
            this.archetypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.archetypeLabel.Name = "archetypeLabel";
            this.archetypeLabel.Size = new System.Drawing.Size(69, 16);
            this.archetypeLabel.TabIndex = 3;
            this.archetypeLabel.Text = "Archetype";
            // 
            // archetypesLB
            // 
            this.archetypesLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.archetypesLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archetypesLB.FormattingEnabled = true;
            this.archetypesLB.ItemHeight = 16;
            this.archetypesLB.Items.AddRange(new object[] {
            "Requirements",
            "Functions",
            "Components"});
            this.archetypesLB.Location = new System.Drawing.Point(140, 45);
            this.archetypesLB.Margin = new System.Windows.Forms.Padding(4);
            this.archetypesLB.Name = "archetypesLB";
            this.archetypesLB.Size = new System.Drawing.Size(498, 36);
            this.archetypesLB.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.cancelBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pushBtn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(140, 328);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(498, 30);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelBtn.Location = new System.Drawing.Point(253, 4);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 22);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // pushBtn
            // 
            this.pushBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pushBtn.Location = new System.Drawing.Point(145, 4);
            this.pushBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pushBtn.Name = "pushBtn";
            this.pushBtn.Size = new System.Drawing.Size(100, 22);
            this.pushBtn.TabIndex = 0;
            this.pushBtn.Text = "Push";
            this.pushBtn.UseVisualStyleBackColor = true;
            this.pushBtn.Click += new System.EventHandler(this.PushArtifact_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(4, 298);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(54, 16);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version";
            // 
            // artifactVersionTB
            // 
            this.artifactVersionTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.artifactVersionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artifactVersionTB.Location = new System.Drawing.Point(140, 295);
            this.artifactVersionTB.Margin = new System.Windows.Forms.Padding(4);
            this.artifactVersionTB.Name = "artifactVersionTB";
            this.artifactVersionTB.Size = new System.Drawing.Size(498, 22);
            this.artifactVersionTB.TabIndex = 6;
            this.artifactVersionTB.Validating += new System.ComponentModel.CancelEventHandler(this.ArtifactVersionValidating);
            // 
            // baseArtifactLabel
            // 
            this.baseArtifactLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.baseArtifactLabel.AutoSize = true;
            this.baseArtifactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseArtifactLabel.Location = new System.Drawing.Point(4, 154);
            this.baseArtifactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baseArtifactLabel.Name = "baseArtifactLabel";
            this.baseArtifactLabel.Size = new System.Drawing.Size(83, 16);
            this.baseArtifactLabel.TabIndex = 1;
            this.baseArtifactLabel.Text = "Base Artifact";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Superseded";
            // 
            // supersededLB
            // 
            this.supersededLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.supersededLB.Enabled = false;
            this.supersededLB.FormattingEnabled = true;
            this.supersededLB.ItemHeight = 16;
            this.supersededLB.Location = new System.Drawing.Point(139, 243);
            this.supersededLB.Name = "supersededLB";
            this.supersededLB.Size = new System.Drawing.Size(499, 36);
            this.supersededLB.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.baseArtifactsLB);
            this.flowLayoutPanel1.Controls.Add(this.newBATB);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(139, 93);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 138);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newBABtn);
            this.panel1.Controls.Add(this.existingBABtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 47);
            this.panel1.TabIndex = 12;
            // 
            // newBABtn
            // 
            this.newBABtn.AutoSize = true;
            this.newBABtn.Location = new System.Drawing.Point(119, 10);
            this.newBABtn.Name = "newBABtn";
            this.newBABtn.Size = new System.Drawing.Size(88, 20);
            this.newBABtn.TabIndex = 1;
            this.newBABtn.Text = "New Base";
            this.newBABtn.UseVisualStyleBackColor = true;
            this.newBABtn.Click += new System.EventHandler(this.NewBase_Click);
            // 
            // existingBABtn
            // 
            this.existingBABtn.AutoSize = true;
            this.existingBABtn.Checked = true;
            this.existingBABtn.Location = new System.Drawing.Point(3, 10);
            this.existingBABtn.Name = "existingBABtn";
            this.existingBABtn.Size = new System.Drawing.Size(107, 20);
            this.existingBABtn.TabIndex = 0;
            this.existingBABtn.TabStop = true;
            this.existingBABtn.Text = "Existing Base";
            this.existingBABtn.UseVisualStyleBackColor = true;
            this.existingBABtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExistingBase_Click);
            // 
            // baseArtifactsLB
            // 
            this.baseArtifactsLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.baseArtifactsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseArtifactsLB.FormattingEnabled = true;
            this.baseArtifactsLB.ItemHeight = 16;
            this.baseArtifactsLB.Location = new System.Drawing.Point(4, 57);
            this.baseArtifactsLB.Margin = new System.Windows.Forms.Padding(4);
            this.baseArtifactsLB.Name = "baseArtifactsLB";
            this.baseArtifactsLB.Size = new System.Drawing.Size(495, 36);
            this.baseArtifactsLB.TabIndex = 8;
            this.baseArtifactsLB.SelectedIndexChanged += new System.EventHandler(this.BaseArtifact_Selected);
            // 
            // newBATB
            // 
            this.newBATB.Enabled = false;
            this.newBATB.Location = new System.Drawing.Point(3, 100);
            this.newBATB.Name = "newBATB";
            this.newBATB.Size = new System.Drawing.Size(497, 22);
            this.newBATB.TabIndex = 11;
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // versionError
            // 
            this.versionError.ContainerControl = this;
            // 
            // PushWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PushWizard";
            this.Text = "Push Wizard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label baseArtifactLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label archetypeLabel;
        private System.Windows.Forms.TextBox artifactNameTB;
        private System.Windows.Forms.TextBox artifactVersionTB;
        private System.Windows.Forms.ListBox archetypesLB;
        private System.Windows.Forms.ErrorProvider nameError;
        private System.Windows.Forms.ErrorProvider versionError;
        private System.Windows.Forms.Button pushBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox supersededLB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox baseArtifactsLB;
        private System.Windows.Forms.TextBox newBATB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton newBABtn;
        private System.Windows.Forms.RadioButton existingBABtn;
    }
}
namespace xOwl_Excel_Connector
{
    partial class PullWizard
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
            this.rowDispostionBtn = new System.Windows.Forms.RadioButton();
            this.colDispositionBtn = new System.Windows.Forms.RadioButton();
            this.dispositionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.pullBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.archetypesLB = new System.Windows.Forms.ListBox();
            this.archetypeLabel = new System.Windows.Forms.Label();
            this.baseArtifactLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.baseArtifactsLB = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.artifactNamesLB = new System.Windows.Forms.ListBox();
            this.artifactVersionsLB = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rowDispostionBtn
            // 
            this.rowDispostionBtn.AutoSize = true;
            this.rowDispostionBtn.Checked = true;
            this.rowDispostionBtn.Location = new System.Drawing.Point(8, 9);
            this.rowDispostionBtn.Name = "rowDispostionBtn";
            this.rowDispostionBtn.Size = new System.Drawing.Size(60, 20);
            this.rowDispostionBtn.TabIndex = 0;
            this.rowDispostionBtn.TabStop = true;
            this.rowDispostionBtn.Text = "Rows";
            this.rowDispostionBtn.UseVisualStyleBackColor = true;
            // 
            // colDispositionBtn
            // 
            this.colDispositionBtn.AutoSize = true;
            this.colDispositionBtn.Location = new System.Drawing.Point(74, 9);
            this.colDispositionBtn.Name = "colDispositionBtn";
            this.colDispositionBtn.Size = new System.Drawing.Size(53, 20);
            this.colDispositionBtn.TabIndex = 1;
            this.colDispositionBtn.Text = "Cols";
            this.colDispositionBtn.UseVisualStyleBackColor = true;
            // 
            // dispositionLabel
            // 
            this.dispositionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dispositionLabel.AutoSize = true;
            this.dispositionLabel.Location = new System.Drawing.Point(3, 190);
            this.dispositionLabel.Name = "dispositionLabel";
            this.dispositionLabel.Size = new System.Drawing.Size(75, 16);
            this.dispositionLabel.TabIndex = 16;
            this.dispositionLabel.Text = "Disposition";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(4, 102);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(4, 146);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(54, 16);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version";
            // 
            // pullBtn
            // 
            this.pullBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pullBtn.Location = new System.Drawing.Point(74, 7);
            this.pullBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pullBtn.Name = "pullBtn";
            this.pullBtn.Size = new System.Drawing.Size(100, 22);
            this.pullBtn.TabIndex = 8;
            this.pullBtn.Text = "Pull";
            this.pullBtn.UseVisualStyleBackColor = true;
            this.pullBtn.Click += new System.EventHandler(this.PullArtifact_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelBtn.Location = new System.Drawing.Point(182, 7);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 22);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // archetypesLB
            // 
            this.archetypesLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.archetypesLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archetypesLB.FormattingEnabled = true;
            this.archetypesLB.ItemHeight = 16;
            this.archetypesLB.Location = new System.Drawing.Point(125, 48);
            this.archetypesLB.Margin = new System.Windows.Forms.Padding(4);
            this.archetypesLB.Name = "archetypesLB";
            this.archetypesLB.Size = new System.Drawing.Size(355, 36);
            this.archetypesLB.TabIndex = 5;
            // 
            // archetypeLabel
            // 
            this.archetypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.archetypeLabel.AutoSize = true;
            this.archetypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archetypeLabel.Location = new System.Drawing.Point(4, 58);
            this.archetypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.archetypeLabel.Name = "archetypeLabel";
            this.archetypeLabel.Size = new System.Drawing.Size(69, 16);
            this.archetypeLabel.TabIndex = 3;
            this.archetypeLabel.Text = "Archetype";
            // 
            // baseArtifactLabel
            // 
            this.baseArtifactLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.baseArtifactLabel.AutoSize = true;
            this.baseArtifactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseArtifactLabel.Location = new System.Drawing.Point(4, 14);
            this.baseArtifactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baseArtifactLabel.Name = "baseArtifactLabel";
            this.baseArtifactLabel.Size = new System.Drawing.Size(83, 16);
            this.baseArtifactLabel.TabIndex = 1;
            this.baseArtifactLabel.Text = "Base Artifact";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.baseArtifactLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.baseArtifactsLB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.archetypeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.archetypesLB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.versionLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dispositionLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.artifactNamesLB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.artifactVersionsLB, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // baseArtifactsLB
            // 
            this.baseArtifactsLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.baseArtifactsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseArtifactsLB.FormattingEnabled = true;
            this.baseArtifactsLB.ItemHeight = 16;
            this.baseArtifactsLB.Location = new System.Drawing.Point(125, 4);
            this.baseArtifactsLB.Margin = new System.Windows.Forms.Padding(4);
            this.baseArtifactsLB.Name = "baseArtifactsLB";
            this.baseArtifactsLB.Size = new System.Drawing.Size(355, 36);
            this.baseArtifactsLB.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(124, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 36);
            this.panel2.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cancelBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pullBtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(357, 36);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.colDispositionBtn);
            this.panel1.Controls.Add(this.rowDispostionBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(124, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 38);
            this.panel1.TabIndex = 21;
            // 
            // artifactNamesLB
            // 
            this.artifactNamesLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.artifactNamesLB.Enabled = false;
            this.artifactNamesLB.FormattingEnabled = true;
            this.artifactNamesLB.ItemHeight = 16;
            this.artifactNamesLB.Location = new System.Drawing.Point(124, 92);
            this.artifactNamesLB.Name = "artifactNamesLB";
            this.artifactNamesLB.Size = new System.Drawing.Size(357, 36);
            this.artifactNamesLB.TabIndex = 22;
            // 
            // artifactVersionsLB
            // 
            this.artifactVersionsLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.artifactVersionsLB.Enabled = false;
            this.artifactVersionsLB.FormattingEnabled = true;
            this.artifactVersionsLB.ItemHeight = 16;
            this.artifactVersionsLB.Location = new System.Drawing.Point(124, 136);
            this.artifactVersionsLB.Name = "artifactVersionsLB";
            this.artifactVersionsLB.Size = new System.Drawing.Size(357, 36);
            this.artifactVersionsLB.TabIndex = 23;
            // 
            // PullWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PullWizard";
            this.Text = "Pull Wizard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.RadioButton rowDispostionBtn;
        private System.Windows.Forms.RadioButton colDispositionBtn;
        private System.Windows.Forms.Label dispositionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Button pullBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ListBox archetypesLB;
        private System.Windows.Forms.Label archetypeLabel;
        private System.Windows.Forms.Label baseArtifactLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox baseArtifactsLB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox artifactNamesLB;
        private System.Windows.Forms.ListBox artifactVersionsLB;
    }
}
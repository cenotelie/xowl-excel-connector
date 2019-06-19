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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.baseArtifactLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.pushBtn = new System.Windows.Forms.Button();
            this.archetypeLabel = new System.Windows.Forms.Label();
            this.versionsLB = new System.Windows.Forms.ListBox();
            this.archetypesLB = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.Controls.Add(this.baseArtifactLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.archetypeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.versionsLB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.archetypesLB, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // baseArtifactLabel
            // 
            this.baseArtifactLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.baseArtifactLabel.AutoSize = true;
            this.baseArtifactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseArtifactLabel.Location = new System.Drawing.Point(4, 44);
            this.baseArtifactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baseArtifactLabel.Name = "baseArtifactLabel";
            this.baseArtifactLabel.Size = new System.Drawing.Size(69, 16);
            this.baseArtifactLabel.TabIndex = 1;
            this.baseArtifactLabel.Text = "Archetype";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.cancelBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pushBtn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(139, 211);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(500, 48);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelBtn.Location = new System.Drawing.Point(254, 13);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 22);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // pushBtn
            // 
            this.pushBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pushBtn.Location = new System.Drawing.Point(146, 13);
            this.pushBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pushBtn.Name = "pushBtn";
            this.pushBtn.Size = new System.Drawing.Size(100, 22);
            this.pushBtn.TabIndex = 8;
            this.pushBtn.Text = "Pull";
            this.pushBtn.UseVisualStyleBackColor = true;
            this.pushBtn.Click += new System.EventHandler(this.PullArtifact_Click);
            // 
            // archetypeLabel
            // 
            this.archetypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.archetypeLabel.AutoSize = true;
            this.archetypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archetypeLabel.Location = new System.Drawing.Point(4, 148);
            this.archetypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.archetypeLabel.Name = "archetypeLabel";
            this.archetypeLabel.Size = new System.Drawing.Size(54, 16);
            this.archetypeLabel.TabIndex = 3;
            this.archetypeLabel.Text = "Version";
            // 
            // versionsLB
            // 
            this.versionsLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.versionsLB.Enabled = false;
            this.versionsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionsLB.FormattingEnabled = true;
            this.versionsLB.ItemHeight = 16;
            this.versionsLB.Location = new System.Drawing.Point(140, 114);
            this.versionsLB.Margin = new System.Windows.Forms.Padding(4);
            this.versionsLB.Name = "versionsLB";
            this.versionsLB.Size = new System.Drawing.Size(498, 84);
            this.versionsLB.TabIndex = 5;
            // 
            // archetypesLB
            // 
            this.archetypesLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.archetypesLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archetypesLB.FormattingEnabled = true;
            this.archetypesLB.ItemHeight = 16;
            this.archetypesLB.Location = new System.Drawing.Point(140, 10);
            this.archetypesLB.Margin = new System.Windows.Forms.Padding(4);
            this.archetypesLB.Name = "archetypesLB";
            this.archetypesLB.Size = new System.Drawing.Size(498, 84);
            this.archetypesLB.TabIndex = 16;
            this.archetypesLB.SelectedIndexChanged += new System.EventHandler(this.ArchetypeSelected);
            // 
            // PullWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(684, 262);
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label baseArtifactLabel;
        private System.Windows.Forms.Label archetypeLabel;
        private System.Windows.Forms.ListBox versionsLB;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button pushBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox archetypesLB;
    }
}
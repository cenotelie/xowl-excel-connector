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
            this.pullBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.archetypesLB = new System.Windows.Forms.ListBox();
            this.archetypeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rowDispostionBtn
            // 
            this.rowDispostionBtn.AutoSize = true;
            this.rowDispostionBtn.Checked = true;
            this.rowDispostionBtn.Location = new System.Drawing.Point(3, 8);
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
            this.colDispositionBtn.Location = new System.Drawing.Point(69, 8);
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
            this.dispositionLabel.Location = new System.Drawing.Point(3, 71);
            this.dispositionLabel.Name = "dispositionLabel";
            this.dispositionLabel.Size = new System.Drawing.Size(75, 16);
            this.dispositionLabel.TabIndex = 16;
            this.dispositionLabel.Text = "Disposition";
            // 
            // pullBtn
            // 
            this.pullBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pullBtn.Location = new System.Drawing.Point(74, 14);
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
            this.cancelBtn.Location = new System.Drawing.Point(182, 14);
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
            this.archetypesLB.Location = new System.Drawing.Point(125, 8);
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
            this.archetypeLabel.Location = new System.Drawing.Point(4, 18);
            this.archetypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.archetypeLabel.Name = "archetypeLabel";
            this.archetypeLabel.Size = new System.Drawing.Size(69, 16);
            this.archetypeLabel.TabIndex = 3;
            this.archetypeLabel.Text = "Archetype";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.archetypeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.archetypesLB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dispositionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 162);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.colDispositionBtn);
            this.panel3.Controls.Add(this.rowDispostionBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(124, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 47);
            this.panel3.TabIndex = 22;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.cancelBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pullBtn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(124, 109);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(357, 50);
            this.tableLayoutPanel3.TabIndex = 23;
            // 
            // PullWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(484, 162);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.RadioButton rowDispostionBtn;
        private System.Windows.Forms.RadioButton colDispositionBtn;
        private System.Windows.Forms.Label dispositionLabel;
        private System.Windows.Forms.Button pullBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ListBox archetypesLB;
        private System.Windows.Forms.Label archetypeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
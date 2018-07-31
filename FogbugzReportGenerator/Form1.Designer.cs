namespace FogbugzReportGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtUserToken = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdThisWeek = new System.Windows.Forms.RadioButton();
            this.RdLastWeek = new System.Windows.Forms.RadioButton();
            this.BtnVerify = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BrwReport = new System.Windows.Forms.WebBrowser();
            this.BtnGenerateReport = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.06925F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.93076F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel1.Controls.Add(this.TxtUserToken, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnVerify, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BrwReport, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnGenerateReport, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 490F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(577, 628);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TxtUserToken
            // 
            this.TxtUserToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUserToken.Location = new System.Drawing.Point(103, 17);
            this.TxtUserToken.Name = "TxtUserToken";
            this.TxtUserToken.Size = new System.Drawing.Size(278, 20);
            this.TxtUserToken.TabIndex = 1;
            this.TxtUserToken.TextChanged += new System.EventHandler(this.TxtUserTokenTextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdThisWeek);
            this.groupBox1.Controls.Add(this.RdLastWeek);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(100, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.groupBox1.Size = new System.Drawing.Size(284, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // RdThisWeek
            // 
            this.RdThisWeek.AutoSize = true;
            this.RdThisWeek.Location = new System.Drawing.Point(96, 16);
            this.RdThisWeek.Name = "RdThisWeek";
            this.RdThisWeek.Size = new System.Drawing.Size(77, 17);
            this.RdThisWeek.TabIndex = 1;
            this.RdThisWeek.Text = "This Week";
            this.RdThisWeek.UseVisualStyleBackColor = true;
            // 
            // RdLastWeek
            // 
            this.RdLastWeek.AutoSize = true;
            this.RdLastWeek.Checked = true;
            this.RdLastWeek.Location = new System.Drawing.Point(13, 16);
            this.RdLastWeek.Name = "RdLastWeek";
            this.RdLastWeek.Size = new System.Drawing.Size(77, 17);
            this.RdLastWeek.TabIndex = 0;
            this.RdLastWeek.TabStop = true;
            this.RdLastWeek.Text = "Last Week";
            this.RdLastWeek.UseVisualStyleBackColor = true;
            // 
            // BtnVerify
            // 
            this.BtnVerify.Location = new System.Drawing.Point(387, 17);
            this.BtnVerify.Name = "BtnVerify";
            this.BtnVerify.Size = new System.Drawing.Size(184, 23);
            this.BtnVerify.TabIndex = 3;
            this.BtnVerify.Text = "Verify";
            this.BtnVerify.Click += new System.EventHandler(this.BtnVerifyClick);
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 3);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(577, 21);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LblStatus
            // 
            this.LblStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(16, 16);
            this.LblStatus.Text = "...";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 43);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Report Type:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 25);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "User Token:";
            // 
            // BrwReport
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.BrwReport, 3);
            this.BrwReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrwReport.Location = new System.Drawing.Point(3, 120);
            this.BrwReport.MinimumSize = new System.Drawing.Size(20, 20);
            this.BrwReport.Name = "BrwReport";
            this.BrwReport.Size = new System.Drawing.Size(571, 484);
            this.BrwReport.TabIndex = 8;
            // 
            // BtnGenerateReport
            // 
            this.BtnGenerateReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGenerateReport.Location = new System.Drawing.Point(387, 48);
            this.BtnGenerateReport.Name = "BtnGenerateReport";
            this.BtnGenerateReport.Size = new System.Drawing.Size(187, 43);
            this.BtnGenerateReport.TabIndex = 9;
            this.BtnGenerateReport.Text = "Generate";
            this.BtnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReportClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 628);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FogBugz Report Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TxtUserToken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdThisWeek;
        private System.Windows.Forms.RadioButton RdLastWeek;
        private DevExpress.XtraEditors.SimpleButton BtnVerify;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.WebBrowser BrwReport;
        private DevExpress.XtraEditors.SimpleButton BtnGenerateReport;
    }
}


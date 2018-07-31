namespace FogbugzReportGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtUserToken = new System.Windows.Forms.TextBox();
            this.BtnVerify = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BrwReport = new System.Windows.Forms.WebBrowser();
            this.BtnGenerateReport = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtExcludedWords = new System.Windows.Forms.TextBox();
            this.RdGroupReportType = new DevExpress.XtraEditors.RadioGroup();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RdGroupReportType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.02532F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.97468F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.Controls.Add(this.TxtUserToken, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnVerify, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BrwReport, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnGenerateReport, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtExcludedWords, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.RdGroupReportType, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 472F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 658);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TxtUserToken
            // 
            this.TxtUserToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUserToken.Location = new System.Drawing.Point(219, 23);
            this.TxtUserToken.Name = "TxtUserToken";
            this.TxtUserToken.Size = new System.Drawing.Size(291, 20);
            this.TxtUserToken.TabIndex = 1;
            this.TxtUserToken.TextChanged += new System.EventHandler(this.TxtUserTokenTextChanged);
            // 
            // BtnVerify
            // 
            this.BtnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnVerify.Location = new System.Drawing.Point(516, 23);
            this.BtnVerify.Name = "BtnVerify";
            this.BtnVerify.Size = new System.Drawing.Size(158, 24);
            this.BtnVerify.TabIndex = 3;
            this.BtnVerify.Text = "Verify";
            this.BtnVerify.Click += new System.EventHandler(this.BtnVerifyClick);
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 3);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 636);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(677, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LblStatus
            // 
            this.LblStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(210, 24);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Report Type:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(210, 24);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "User Token:";
            // 
            // BrwReport
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.BrwReport, 3);
            this.BrwReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrwReport.Location = new System.Drawing.Point(3, 141);
            this.BrwReport.MinimumSize = new System.Drawing.Size(20, 20);
            this.BrwReport.Name = "BrwReport";
            this.tableLayoutPanel1.SetRowSpan(this.BrwReport, 2);
            this.BrwReport.Size = new System.Drawing.Size(671, 486);
            this.BrwReport.TabIndex = 8;
            // 
            // BtnGenerateReport
            // 
            this.BtnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerateReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGenerateReport.Location = new System.Drawing.Point(516, 83);
            this.BtnGenerateReport.Name = "BtnGenerateReport";
            this.BtnGenerateReport.Size = new System.Drawing.Size(158, 24);
            this.BtnGenerateReport.TabIndex = 9;
            this.BtnGenerateReport.Text = "Generate Report";
            this.BtnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReportClick);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(3, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(210, 24);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Exclude Cases that contains:";
            // 
            // TxtExcludedWords
            // 
            this.TxtExcludedWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtExcludedWords.Location = new System.Drawing.Point(219, 83);
            this.TxtExcludedWords.Name = "TxtExcludedWords";
            this.TxtExcludedWords.Size = new System.Drawing.Size(291, 20);
            this.TxtExcludedWords.TabIndex = 11;
            this.TxtExcludedWords.TextChanged += new System.EventHandler(this.TxtExcludedWordsTextChanged);
            // 
            // RdGroupReportType
            // 
            this.RdGroupReportType.EditValue = 0;
            this.RdGroupReportType.Location = new System.Drawing.Point(219, 53);
            this.RdGroupReportType.Name = "RdGroupReportType";
            this.RdGroupReportType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Last Week"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "This Week")});
            this.RdGroupReportType.Size = new System.Drawing.Size(291, 24);
            this.RdGroupReportType.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 658);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FogBugz Report Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RdGroupReportType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TxtUserToken;
        private DevExpress.XtraEditors.SimpleButton BtnVerify;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.WebBrowser BrwReport;
        private DevExpress.XtraEditors.SimpleButton BtnGenerateReport;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox TxtExcludedWords;
        private DevExpress.XtraEditors.RadioGroup RdGroupReportType;
    }
}


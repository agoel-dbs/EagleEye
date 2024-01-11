namespace EagleEye.Administration
{
    partial class frmAdminTasks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminTasks));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnProcessVendor = new System.Windows.Forms.Button();
            this.btnDBScripts = new System.Windows.Forms.Button();
            this.btnBuyerLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbEdit = new System.Windows.Forms.TabPage();
            this.rtxtRemarks = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTransasactionDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.grdReportDetails = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdLicenceValidity = new System.Windows.Forms.Button();
            this.btnLicenseKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnGenerateExpiry = new System.Windows.Forms.Button();
            this.btnGenerateLicLey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportDetails)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnProcessVendor);
            this.pnlMain.Controls.Add(this.btnDBScripts);
            this.pnlMain.Controls.Add(this.btnBuyerLoad);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.lblFormHeader);
            this.pnlMain.Location = new System.Drawing.Point(39, 43);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(748, 499);
            this.pnlMain.TabIndex = 46;
            // 
            // btnProcessVendor
            // 
            this.btnProcessVendor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProcessVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessVendor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnProcessVendor.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnProcessVendor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessVendor.Location = new System.Drawing.Point(315, 452);
            this.btnProcessVendor.Name = "btnProcessVendor";
            this.btnProcessVendor.Size = new System.Drawing.Size(157, 30);
            this.btnProcessVendor.TabIndex = 124;
            this.btnProcessVendor.Text = "  &Process Vendor Data";
            this.btnProcessVendor.UseVisualStyleBackColor = false;
            this.btnProcessVendor.Click += new System.EventHandler(this.BtnProcessVendor_Click);
            // 
            // btnDBScripts
            // 
            this.btnDBScripts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDBScripts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBScripts.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDBScripts.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnDBScripts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDBScripts.Location = new System.Drawing.Point(472, 451);
            this.btnDBScripts.Name = "btnDBScripts";
            this.btnDBScripts.Size = new System.Drawing.Size(157, 30);
            this.btnDBScripts.TabIndex = 123;
            this.btnDBScripts.Text = "    &Process DB Scripts";
            this.btnDBScripts.UseVisualStyleBackColor = false;
            this.btnDBScripts.Click += new System.EventHandler(this.BtnDBScripts_Click);
            // 
            // btnBuyerLoad
            // 
            this.btnBuyerLoad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuyerLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyerLoad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBuyerLoad.Image = global::EagleEye.Properties.Resources.img_load;
            this.btnBuyerLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuyerLoad.Location = new System.Drawing.Point(29, 451);
            this.btnBuyerLoad.Name = "btnBuyerLoad";
            this.btnBuyerLoad.Size = new System.Drawing.Size(128, 30);
            this.btnBuyerLoad.TabIndex = 122;
            this.btnBuyerLoad.Text = "    &Load From File";
            this.btnBuyerLoad.UseVisualStyleBackColor = false;
            this.btnBuyerLoad.Click += new System.EventHandler(this.BtnBuyerLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(157, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 30);
            this.btnSave.TabIndex = 121;
            this.btnSave.Text = "    &Process Buyer Data";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbEdit);
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Location = new System.Drawing.Point(29, 58);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(699, 383);
            this.tabMain.TabIndex = 90;
            // 
            // tbEdit
            // 
            this.tbEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.tbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEdit.Controls.Add(this.rtxtRemarks);
            this.tbEdit.Controls.Add(this.label4);
            this.tbEdit.Controls.Add(this.dtTransasactionDate);
            this.tbEdit.Controls.Add(this.label3);
            this.tbEdit.Controls.Add(this.grdReportDetails);
            this.tbEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEdit.Location = new System.Drawing.Point(4, 22);
            this.tbEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEdit.Size = new System.Drawing.Size(691, 357);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.Text = "Load Buyer Data";
            // 
            // rtxtRemarks
            // 
            this.rtxtRemarks.Location = new System.Drawing.Point(366, 27);
            this.rtxtRemarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtRemarks.Name = "rtxtRemarks";
            this.rtxtRemarks.Size = new System.Drawing.Size(323, 18);
            this.rtxtRemarks.TabIndex = 122;
            this.rtxtRemarks.Text = "Outsatnding Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(269, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 123;
            this.label4.Text = "Remarks";
            // 
            // dtTransasactionDate
            // 
            this.dtTransasactionDate.Location = new System.Drawing.Point(109, 24);
            this.dtTransasactionDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtTransasactionDate.Name = "dtTransasactionDate";
            this.dtTransasactionDate.Size = new System.Drawing.Size(143, 20);
            this.dtTransasactionDate.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 120;
            this.label3.Text = "Transaction Date";
            // 
            // grdReportDetails
            // 
            this.grdReportDetails.AllowUserToAddRows = false;
            this.grdReportDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdReportDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReportDetails.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdReportDetails.Location = new System.Drawing.Point(10, 61);
            this.grdReportDetails.Name = "grdReportDetails";
            this.grdReportDetails.ReadOnly = true;
            this.grdReportDetails.RowHeadersVisible = false;
            this.grdReportDetails.RowHeadersWidth = 62;
            this.grdReportDetails.Size = new System.Drawing.Size(678, 279);
            this.grdReportDetails.TabIndex = 119;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SandyBrown;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmdLicenceValidity);
            this.tabPage1.Controls.Add(this.btnLicenseKey);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtOutput);
            this.tabPage1.Controls.Add(this.btnGenerateExpiry);
            this.tabPage1.Controls.Add(this.btnGenerateLicLey);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtInput);
            this.tabPage1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(691, 357);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Get Other Info";
            // 
            // cmdLicenceValidity
            // 
            this.cmdLicenceValidity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdLicenceValidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdLicenceValidity.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmdLicenceValidity.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.cmdLicenceValidity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdLicenceValidity.Location = new System.Drawing.Point(355, 207);
            this.cmdLicenceValidity.Name = "cmdLicenceValidity";
            this.cmdLicenceValidity.Size = new System.Drawing.Size(157, 30);
            this.cmdLicenceValidity.TabIndex = 129;
            this.cmdLicenceValidity.Text = "    &Get License Validity";
            this.cmdLicenceValidity.UseVisualStyleBackColor = false;
            this.cmdLicenceValidity.Click += new System.EventHandler(this.cmdLicenceValidity_Click);
            // 
            // btnLicenseKey
            // 
            this.btnLicenseKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLicenseKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLicenseKey.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLicenseKey.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnLicenseKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLicenseKey.Location = new System.Drawing.Point(159, 201);
            this.btnLicenseKey.Name = "btnLicenseKey";
            this.btnLicenseKey.Size = new System.Drawing.Size(157, 30);
            this.btnLicenseKey.TabIndex = 128;
            this.btnLicenseKey.Text = "    &Get License Key";
            this.btnLicenseKey.UseVisualStyleBackColor = false;
            this.btnLicenseKey.Click += new System.EventHandler(this.btnLicenseKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 127;
            this.label2.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(251, 66);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(221, 20);
            this.txtOutput.TabIndex = 126;
            // 
            // btnGenerateExpiry
            // 
            this.btnGenerateExpiry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerateExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateExpiry.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGenerateExpiry.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnGenerateExpiry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateExpiry.Location = new System.Drawing.Point(355, 141);
            this.btnGenerateExpiry.Name = "btnGenerateExpiry";
            this.btnGenerateExpiry.Size = new System.Drawing.Size(157, 30);
            this.btnGenerateExpiry.TabIndex = 125;
            this.btnGenerateExpiry.Text = "    Set &ExpiryKey";
            this.btnGenerateExpiry.UseVisualStyleBackColor = false;
            this.btnGenerateExpiry.Click += new System.EventHandler(this.BtnGenerateExpiry_Click);
            // 
            // btnGenerateLicLey
            // 
            this.btnGenerateLicLey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerateLicLey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateLicLey.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGenerateLicLey.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnGenerateLicLey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateLicLey.Location = new System.Drawing.Point(159, 141);
            this.btnGenerateLicLey.Name = "btnGenerateLicLey";
            this.btnGenerateLicLey.Size = new System.Drawing.Size(157, 30);
            this.btnGenerateLicLey.TabIndex = 124;
            this.btnGenerateLicLey.Text = "    &Set License Key";
            this.btnGenerateLicLey.UseVisualStyleBackColor = false;
            this.btnGenerateLicLey.Click += new System.EventHandler(this.BtnGenerateLicLey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Text";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(251, 32);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(221, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Image = global::EagleEye.Properties.Resources.img_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(629, 451);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 120;
            this.btnExit.Text = "   &Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFormHeader.Location = new System.Drawing.Point(189, 0);
            this.lblFormHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(67, 15);
            this.lblFormHeader.TabIndex = 89;
            this.lblFormHeader.Text = "Header";
            this.lblFormHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAdminTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(817, 522);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdminTasks";
            this.Text = "Admin Tasks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdminTasks_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbEdit.ResumeLayout(false);
            this.tbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportDetails)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbEdit;
        private System.Windows.Forms.DataGridView grdReportDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnBuyerLoad;
        private System.Windows.Forms.Button btnDBScripts;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGenerateExpiry;
        private System.Windows.Forms.Button btnGenerateLicLey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTransasactionDate;
        private System.Windows.Forms.RichTextBox rtxtRemarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLicenseKey;
        private System.Windows.Forms.Button btnProcessVendor;
        private System.Windows.Forms.Button cmdLicenceValidity;
    }
}
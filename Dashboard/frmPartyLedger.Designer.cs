namespace EagleEye.Dashboard
{
    partial class frmPartyLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartyLedger));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnExportSummary = new System.Windows.Forms.Button();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbEdit = new System.Windows.Forms.TabPage();
            this.chkIncludeSale = new System.Windows.Forms.CheckBox();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.cmbBuyer = new System.Windows.Forms.ComboBox();
            this.grdReportDetails = new System.Windows.Forms.DataGridView();
            this.Summary = new System.Windows.Forms.TabPage();
            this.grdReportAggtillDate = new System.Windows.Forms.DataGridView();
            this.grdReportAgg = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnUpdatePartyLedger = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportDetails)).BeginInit();
            this.Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportAggtillDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportAgg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnUpdatePartyLedger);
            this.pnlMain.Controls.Add(this.btnExportSummary);
            this.pnlMain.Controls.Add(this.btnExcelExport);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.lblFormHeader);
            this.pnlMain.Location = new System.Drawing.Point(48, 24);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1034, 540);
            this.pnlMain.TabIndex = 45;
            // 
            // btnExportSummary
            // 
            this.btnExportSummary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExportSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportSummary.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExportSummary.Image = ((System.Drawing.Image)(resources.GetObject("btnExportSummary.Image")));
            this.btnExportSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportSummary.Location = new System.Drawing.Point(718, 494);
            this.btnExportSummary.Name = "btnExportSummary";
            this.btnExportSummary.Size = new System.Drawing.Size(153, 30);
            this.btnExportSummary.TabIndex = 96;
            this.btnExportSummary.Text = "   &Export Summary";
            this.btnExportSummary.UseVisualStyleBackColor = false;
            this.btnExportSummary.Click += new System.EventHandler(this.btnExportSummary_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcelExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcelExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcelExport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExcelExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.Image")));
            this.btnExcelExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelExport.Location = new System.Drawing.Point(554, 494);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(139, 30);
            this.btnExcelExport.TabIndex = 95;
            this.btnExcelExport.Text = "   &Export Ledger";
            this.btnExcelExport.UseVisualStyleBackColor = false;
            this.btnExcelExport.Click += new System.EventHandler(this.BtnExcelExport_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(429, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "    &Proceed";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbEdit);
            this.tabMain.Controls.Add(this.Summary);
            this.tabMain.Location = new System.Drawing.Point(29, 64);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(986, 425);
            this.tabMain.TabIndex = 90;
            // 
            // tbEdit
            // 
            this.tbEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.tbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEdit.Controls.Add(this.chkIncludeSale);
            this.tbEdit.Controls.Add(this.dtToDate);
            this.tbEdit.Controls.Add(this.label1);
            this.tbEdit.Controls.Add(this.dtFromDate);
            this.tbEdit.Controls.Add(this.lblEmailId);
            this.tbEdit.Controls.Add(this.lblBuyer);
            this.tbEdit.Controls.Add(this.cmbBuyer);
            this.tbEdit.Controls.Add(this.grdReportDetails);
            this.tbEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEdit.Location = new System.Drawing.Point(4, 22);
            this.tbEdit.Margin = new System.Windows.Forms.Padding(2);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Padding = new System.Windows.Forms.Padding(2);
            this.tbEdit.Size = new System.Drawing.Size(978, 399);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.Text = "Party Ledger Details";
            // 
            // chkIncludeSale
            // 
            this.chkIncludeSale.AutoSize = true;
            this.chkIncludeSale.Checked = true;
            this.chkIncludeSale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeSale.Location = new System.Drawing.Point(718, 32);
            this.chkIncludeSale.Name = "chkIncludeSale";
            this.chkIncludeSale.Size = new System.Drawing.Size(85, 17);
            this.chkIncludeSale.TabIndex = 126;
            this.chkIncludeSale.Text = "Include Sale";
            this.chkIncludeSale.UseVisualStyleBackColor = true;
            // 
            // dtToDate
            // 
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToDate.Location = new System.Drawing.Point(545, 30);
            this.dtToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(130, 20);
            this.dtToDate.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(494, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "To Date";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromDate.Location = new System.Drawing.Point(351, 30);
            this.dtFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(130, 20);
            this.dtFromDate.TabIndex = 122;
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmailId.Location = new System.Drawing.Point(286, 32);
            this.lblEmailId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(63, 13);
            this.lblEmailId.TabIndex = 123;
            this.lblEmailId.Text = "From date";
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBuyer.Location = new System.Drawing.Point(7, 32);
            this.lblBuyer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(79, 13);
            this.lblBuyer.TabIndex = 121;
            this.lblBuyer.Text = "Select Buyer";
            // 
            // cmbBuyer
            // 
            this.cmbBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuyer.FormattingEnabled = true;
            this.cmbBuyer.Location = new System.Drawing.Point(91, 29);
            this.cmbBuyer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBuyer.Name = "cmbBuyer";
            this.cmbBuyer.Size = new System.Drawing.Size(169, 21);
            this.cmbBuyer.TabIndex = 120;
            this.cmbBuyer.SelectedIndexChanged += new System.EventHandler(this.CmbBuyer_SelectedIndexChanged);
            // 
            // grdReportDetails
            // 
            this.grdReportDetails.AllowUserToAddRows = false;
            this.grdReportDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.grdReportDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReportDetails.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdReportDetails.Location = new System.Drawing.Point(16, 70);
            this.grdReportDetails.Name = "grdReportDetails";
            this.grdReportDetails.ReadOnly = true;
            this.grdReportDetails.RowHeadersVisible = false;
            this.grdReportDetails.Size = new System.Drawing.Size(944, 326);
            this.grdReportDetails.TabIndex = 119;
            // 
            // Summary
            // 
            this.Summary.BackColor = System.Drawing.Color.SandyBrown;
            this.Summary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Summary.Controls.Add(this.grdReportAggtillDate);
            this.Summary.Controls.Add(this.grdReportAgg);
            this.Summary.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Summary.Location = new System.Drawing.Point(4, 22);
            this.Summary.Name = "Summary";
            this.Summary.Padding = new System.Windows.Forms.Padding(3);
            this.Summary.Size = new System.Drawing.Size(978, 399);
            this.Summary.TabIndex = 1;
            this.Summary.Text = "Summary";
            // 
            // grdReportAggtillDate
            // 
            this.grdReportAggtillDate.AllowUserToAddRows = false;
            this.grdReportAggtillDate.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportAggtillDate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportAggtillDate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grdReportAggtillDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReportAggtillDate.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdReportAggtillDate.Location = new System.Drawing.Point(488, 16);
            this.grdReportAggtillDate.Name = "grdReportAggtillDate";
            this.grdReportAggtillDate.ReadOnly = true;
            this.grdReportAggtillDate.RowHeadersVisible = false;
            this.grdReportAggtillDate.Size = new System.Drawing.Size(474, 375);
            this.grdReportAggtillDate.TabIndex = 128;
            // 
            // grdReportAgg
            // 
            this.grdReportAgg.AllowUserToAddRows = false;
            this.grdReportAgg.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportAgg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportAgg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grdReportAgg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReportAgg.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdReportAgg.Location = new System.Drawing.Point(6, 16);
            this.grdReportAgg.Name = "grdReportAgg";
            this.grdReportAgg.ReadOnly = true;
            this.grdReportAgg.RowHeadersVisible = false;
            this.grdReportAgg.Size = new System.Drawing.Size(476, 375);
            this.grdReportAgg.TabIndex = 127;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Image = global::EagleEye.Properties.Resources.img_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(896, 494);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 92;
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
            // btnUpdatePartyLedger
            // 
            this.btnUpdatePartyLedger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdatePartyLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePartyLedger.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdatePartyLedger.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnUpdatePartyLedger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePartyLedger.Location = new System.Drawing.Point(213, 494);
            this.btnUpdatePartyLedger.Name = "btnUpdatePartyLedger";
            this.btnUpdatePartyLedger.Size = new System.Drawing.Size(199, 30);
            this.btnUpdatePartyLedger.TabIndex = 97;
            this.btnUpdatePartyLedger.Text = "Update Party Ledger";
            this.btnUpdatePartyLedger.UseVisualStyleBackColor = false;
            this.btnUpdatePartyLedger.Click += new System.EventHandler(this.btnUpdatePartyLedger_Click);
            // 
            // frmPartyLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1131, 625);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPartyLedger";
            this.Text = "Party Ledger Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPartyLedger_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbEdit.ResumeLayout(false);
            this.tbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportDetails)).EndInit();
            this.Summary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReportAggtillDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportAgg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbEdit;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.ComboBox cmbBuyer;
        private System.Windows.Forms.DataGridView grdReportDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnExcelExport;
        private System.Windows.Forms.TabPage Summary;
        private System.Windows.Forms.DataGridView grdReportAgg;
        private System.Windows.Forms.Button btnExportSummary;
        private System.Windows.Forms.DataGridView grdReportAggtillDate;
        private System.Windows.Forms.CheckBox chkIncludeSale;
        private System.Windows.Forms.Button btnUpdatePartyLedger;
    }
}
namespace EagleEye.Dashboard
{
    partial class frmVendorLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendorLedger));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbEdit = new System.Windows.Forms.TabPage();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.grdReportAgg = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.grdReportDetails = new System.Windows.Forms.DataGridView();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportAgg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.lblFormHeader);
            this.pnlMain.Location = new System.Drawing.Point(88, 20);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1052, 542);
            this.pnlMain.TabIndex = 46;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbEdit);
            this.tabMain.Location = new System.Drawing.Point(29, 64);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1003, 464);
            this.tabMain.TabIndex = 90;
            // 
            // tbEdit
            // 
            this.tbEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.tbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEdit.Controls.Add(this.btnExcelExport);
            this.tbEdit.Controls.Add(this.grdReportAgg);
            this.tbEdit.Controls.Add(this.btnSave);
            this.tbEdit.Controls.Add(this.dtToDate);
            this.tbEdit.Controls.Add(this.label1);
            this.tbEdit.Controls.Add(this.btnExit);
            this.tbEdit.Controls.Add(this.dtFromDate);
            this.tbEdit.Controls.Add(this.lblEmailId);
            this.tbEdit.Controls.Add(this.lblBuyer);
            this.tbEdit.Controls.Add(this.cmbVendor);
            this.tbEdit.Controls.Add(this.grdReportDetails);
            this.tbEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEdit.Location = new System.Drawing.Point(4, 22);
            this.tbEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEdit.Size = new System.Drawing.Size(995, 438);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.Text = "Vendor Ledger Details";
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcelExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcelExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcelExport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExcelExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.Image")));
            this.btnExcelExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelExport.Location = new System.Drawing.Point(786, 21);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(97, 30);
            this.btnExcelExport.TabIndex = 95;
            this.btnExcelExport.Text = "   &Export";
            this.btnExcelExport.UseVisualStyleBackColor = false;
            this.btnExcelExport.Click += new System.EventHandler(this.BtnExcelExport_Click);
            // 
            // grdReportAgg
            // 
            this.grdReportAgg.AllowUserToAddRows = false;
            this.grdReportAgg.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportAgg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportAgg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdReportAgg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReportAgg.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdReportAgg.Location = new System.Drawing.Point(12, 70);
            this.grdReportAgg.Name = "grdReportAgg";
            this.grdReportAgg.ReadOnly = true;
            this.grdReportAgg.RowHeadersVisible = false;
            this.grdReportAgg.Size = new System.Drawing.Size(377, 369);
            this.grdReportAgg.TabIndex = 126;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(677, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 30);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "    &Proceed";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dtToDate
            // 
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToDate.Location = new System.Drawing.Point(540, 28);
            this.dtToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(107, 20);
            this.dtToDate.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(489, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "To Date";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Image = global::EagleEye.Properties.Resources.img_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(888, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 30);
            this.btnExit.TabIndex = 92;
            this.btnExit.Text = "   &Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // dtFromDate
            // 
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromDate.Location = new System.Drawing.Point(351, 30);
            this.dtFromDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(107, 20);
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
            this.lblBuyer.Size = new System.Drawing.Size(87, 13);
            this.lblBuyer.TabIndex = 121;
            this.lblBuyer.Text = "Select Vendor";
            // 
            // cmbVendor
            // 
            this.cmbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(96, 29);
            this.cmbVendor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(169, 21);
            this.cmbVendor.TabIndex = 120;
            this.cmbVendor.SelectedIndexChanged += new System.EventHandler(this.CmbBuyer_SelectedIndexChanged);
            // 
            // grdReportDetails
            // 
            this.grdReportDetails.AllowUserToAddRows = false;
            this.grdReportDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReportDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdReportDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReportDetails.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdReportDetails.Location = new System.Drawing.Point(390, 70);
            this.grdReportDetails.Name = "grdReportDetails";
            this.grdReportDetails.ReadOnly = true;
            this.grdReportDetails.RowHeadersVisible = false;
            this.grdReportDetails.Size = new System.Drawing.Size(595, 369);
            this.grdReportDetails.TabIndex = 119;
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
            // frmVendorLedger
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1259, 487);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendorLedger";
            this.Text = "Vendor Ledger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVendorLedger_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbEdit.ResumeLayout(false);
            this.tbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportAgg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbEdit;
        private System.Windows.Forms.DataGridView grdReportAgg;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.ComboBox cmbVendor;
        private System.Windows.Forms.DataGridView grdReportDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnExcelExport;
    }
}
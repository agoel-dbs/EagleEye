namespace EagleEye.Dashboard
{
    partial class frmCashLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashLedger));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnShowDaily = new System.Windows.Forms.Button();
            this.btnGenerateDaily = new System.Windows.Forms.Button();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbEdit = new System.Windows.Forms.TabPage();
            this.lblCashInHand = new System.Windows.Forms.Label();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.cmbSubHead = new System.Windows.Forms.ComboBox();
            this.grdReportDetails = new System.Windows.Forms.DataGridView();
            this.tbDaily = new System.Windows.Forms.TabPage();
            this.dtDailyDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grdDaily = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportDetails)).BeginInit();
            this.tbDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDaily)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnShowDaily);
            this.pnlMain.Controls.Add(this.btnGenerateDaily);
            this.pnlMain.Controls.Add(this.btnExcelExport);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.lblFormHeader);
            this.pnlMain.Location = new System.Drawing.Point(19, 20);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1338, 825);
            this.pnlMain.TabIndex = 45;
            // 
            // btnShowDaily
            // 
            this.btnShowDaily.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowDaily.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnShowDaily.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnShowDaily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowDaily.Location = new System.Drawing.Point(701, 760);
            this.btnShowDaily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowDaily.Name = "btnShowDaily";
            this.btnShowDaily.Size = new System.Drawing.Size(228, 46);
            this.btnShowDaily.TabIndex = 96;
            this.btnShowDaily.Text = "    &Show Daily Report";
            this.btnShowDaily.UseVisualStyleBackColor = false;
            this.btnShowDaily.Click += new System.EventHandler(this.BtnShowDaily_Click);
            // 
            // btnGenerateDaily
            // 
            this.btnGenerateDaily.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerateDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateDaily.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGenerateDaily.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnGenerateDaily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateDaily.Location = new System.Drawing.Point(424, 760);
            this.btnGenerateDaily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateDaily.Name = "btnGenerateDaily";
            this.btnGenerateDaily.Size = new System.Drawing.Size(237, 46);
            this.btnGenerateDaily.TabIndex = 95;
            this.btnGenerateDaily.Text = "    &Generate Daily";
            this.btnGenerateDaily.UseVisualStyleBackColor = false;
            this.btnGenerateDaily.Click += new System.EventHandler(this.BtnGenerateDaily_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcelExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcelExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcelExport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExcelExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.Image")));
            this.btnExcelExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelExport.Location = new System.Drawing.Point(969, 760);
            this.btnExcelExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(140, 46);
            this.btnExcelExport.TabIndex = 94;
            this.btnExcelExport.Text = "   &Export";
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
            this.btnSave.Location = new System.Drawing.Point(141, 760);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(243, 46);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "    &Show Ledger Report";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbEdit);
            this.tabMain.Controls.Add(this.tbDaily);
            this.tabMain.Location = new System.Drawing.Point(44, 98);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1256, 654);
            this.tabMain.TabIndex = 90;
            // 
            // tbEdit
            // 
            this.tbEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.tbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEdit.Controls.Add(this.lblCashInHand);
            this.tbEdit.Controls.Add(this.dtToDate);
            this.tbEdit.Controls.Add(this.label1);
            this.tbEdit.Controls.Add(this.dtFromDate);
            this.tbEdit.Controls.Add(this.lblEmailId);
            this.tbEdit.Controls.Add(this.lblBuyer);
            this.tbEdit.Controls.Add(this.cmbSubHead);
            this.tbEdit.Controls.Add(this.grdReportDetails);
            this.tbEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEdit.Location = new System.Drawing.Point(4, 29);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tbEdit.Size = new System.Drawing.Size(1248, 621);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.Text = "Cash Ledger Report";
            // 
            // lblCashInHand
            // 
            this.lblCashInHand.AutoSize = true;
            this.lblCashInHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashInHand.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCashInHand.Location = new System.Drawing.Point(1014, 51);
            this.lblCashInHand.Name = "lblCashInHand";
            this.lblCashInHand.Size = new System.Drawing.Size(0, 20);
            this.lblCashInHand.TabIndex = 126;
            // 
            // dtToDate
            // 
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToDate.Location = new System.Drawing.Point(805, 46);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(193, 26);
            this.dtToDate.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(706, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 125;
            this.label1.Text = "To Date";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromDate.Location = new System.Drawing.Point(503, 46);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(193, 26);
            this.dtFromDate.TabIndex = 122;
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmailId.Location = new System.Drawing.Point(394, 49);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(91, 20);
            this.lblEmailId.TabIndex = 123;
            this.lblEmailId.Text = "From date";
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBuyer.Location = new System.Drawing.Point(11, 49);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(108, 20);
            this.lblBuyer.TabIndex = 121;
            this.lblBuyer.Text = "Select Head";
            // 
            // cmbSubHead
            // 
            this.cmbSubHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubHead.FormattingEnabled = true;
            this.cmbSubHead.Location = new System.Drawing.Point(136, 45);
            this.cmbSubHead.Name = "cmbSubHead";
            this.cmbSubHead.Size = new System.Drawing.Size(252, 28);
            this.cmbSubHead.TabIndex = 120;
            this.cmbSubHead.SelectedIndexChanged += new System.EventHandler(this.CmbBuyer_SelectedIndexChanged);
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
            this.grdReportDetails.Location = new System.Drawing.Point(15, 94);
            this.grdReportDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdReportDetails.Name = "grdReportDetails";
            this.grdReportDetails.ReadOnly = true;
            this.grdReportDetails.RowHeadersVisible = false;
            this.grdReportDetails.Size = new System.Drawing.Size(1206, 503);
            this.grdReportDetails.TabIndex = 119;
            // 
            // tbDaily
            // 
            this.tbDaily.BackColor = System.Drawing.Color.SandyBrown;
            this.tbDaily.Controls.Add(this.dtDailyDate);
            this.tbDaily.Controls.Add(this.label2);
            this.tbDaily.Controls.Add(this.grdDaily);
            this.tbDaily.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbDaily.Location = new System.Drawing.Point(4, 29);
            this.tbDaily.Name = "tbDaily";
            this.tbDaily.Size = new System.Drawing.Size(1248, 621);
            this.tbDaily.TabIndex = 1;
            this.tbDaily.Text = "Generate Daily";
            // 
            // dtDailyDate
            // 
            this.dtDailyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDailyDate.Location = new System.Drawing.Point(176, 36);
            this.dtDailyDate.Name = "dtDailyDate";
            this.dtDailyDate.Size = new System.Drawing.Size(193, 26);
            this.dtDailyDate.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(29, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 126;
            this.label2.Text = "Daily - Date";
            // 
            // grdDaily
            // 
            this.grdDaily.AllowUserToAddRows = false;
            this.grdDaily.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDaily.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDaily.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDaily.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdDaily.Location = new System.Drawing.Point(21, 83);
            this.grdDaily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdDaily.Name = "grdDaily";
            this.grdDaily.ReadOnly = true;
            this.grdDaily.RowHeadersVisible = false;
            this.grdDaily.Size = new System.Drawing.Size(1206, 503);
            this.grdDaily.TabIndex = 124;
            this.grdDaily.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GrdDaily_CellFormatting);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Image = global::EagleEye.Properties.Resources.img_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1149, 760);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 92;
            this.btnExit.Text = "   &Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFormHeader.Location = new System.Drawing.Point(284, 0);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(100, 23);
            this.lblFormHeader.TabIndex = 89;
            this.lblFormHeader.Text = "Header";
            this.lblFormHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCashLedger
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1377, 864);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCashLedger";
            this.Text = "Cash Ledger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCashLedger_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbEdit.ResumeLayout(false);
            this.tbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportDetails)).EndInit();
            this.tbDaily.ResumeLayout(false);
            this.tbDaily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDaily)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnExcelExport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbEdit;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.ComboBox cmbSubHead;
        private System.Windows.Forms.DataGridView grdReportDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Label lblCashInHand;
        private System.Windows.Forms.Button btnShowDaily;
        private System.Windows.Forms.Button btnGenerateDaily;
        private System.Windows.Forms.TabPage tbDaily;
        private System.Windows.Forms.DateTimePicker dtDailyDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdDaily;
    }
}
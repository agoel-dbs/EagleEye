namespace EagleEye.Dashboard
{
    partial class frmStockStatusReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockStatusReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.lblCashInHand = new System.Windows.Forms.Label();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.cmbStock = new System.Windows.Forms.ComboBox();
            this.grdReportDetails = new System.Windows.Forms.DataGridView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnComputeStock = new System.Windows.Forms.Button();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbEdit = new System.Windows.Forms.TabPage();
            this.grdMonthlySaleAvg = new System.Windows.Forms.DataGridView();
            this.grdMonthlyAverage = new System.Windows.Forms.DataGridView();
            this.lblStockInHand = new System.Windows.Forms.Label();
            this.grdAggDetails = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportDetails)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlySaleAvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlyAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAggDetails)).BeginInit();
            this.SuspendLayout();
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
            // lblCashInHand
            // 
            this.lblCashInHand.AutoSize = true;
            this.lblCashInHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashInHand.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCashInHand.Location = new System.Drawing.Point(676, 33);
            this.lblCashInHand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCashInHand.Name = "lblCashInHand";
            this.lblCashInHand.Size = new System.Drawing.Size(0, 13);
            this.lblCashInHand.TabIndex = 126;
            // 
            // dtToDate
            // 
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToDate.Location = new System.Drawing.Point(537, 30);
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
            this.label1.Location = new System.Drawing.Point(471, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "To Date";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromDate.Location = new System.Drawing.Point(335, 30);
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
            this.lblEmailId.Location = new System.Drawing.Point(263, 32);
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
            this.lblBuyer.Size = new System.Drawing.Size(71, 13);
            this.lblBuyer.TabIndex = 121;
            this.lblBuyer.Text = "Select Item";
            // 
            // cmbStock
            // 
            this.cmbStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStock.FormattingEnabled = true;
            this.cmbStock.Location = new System.Drawing.Point(91, 29);
            this.cmbStock.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStock.Name = "cmbStock";
            this.cmbStock.Size = new System.Drawing.Size(169, 21);
            this.cmbStock.TabIndex = 120;
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
            this.grdReportDetails.Size = new System.Drawing.Size(804, 145);
            this.grdReportDetails.TabIndex = 119;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnComputeStock);
            this.pnlMain.Controls.Add(this.btnExcelExport);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.lblFormHeader);
            this.pnlMain.Location = new System.Drawing.Point(11, 54);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(893, 590);
            this.pnlMain.TabIndex = 46;
            // 
            // btnComputeStock
            // 
            this.btnComputeStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnComputeStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnComputeStock.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnComputeStock.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnComputeStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComputeStock.Location = new System.Drawing.Point(250, 551);
            this.btnComputeStock.Name = "btnComputeStock";
            this.btnComputeStock.Size = new System.Drawing.Size(162, 30);
            this.btnComputeStock.TabIndex = 95;
            this.btnComputeStock.Text = "    &Compute Stock";
            this.btnComputeStock.UseVisualStyleBackColor = false;
            this.btnComputeStock.Click += new System.EventHandler(this.btnComputeStock_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcelExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcelExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcelExport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExcelExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.Image")));
            this.btnExcelExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelExport.Location = new System.Drawing.Point(475, 551);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(162, 30);
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
            this.btnSave.Location = new System.Drawing.Point(25, 551);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 30);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "    &Show Stock Status";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbEdit);
            this.tabMain.Location = new System.Drawing.Point(29, 46);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(837, 498);
            this.tabMain.TabIndex = 90;
            // 
            // tbEdit
            // 
            this.tbEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.tbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEdit.Controls.Add(this.grdMonthlySaleAvg);
            this.tbEdit.Controls.Add(this.grdMonthlyAverage);
            this.tbEdit.Controls.Add(this.lblStockInHand);
            this.tbEdit.Controls.Add(this.grdAggDetails);
            this.tbEdit.Controls.Add(this.lblCashInHand);
            this.tbEdit.Controls.Add(this.dtToDate);
            this.tbEdit.Controls.Add(this.label1);
            this.tbEdit.Controls.Add(this.dtFromDate);
            this.tbEdit.Controls.Add(this.lblEmailId);
            this.tbEdit.Controls.Add(this.lblBuyer);
            this.tbEdit.Controls.Add(this.cmbStock);
            this.tbEdit.Controls.Add(this.grdReportDetails);
            this.tbEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEdit.Location = new System.Drawing.Point(4, 22);
            this.tbEdit.Margin = new System.Windows.Forms.Padding(2);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Padding = new System.Windows.Forms.Padding(2);
            this.tbEdit.Size = new System.Drawing.Size(829, 472);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.Text = "Stock Status Report ( without Tax , Loading & Commission)";
            // 
            // grdMonthlySaleAvg
            // 
            this.grdMonthlySaleAvg.AllowUserToAddRows = false;
            this.grdMonthlySaleAvg.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMonthlySaleAvg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMonthlySaleAvg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdMonthlySaleAvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMonthlySaleAvg.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdMonthlySaleAvg.Location = new System.Drawing.Point(12, 398);
            this.grdMonthlySaleAvg.Name = "grdMonthlySaleAvg";
            this.grdMonthlySaleAvg.ReadOnly = true;
            this.grdMonthlySaleAvg.RowHeadersVisible = false;
            this.grdMonthlySaleAvg.RowHeadersWidth = 62;
            this.grdMonthlySaleAvg.Size = new System.Drawing.Size(802, 59);
            this.grdMonthlySaleAvg.TabIndex = 130;
            // 
            // grdMonthlyAverage
            // 
            this.grdMonthlyAverage.AllowUserToAddRows = false;
            this.grdMonthlyAverage.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMonthlyAverage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMonthlyAverage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdMonthlyAverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMonthlyAverage.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdMonthlyAverage.Location = new System.Drawing.Point(11, 338);
            this.grdMonthlyAverage.Name = "grdMonthlyAverage";
            this.grdMonthlyAverage.ReadOnly = true;
            this.grdMonthlyAverage.RowHeadersVisible = false;
            this.grdMonthlyAverage.RowHeadersWidth = 62;
            this.grdMonthlyAverage.Size = new System.Drawing.Size(803, 59);
            this.grdMonthlyAverage.TabIndex = 129;
            // 
            // lblStockInHand
            // 
            this.lblStockInHand.AutoSize = true;
            this.lblStockInHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockInHand.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblStockInHand.Location = new System.Drawing.Point(686, 33);
            this.lblStockInHand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockInHand.Name = "lblStockInHand";
            this.lblStockInHand.Size = new System.Drawing.Size(88, 13);
            this.lblStockInHand.TabIndex = 128;
            this.lblStockInHand.Text = "Stock in Hand";
            // 
            // grdAggDetails
            // 
            this.grdAggDetails.AllowUserToAddRows = false;
            this.grdAggDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAggDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAggDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdAggDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAggDetails.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdAggDetails.Location = new System.Drawing.Point(10, 209);
            this.grdAggDetails.Name = "grdAggDetails";
            this.grdAggDetails.ReadOnly = true;
            this.grdAggDetails.RowHeadersVisible = false;
            this.grdAggDetails.RowHeadersWidth = 62;
            this.grdAggDetails.Size = new System.Drawing.Size(804, 126);
            this.grdAggDetails.TabIndex = 127;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Image = global::EagleEye.Properties.Resources.img_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(700, 551);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 30);
            this.btnExit.TabIndex = 92;
            this.btnExit.Text = "   &Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmStockStatusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(895, 655);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStockStatusReport";
            this.Text = "frmStockStatusReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStockStatusReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReportDetails)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbEdit.ResumeLayout(false);
            this.tbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlySaleAvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlyAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAggDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCashInHand;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.ComboBox cmbStock;
        private System.Windows.Forms.DataGridView grdReportDetails;
        private System.Windows.Forms.Button btnExcelExport;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbEdit;
        private System.Windows.Forms.DataGridView grdAggDetails;
        private System.Windows.Forms.Label lblStockInHand;
        private System.Windows.Forms.Button btnComputeStock;
        private System.Windows.Forms.DataGridView grdMonthlyAverage;
        private System.Windows.Forms.DataGridView grdMonthlySaleAvg;
    }
}
namespace EagleEye.Operations
{
    partial class frmInvoiceCancellation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoiceCancellation));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnChangeBuyer = new System.Windows.Forms.Button();
            this.btnChangeSaleRate = new System.Windows.Forms.Button();
            this.btnChangetoCash = new System.Windows.Forms.Button();
            this.btnChangetoCredit = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbEdit = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBuyer = new System.Windows.Forms.ComboBox();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.cmbCancelReason = new System.Windows.Forms.ComboBox();
            this.grdInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.txtOldInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSaleRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaleWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoiceDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnChangeBuyer);
            this.pnlMain.Controls.Add(this.btnChangeSaleRate);
            this.pnlMain.Controls.Add(this.btnChangetoCash);
            this.pnlMain.Controls.Add(this.btnChangetoCredit);
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.lblFormHeader);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Location = new System.Drawing.Point(25, 36);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(870, 358);
            this.pnlMain.TabIndex = 43;
            // 
            // btnChangeBuyer
            // 
            this.btnChangeBuyer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangeBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeBuyer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnChangeBuyer.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnChangeBuyer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeBuyer.Location = new System.Drawing.Point(424, 315);
            this.btnChangeBuyer.Name = "btnChangeBuyer";
            this.btnChangeBuyer.Size = new System.Drawing.Size(157, 30);
            this.btnChangeBuyer.TabIndex = 94;
            this.btnChangeBuyer.Text = "   &Change Account";
            this.btnChangeBuyer.UseVisualStyleBackColor = false;
            this.btnChangeBuyer.Click += new System.EventHandler(this.btnChangeBuyer_Click);
            // 
            // btnChangeSaleRate
            // 
            this.btnChangeSaleRate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangeSaleRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSaleRate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnChangeSaleRate.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnChangeSaleRate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeSaleRate.Location = new System.Drawing.Point(586, 315);
            this.btnChangeSaleRate.Name = "btnChangeSaleRate";
            this.btnChangeSaleRate.Size = new System.Drawing.Size(168, 30);
            this.btnChangeSaleRate.TabIndex = 93;
            this.btnChangeSaleRate.Text = "&Modify Sale Rate";
            this.btnChangeSaleRate.UseVisualStyleBackColor = false;
            this.btnChangeSaleRate.Click += new System.EventHandler(this.btnChangeSaleRate_Click);
            // 
            // btnChangetoCash
            // 
            this.btnChangetoCash.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangetoCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangetoCash.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnChangetoCash.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnChangetoCash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangetoCash.Location = new System.Drawing.Point(278, 315);
            this.btnChangetoCash.Name = "btnChangetoCash";
            this.btnChangetoCash.Size = new System.Drawing.Size(141, 30);
            this.btnChangetoCash.TabIndex = 92;
            this.btnChangetoCash.Text = "   &Mark Cash Sale";
            this.btnChangetoCash.UseVisualStyleBackColor = false;
            this.btnChangetoCash.Click += new System.EventHandler(this.BtnChangetoCash_Click);
            // 
            // btnChangetoCredit
            // 
            this.btnChangetoCredit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangetoCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangetoCredit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnChangetoCredit.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnChangetoCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangetoCredit.Location = new System.Drawing.Point(132, 315);
            this.btnChangetoCredit.Name = "btnChangetoCredit";
            this.btnChangetoCredit.Size = new System.Drawing.Size(141, 30);
            this.btnChangetoCredit.TabIndex = 91;
            this.btnChangetoCredit.Text = "   &Mark Credit Sale";
            this.btnChangetoCredit.UseVisualStyleBackColor = false;
            this.btnChangetoCredit.Click += new System.EventHandler(this.BtnChangetoCredit_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbEdit);
            this.tabMain.Location = new System.Drawing.Point(29, 57);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(828, 252);
            this.tabMain.TabIndex = 90;
            // 
            // tbEdit
            // 
            this.tbEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.tbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEdit.Controls.Add(this.txtSaleWeight);
            this.tbEdit.Controls.Add(this.label3);
            this.tbEdit.Controls.Add(this.txtSaleRate);
            this.tbEdit.Controls.Add(this.label2);
            this.tbEdit.Controls.Add(this.label1);
            this.tbEdit.Controls.Add(this.cmbBuyer);
            this.tbEdit.Controls.Add(this.lblBuyer);
            this.tbEdit.Controls.Add(this.cmbCancelReason);
            this.tbEdit.Controls.Add(this.grdInvoiceDetails);
            this.tbEdit.Controls.Add(this.txtOldInvoiceNo);
            this.tbEdit.Controls.Add(this.lblBuyerName);
            this.tbEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEdit.Location = new System.Drawing.Point(4, 22);
            this.tbEdit.Margin = new System.Windows.Forms.Padding(2);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Padding = new System.Windows.Forms.Padding(2);
            this.tbEdit.Size = new System.Drawing.Size(820, 226);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.Text = "Invoice Changes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(581, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 126;
            this.label1.Text = "Buyer";
            // 
            // cmbBuyer
            // 
            this.cmbBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuyer.FormattingEnabled = true;
            this.cmbBuyer.Location = new System.Drawing.Point(642, 15);
            this.cmbBuyer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBuyer.Name = "cmbBuyer";
            this.cmbBuyer.Size = new System.Drawing.Size(169, 21);
            this.cmbBuyer.TabIndex = 125;
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBuyer.Location = new System.Drawing.Point(244, 19);
            this.lblBuyer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(141, 13);
            this.lblBuyer.TabIndex = 124;
            this.lblBuyer.Text = "Reason Of Cancellation";
            // 
            // cmbCancelReason
            // 
            this.cmbCancelReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCancelReason.FormattingEnabled = true;
            this.cmbCancelReason.Location = new System.Drawing.Point(390, 15);
            this.cmbCancelReason.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCancelReason.Name = "cmbCancelReason";
            this.cmbCancelReason.Size = new System.Drawing.Size(169, 21);
            this.cmbCancelReason.TabIndex = 2;
            // 
            // grdInvoiceDetails
            // 
            this.grdInvoiceDetails.AllowUserToAddRows = false;
            this.grdInvoiceDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInvoiceDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInvoiceDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInvoiceDetails.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdInvoiceDetails.Location = new System.Drawing.Point(5, 96);
            this.grdInvoiceDetails.Name = "grdInvoiceDetails";
            this.grdInvoiceDetails.ReadOnly = true;
            this.grdInvoiceDetails.RowHeadersVisible = false;
            this.grdInvoiceDetails.RowHeadersWidth = 62;
            this.grdInvoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInvoiceDetails.Size = new System.Drawing.Size(807, 124);
            this.grdInvoiceDetails.TabIndex = 122;
            // 
            // txtOldInvoiceNo
            // 
            this.txtOldInvoiceNo.Location = new System.Drawing.Point(73, 15);
            this.txtOldInvoiceNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtOldInvoiceNo.Name = "txtOldInvoiceNo";
            this.txtOldInvoiceNo.Size = new System.Drawing.Size(167, 20);
            this.txtOldInvoiceNo.TabIndex = 1;
            this.txtOldInvoiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOldInvoiceNo_KeyPress);
            this.txtOldInvoiceNo.Leave += new System.EventHandler(this.TxtOldInvoiceNo_Leave);
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AutoSize = true;
            this.lblBuyerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBuyerName.Location = new System.Drawing.Point(6, 19);
            this.lblBuyerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(69, 13);
            this.lblBuyerName.TabIndex = 98;
            this.lblBuyerName.Text = "Invoice No";
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(32, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "    &Cancel Invoice";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Image = global::EagleEye.Properties.Resources.img_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(759, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "   &Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtSaleRate
            // 
            this.txtSaleRate.Location = new System.Drawing.Point(73, 55);
            this.txtSaleRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaleRate.Name = "txtSaleRate";
            this.txtSaleRate.Size = new System.Drawing.Size(167, 20);
            this.txtSaleRate.TabIndex = 127;
            this.txtSaleRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaleRate_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 128;
            this.label2.Text = "Sale Rate";
            // 
            // txtSaleWeight
            // 
            this.txtSaleWeight.Location = new System.Drawing.Point(390, 52);
            this.txtSaleWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaleWeight.Name = "txtSaleWeight";
            this.txtSaleWeight.Size = new System.Drawing.Size(167, 20);
            this.txtSaleWeight.TabIndex = 129;
            this.txtSaleWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaleWeight_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(307, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 130;
            this.label3.Text = "Sale Weight";
            // 
            // frmInvoiceCancellation
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(924, 446);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInvoiceCancellation";
            this.Text = "Invoice Cancellation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInvoiceCancellation_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbEdit.ResumeLayout(false);
            this.tbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoiceDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbEdit;
        private System.Windows.Forms.TextBox txtOldInvoiceNo;
        private System.Windows.Forms.Label lblBuyerName;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView grdInvoiceDetails;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.ComboBox cmbCancelReason;
        private System.Windows.Forms.Button btnChangetoCash;
        private System.Windows.Forms.Button btnChangetoCredit;
        private System.Windows.Forms.Button btnChangeSaleRate;
        private System.Windows.Forms.Button btnChangeBuyer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBuyer;
        private System.Windows.Forms.TextBox txtSaleWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaleRate;
        private System.Windows.Forms.Label label2;
    }
}
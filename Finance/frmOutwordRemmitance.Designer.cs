namespace EagleEye.Finance
{
    partial class frmOutwordRemmitance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutwordRemmitance));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbEdit = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbExpenseHead = new System.Windows.Forms.ComboBox();
            this.lblOutstanding = new System.Windows.Forms.Label();
            this.dtTransasactionDate = new System.Windows.Forms.DateTimePicker();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtRemarks = new System.Windows.Forms.RichTextBox();
            this.Active = new System.Windows.Forms.Label();
            this.cmbModeOfPayment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbView = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.grdOutstandingDetails = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.grdDetails = new System.Windows.Forms.DataGridView();
            this.tbPartyLedger = new System.Windows.Forms.TabPage();
            this.lblLedgerHis = new System.Windows.Forms.Label();
            this.grdPartyLedgerHis = new System.Windows.Forms.DataGridView();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdPaid = new System.Windows.Forms.RadioButton();
            this.rdReceived = new System.Windows.Forms.RadioButton();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbEdit.SuspendLayout();
            this.tbView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOutstandingDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).BeginInit();
            this.tbPartyLedger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartyLedgerHis)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.lblFormHeader);
            this.pnlMain.Location = new System.Drawing.Point(103, 39);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(625, 445);
            this.pnlMain.TabIndex = 44;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(136, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "    &Proceed";
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
            this.btnExit.Location = new System.Drawing.Point(440, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "   &Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbEdit);
            this.tabMain.Controls.Add(this.tbView);
            this.tabMain.Controls.Add(this.tbPartyLedger);
            this.tabMain.Location = new System.Drawing.Point(29, 64);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(563, 331);
            this.tabMain.TabIndex = 90;
            // 
            // tbEdit
            // 
            this.tbEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.tbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEdit.Controls.Add(this.rdReceived);
            this.tbEdit.Controls.Add(this.rdPaid);
            this.tbEdit.Controls.Add(this.label2);
            this.tbEdit.Controls.Add(this.label8);
            this.tbEdit.Controls.Add(this.txtAmt);
            this.tbEdit.Controls.Add(this.label9);
            this.tbEdit.Controls.Add(this.cmbExpenseHead);
            this.tbEdit.Controls.Add(this.lblOutstanding);
            this.tbEdit.Controls.Add(this.dtTransasactionDate);
            this.tbEdit.Controls.Add(this.txtChequeNo);
            this.tbEdit.Controls.Add(this.label6);
            this.tbEdit.Controls.Add(this.rtxtRemarks);
            this.tbEdit.Controls.Add(this.Active);
            this.tbEdit.Controls.Add(this.cmbModeOfPayment);
            this.tbEdit.Controls.Add(this.label5);
            this.tbEdit.Controls.Add(this.cmbVendor);
            this.tbEdit.Controls.Add(this.label3);
            this.tbEdit.Controls.Add(this.txtAmount);
            this.tbEdit.Controls.Add(this.label1);
            this.tbEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEdit.Location = new System.Drawing.Point(4, 22);
            this.tbEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEdit.Size = new System.Drawing.Size(555, 305);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.Text = "Vendor / Expense Payment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(102, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 118;
            this.label9.Text = "Select Expense Head";
            // 
            // cmbExpenseHead
            // 
            this.cmbExpenseHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpenseHead.FormattingEnabled = true;
            this.cmbExpenseHead.Location = new System.Drawing.Point(231, 47);
            this.cmbExpenseHead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbExpenseHead.Name = "cmbExpenseHead";
            this.cmbExpenseHead.Size = new System.Drawing.Size(278, 21);
            this.cmbExpenseHead.TabIndex = 1;
            this.cmbExpenseHead.SelectedIndexChanged += new System.EventHandler(this.CmbExpenseHead_SelectedIndexChanged);
            // 
            // lblOutstanding
            // 
            this.lblOutstanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutstanding.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblOutstanding.Location = new System.Drawing.Point(228, 280);
            this.lblOutstanding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutstanding.Name = "lblOutstanding";
            this.lblOutstanding.Size = new System.Drawing.Size(279, 17);
            this.lblOutstanding.TabIndex = 116;
            this.lblOutstanding.Text = "OS Balance";
            // 
            // dtTransasactionDate
            // 
            this.dtTransasactionDate.Location = new System.Drawing.Point(231, 213);
            this.dtTransasactionDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtTransasactionDate.Name = "dtTransasactionDate";
            this.dtTransasactionDate.Size = new System.Drawing.Size(278, 20);
            this.dtTransasactionDate.TabIndex = 8;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Location = new System.Drawing.Point(231, 110);
            this.txtChequeNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(278, 20);
            this.txtChequeNo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(102, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 113;
            this.label6.Text = "Cheque No";
            // 
            // rtxtRemarks
            // 
            this.rtxtRemarks.Location = new System.Drawing.Point(231, 245);
            this.rtxtRemarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtRemarks.Name = "rtxtRemarks";
            this.rtxtRemarks.Size = new System.Drawing.Size(278, 18);
            this.rtxtRemarks.TabIndex = 9;
            this.rtxtRemarks.Text = "";
            // 
            // Active
            // 
            this.Active.AutoSize = true;
            this.Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Active.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Active.Location = new System.Drawing.Point(102, 77);
            this.Active.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(90, 13);
            this.Active.TabIndex = 111;
            this.Active.Text = "Payment Mode";
            // 
            // cmbModeOfPayment
            // 
            this.cmbModeOfPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModeOfPayment.FormattingEnabled = true;
            this.cmbModeOfPayment.Location = new System.Drawing.Point(231, 76);
            this.cmbModeOfPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbModeOfPayment.Name = "cmbModeOfPayment";
            this.cmbModeOfPayment.Size = new System.Drawing.Size(278, 21);
            this.cmbModeOfPayment.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(102, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "Select Vendor";
            // 
            // cmbVendor
            // 
            this.cmbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(231, 16);
            this.cmbVendor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(278, 21);
            this.cmbVendor.TabIndex = 0;
            this.cmbVendor.SelectedIndexChanged += new System.EventHandler(this.CmbVendor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(102, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Remarks";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(377, 180);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(132, 20);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAmount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(102, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Date of Payment";
            // 
            // tbView
            // 
            this.tbView.BackColor = System.Drawing.Color.SandyBrown;
            this.tbView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbView.Controls.Add(this.label7);
            this.tbView.Controls.Add(this.grdOutstandingDetails);
            this.tbView.Controls.Add(this.label4);
            this.tbView.Controls.Add(this.grdDetails);
            this.tbView.Location = new System.Drawing.Point(4, 22);
            this.tbView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbView.Name = "tbView";
            this.tbView.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbView.Size = new System.Drawing.Size(555, 259);
            this.tbView.TabIndex = 1;
            this.tbView.Text = "View Payment History";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(10, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 124;
            this.label7.Text = "Ledger Balance";
            // 
            // grdOutstandingDetails
            // 
            this.grdOutstandingDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOutstandingDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOutstandingDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdOutstandingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOutstandingDetails.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdOutstandingDetails.Location = new System.Drawing.Point(10, 21);
            this.grdOutstandingDetails.Name = "grdOutstandingDetails";
            this.grdOutstandingDetails.RowHeadersVisible = false;
            this.grdOutstandingDetails.Size = new System.Drawing.Size(535, 46);
            this.grdOutstandingDetails.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 122;
            this.label4.Text = "Payment History";
            // 
            // grdDetails
            // 
            this.grdDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetails.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdDetails.Location = new System.Drawing.Point(10, 94);
            this.grdDetails.Name = "grdDetails";
            this.grdDetails.RowHeadersVisible = false;
            this.grdDetails.Size = new System.Drawing.Size(535, 146);
            this.grdDetails.TabIndex = 121;
            // 
            // tbPartyLedger
            // 
            this.tbPartyLedger.BackColor = System.Drawing.Color.SandyBrown;
            this.tbPartyLedger.Controls.Add(this.lblLedgerHis);
            this.tbPartyLedger.Controls.Add(this.grdPartyLedgerHis);
            this.tbPartyLedger.Location = new System.Drawing.Point(4, 22);
            this.tbPartyLedger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPartyLedger.Name = "tbPartyLedger";
            this.tbPartyLedger.Size = new System.Drawing.Size(555, 259);
            this.tbPartyLedger.TabIndex = 2;
            this.tbPartyLedger.Text = "Vendor Ledger History";
            // 
            // lblLedgerHis
            // 
            this.lblLedgerHis.AutoSize = true;
            this.lblLedgerHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLedgerHis.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLedgerHis.Location = new System.Drawing.Point(15, 10);
            this.lblLedgerHis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLedgerHis.Name = "lblLedgerHis";
            this.lblLedgerHis.Size = new System.Drawing.Size(89, 13);
            this.lblLedgerHis.TabIndex = 124;
            this.lblLedgerHis.Text = "Ledger History";
            // 
            // grdPartyLedgerHis
            // 
            this.grdPartyLedgerHis.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPartyLedgerHis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPartyLedgerHis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdPartyLedgerHis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPartyLedgerHis.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdPartyLedgerHis.Location = new System.Drawing.Point(15, 29);
            this.grdPartyLedgerHis.Name = "grdPartyLedgerHis";
            this.grdPartyLedgerHis.RowHeadersVisible = false;
            this.grdPartyLedgerHis.Size = new System.Drawing.Size(535, 205);
            this.grdPartyLedgerHis.TabIndex = 123;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(102, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 120;
            this.label8.Text = "Amount";
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(231, 180);
            this.txtAmt.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(129, 20);
            this.txtAmt.TabIndex = 6;
            this.txtAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmt_KeyPress);
            this.txtAmt.Leave += new System.EventHandler(this.txtAmt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(102, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Cash";
            // 
            // rdPaid
            // 
            this.rdPaid.AutoSize = true;
            this.rdPaid.Checked = true;
            this.rdPaid.Location = new System.Drawing.Point(231, 147);
            this.rdPaid.Name = "rdPaid";
            this.rdPaid.Size = new System.Drawing.Size(46, 17);
            this.rdPaid.TabIndex = 4;
            this.rdPaid.TabStop = true;
            this.rdPaid.Text = "Paid";
            this.rdPaid.UseVisualStyleBackColor = true;
            this.rdPaid.Click += new System.EventHandler(this.rdPaid_Click);
            // 
            // rdReceived
            // 
            this.rdReceived.AutoSize = true;
            this.rdReceived.Location = new System.Drawing.Point(344, 147);
            this.rdReceived.Name = "rdReceived";
            this.rdReceived.Size = new System.Drawing.Size(71, 17);
            this.rdReceived.TabIndex = 5;
            this.rdReceived.Text = "Received";
            this.rdReceived.UseVisualStyleBackColor = true;
            this.rdReceived.Click += new System.EventHandler(this.rdReceived_Click);
            // 
            // frmOutwordRemmitance
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(831, 520);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmOutwordRemmitance";
            this.Text = "Vendor Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOutwordRemmitance_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbEdit.ResumeLayout(false);
            this.tbEdit.PerformLayout();
            this.tbView.ResumeLayout(false);
            this.tbView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOutstandingDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).EndInit();
            this.tbPartyLedger.ResumeLayout(false);
            this.tbPartyLedger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartyLedgerHis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbEdit;
        private System.Windows.Forms.Label lblOutstanding;
        private System.Windows.Forms.DateTimePicker dtTransasactionDate;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtRemarks;
        private System.Windows.Forms.Label Active;
        private System.Windows.Forms.ComboBox cmbModeOfPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVendor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdOutstandingDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdDetails;
        private System.Windows.Forms.TabPage tbPartyLedger;
        private System.Windows.Forms.Label lblLedgerHis;
        private System.Windows.Forms.DataGridView grdPartyLedgerHis;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbExpenseHead;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdReceived;
        private System.Windows.Forms.RadioButton rdPaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAmt;
    }
}
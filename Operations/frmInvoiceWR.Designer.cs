namespace EagleEye.Operations
{
    partial class frmInvoiceWR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoiceWR));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbEdit = new System.Windows.Forms.TabPage();
            this.txtGSTNo = new System.Windows.Forms.TextBox();
            this.dtBillDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtInvoiceQty = new System.Windows.Forms.TextBox();
            this.chkOtherBuyer = new System.Windows.Forms.CheckBox();
            this.chkTaxableInvoice = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTaxInvoiceRate = new System.Windows.Forms.TextBox();
            this.cmbOtherBuyer = new System.Windows.Forms.ComboBox();
            this.txtSlipWeight = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkPaymentMade = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemSlipRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbTaxType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTruckNo = new System.Windows.Forms.TextBox();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.cmbBuyer = new System.Windows.Forms.ComboBox();
            this.txtActualSaleQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmountReceived = new System.Windows.Forms.TextBox();
            this.dgExpenseDetails = new System.Windows.Forms.DataGridView();
            this.txtPrintCopy = new System.Windows.Forms.TextBox();
            this.txtRatePerTon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtCollectionAmt = new System.Windows.Forms.TextBox();
            this.tbView = new System.Windows.Forms.TabPage();
            this.grdInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOldInvoiceNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenseDetails)).BeginInit();
            this.tbView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoiceDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnPrintInvoice);
            this.pnlMain.Controls.Add(this.btnGenerateInvoice);
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.lblFormHeader);
            this.pnlMain.Location = new System.Drawing.Point(105, 39);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(793, 566);
            this.pnlMain.TabIndex = 44;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrintInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPrintInvoice.Image = global::EagleEye.Properties.Resources.img_print;
            this.btnPrintInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintInvoice.Location = new System.Drawing.Point(322, 531);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(160, 30);
            this.btnPrintInvoice.TabIndex = 20;
            this.btnPrintInvoice.Text = "  &Re-Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.BtnPrintInvoice_Click);
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerateInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateInvoice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGenerateInvoice.Image = global::EagleEye.Properties.Resources.img_invoice;
            this.btnGenerateInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateInvoice.Location = new System.Drawing.Point(28, 531);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(160, 30);
            this.btnGenerateInvoice.TabIndex = 19;
            this.btnGenerateInvoice.Text = "  &Generate Invoice";
            this.btnGenerateInvoice.UseVisualStyleBackColor = false;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.BtnGenerateInvoice_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbEdit);
            this.tabMain.Controls.Add(this.tbView);
            this.tabMain.Location = new System.Drawing.Point(29, 56);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(741, 443);
            this.tabMain.TabIndex = 90;
            // 
            // tbEdit
            // 
            this.tbEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.tbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEdit.Controls.Add(this.txtGSTNo);
            this.tbEdit.Controls.Add(this.dtBillDate);
            this.tbEdit.Controls.Add(this.lblEmailId);
            this.tbEdit.Controls.Add(this.label14);
            this.tbEdit.Controls.Add(this.txtInvoiceQty);
            this.tbEdit.Controls.Add(this.chkOtherBuyer);
            this.tbEdit.Controls.Add(this.chkTaxableInvoice);
            this.tbEdit.Controls.Add(this.label15);
            this.tbEdit.Controls.Add(this.txtTaxInvoiceRate);
            this.tbEdit.Controls.Add(this.cmbOtherBuyer);
            this.tbEdit.Controls.Add(this.txtSlipWeight);
            this.tbEdit.Controls.Add(this.label13);
            this.tbEdit.Controls.Add(this.chkPaymentMade);
            this.tbEdit.Controls.Add(this.label2);
            this.tbEdit.Controls.Add(this.txtItemSlipRate);
            this.tbEdit.Controls.Add(this.label12);
            this.tbEdit.Controls.Add(this.cmbTaxType);
            this.tbEdit.Controls.Add(this.label5);
            this.tbEdit.Controls.Add(this.cmbItem);
            this.tbEdit.Controls.Add(this.label11);
            this.tbEdit.Controls.Add(this.txtTruckNo);
            this.tbEdit.Controls.Add(this.lblBuyer);
            this.tbEdit.Controls.Add(this.cmbBuyer);
            this.tbEdit.Controls.Add(this.txtActualSaleQty);
            this.tbEdit.Controls.Add(this.label7);
            this.tbEdit.Controls.Add(this.label8);
            this.tbEdit.Controls.Add(this.txtAmountReceived);
            this.tbEdit.Controls.Add(this.dgExpenseDetails);
            this.tbEdit.Controls.Add(this.txtPrintCopy);
            this.tbEdit.Controls.Add(this.txtRatePerTon);
            this.tbEdit.Controls.Add(this.label6);
            this.tbEdit.Controls.Add(this.label4);
            this.tbEdit.Controls.Add(this.label3);
            this.tbEdit.Controls.Add(this.label1);
            this.tbEdit.Controls.Add(this.txtInvoiceNo);
            this.tbEdit.Controls.Add(this.txtCollectionAmt);
            this.tbEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEdit.Location = new System.Drawing.Point(4, 22);
            this.tbEdit.Margin = new System.Windows.Forms.Padding(2);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Padding = new System.Windows.Forms.Padding(2);
            this.tbEdit.Size = new System.Drawing.Size(733, 417);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.Text = "Bill Details";
            // 
            // txtGSTNo
            // 
            this.txtGSTNo.Location = new System.Drawing.Point(26, 37);
            this.txtGSTNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtGSTNo.Name = "txtGSTNo";
            this.txtGSTNo.Size = new System.Drawing.Size(169, 20);
            this.txtGSTNo.TabIndex = 150;
            // 
            // dtBillDate
            // 
            this.dtBillDate.Location = new System.Drawing.Point(500, 295);
            this.dtBillDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtBillDate.Name = "dtBillDate";
            this.dtBillDate.Size = new System.Drawing.Size(169, 20);
            this.dtBillDate.TabIndex = 17;
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmailId.Location = new System.Drawing.Point(497, 280);
            this.lblEmailId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(80, 13);
            this.lblEmailId.TabIndex = 118;
            this.lblEmailId.Text = "Invoice Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(271, 282);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 149;
            this.label14.Text = "Invoice Qty (Ton)";
            // 
            // txtInvoiceQty
            // 
            this.txtInvoiceQty.Location = new System.Drawing.Point(271, 298);
            this.txtInvoiceQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvoiceQty.Name = "txtInvoiceQty";
            this.txtInvoiceQty.Size = new System.Drawing.Size(172, 20);
            this.txtInvoiceQty.TabIndex = 16;
            // 
            // chkOtherBuyer
            // 
            this.chkOtherBuyer.AutoSize = true;
            this.chkOtherBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.chkOtherBuyer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkOtherBuyer.Location = new System.Drawing.Point(512, 13);
            this.chkOtherBuyer.Margin = new System.Windows.Forms.Padding(2);
            this.chkOtherBuyer.Name = "chkOtherBuyer";
            this.chkOtherBuyer.Size = new System.Drawing.Size(157, 17);
            this.chkOtherBuyer.TabIndex = 2;
            this.chkOtherBuyer.Text = "Paid by Different Buyer";
            this.chkOtherBuyer.UseVisualStyleBackColor = true;
            this.chkOtherBuyer.CheckedChanged += new System.EventHandler(this.ChkOtherBuyer_CheckedChanged);
            // 
            // chkTaxableInvoice
            // 
            this.chkTaxableInvoice.AutoSize = true;
            this.chkTaxableInvoice.Checked = true;
            this.chkTaxableInvoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTaxableInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTaxableInvoice.Location = new System.Drawing.Point(27, 16);
            this.chkTaxableInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.chkTaxableInvoice.Name = "chkTaxableInvoice";
            this.chkTaxableInvoice.Size = new System.Drawing.Size(93, 17);
            this.chkTaxableInvoice.TabIndex = 0;
            this.chkTaxableInvoice.Text = "Tax Invoice";
            this.chkTaxableInvoice.UseVisualStyleBackColor = true;
            this.chkTaxableInvoice.CheckedChanged += new System.EventHandler(this.chkTaxableInvoice_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(26, 282);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 13);
            this.label15.TabIndex = 145;
            this.label15.Text = "Invoice Tax Rate";
            // 
            // txtTaxInvoiceRate
            // 
            this.txtTaxInvoiceRate.Location = new System.Drawing.Point(26, 298);
            this.txtTaxInvoiceRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaxInvoiceRate.Name = "txtTaxInvoiceRate";
            this.txtTaxInvoiceRate.Size = new System.Drawing.Size(172, 20);
            this.txtTaxInvoiceRate.TabIndex = 15;
            this.txtTaxInvoiceRate.Text = "700";
            // 
            // cmbOtherBuyer
            // 
            this.cmbOtherBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOtherBuyer.Enabled = false;
            this.cmbOtherBuyer.FormattingEnabled = true;
            this.cmbOtherBuyer.Location = new System.Drawing.Point(512, 34);
            this.cmbOtherBuyer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOtherBuyer.Name = "cmbOtherBuyer";
            this.cmbOtherBuyer.Size = new System.Drawing.Size(173, 21);
            this.cmbOtherBuyer.TabIndex = 142;
            // 
            // txtSlipWeight
            // 
            this.txtSlipWeight.Location = new System.Drawing.Point(274, 197);
            this.txtSlipWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtSlipWeight.Name = "txtSlipWeight";
            this.txtSlipWeight.Size = new System.Drawing.Size(172, 20);
            this.txtSlipWeight.TabIndex = 10;
            this.txtSlipWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSlipWeight_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(274, 181);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 141;
            this.label13.Text = "Slip Qty(Ton)";
            // 
            // chkPaymentMade
            // 
            this.chkPaymentMade.AutoSize = true;
            this.chkPaymentMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaymentMade.Location = new System.Drawing.Point(511, 248);
            this.chkPaymentMade.Margin = new System.Windows.Forms.Padding(2);
            this.chkPaymentMade.Name = "chkPaymentMade";
            this.chkPaymentMade.Size = new System.Drawing.Size(83, 17);
            this.chkPaymentMade.TabIndex = 14;
            this.chkPaymentMade.Text = "Cash Paid";
            this.chkPaymentMade.UseVisualStyleBackColor = true;
            this.chkPaymentMade.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkPaymentMade_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(276, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 138;
            this.label2.Text = "Tax Aplicable";
            // 
            // txtItemSlipRate
            // 
            this.txtItemSlipRate.Location = new System.Drawing.Point(26, 197);
            this.txtItemSlipRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemSlipRate.Name = "txtItemSlipRate";
            this.txtItemSlipRate.Size = new System.Drawing.Size(169, 20);
            this.txtItemSlipRate.TabIndex = 9;
            this.txtItemSlipRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItemSlipRate_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(26, 181);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 137;
            this.label12.Text = "Slip Rate";
            // 
            // cmbTaxType
            // 
            this.cmbTaxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaxType.FormattingEnabled = true;
            this.cmbTaxType.Location = new System.Drawing.Point(275, 30);
            this.cmbTaxType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTaxType.Name = "cmbTaxType";
            this.cmbTaxType.Size = new System.Drawing.Size(173, 21);
            this.cmbTaxType.TabIndex = 1;
            this.cmbTaxType.SelectedIndexChanged += new System.EventHandler(this.CmbTaxType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(274, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 132;
            this.label5.Text = "Select Item";
            // 
            // cmbItem
            // 
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(274, 86);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(173, 21);
            this.cmbItem.TabIndex = 4;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.CmbItem_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(510, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 130;
            this.label11.Text = "Vechile No";
            // 
            // txtTruckNo
            // 
            this.txtTruckNo.Location = new System.Drawing.Point(510, 85);
            this.txtTruckNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTruckNo.Name = "txtTruckNo";
            this.txtTruckNo.Size = new System.Drawing.Size(169, 20);
            this.txtTruckNo.TabIndex = 5;
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBuyer.Location = new System.Drawing.Point(26, 68);
            this.lblBuyer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(79, 13);
            this.lblBuyer.TabIndex = 128;
            this.lblBuyer.Text = "Select Buyer";
            // 
            // cmbBuyer
            // 
            this.cmbBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuyer.FormattingEnabled = true;
            this.cmbBuyer.Location = new System.Drawing.Point(26, 86);
            this.cmbBuyer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBuyer.Name = "cmbBuyer";
            this.cmbBuyer.Size = new System.Drawing.Size(173, 21);
            this.cmbBuyer.TabIndex = 3;
            this.cmbBuyer.SelectedIndexChanged += new System.EventHandler(this.CmbBuyer_SelectedIndexChanged);
            // 
            // txtActualSaleQty
            // 
            this.txtActualSaleQty.Location = new System.Drawing.Point(274, 141);
            this.txtActualSaleQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualSaleQty.Name = "txtActualSaleQty";
            this.txtActualSaleQty.Size = new System.Drawing.Size(169, 20);
            this.txtActualSaleQty.TabIndex = 7;
            this.txtActualSaleQty.TextChanged += new System.EventHandler(this.TxtActualSaleQty_TextChanged);
            this.txtActualSaleQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActualSaleQty_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(274, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "Material Qty (Ton)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(278, 232);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 124;
            this.label8.Text = "Amount Received";
            // 
            // txtAmountReceived
            // 
            this.txtAmountReceived.Location = new System.Drawing.Point(277, 248);
            this.txtAmountReceived.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmountReceived.Name = "txtAmountReceived";
            this.txtAmountReceived.Size = new System.Drawing.Size(169, 20);
            this.txtAmountReceived.TabIndex = 13;
            this.txtAmountReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAmountReceived_KeyPress);
            // 
            // dgExpenseDetails
            // 
            this.dgExpenseDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgExpenseDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgExpenseDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgExpenseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExpenseDetails.GridColor = System.Drawing.Color.LemonChiffon;
            this.dgExpenseDetails.Location = new System.Drawing.Point(27, 332);
            this.dgExpenseDetails.Name = "dgExpenseDetails";
            this.dgExpenseDetails.RowHeadersVisible = false;
            this.dgExpenseDetails.RowHeadersWidth = 62;
            this.dgExpenseDetails.Size = new System.Drawing.Size(650, 60);
            this.dgExpenseDetails.TabIndex = 18;
            // 
            // txtPrintCopy
            // 
            this.txtPrintCopy.Location = new System.Drawing.Point(511, 196);
            this.txtPrintCopy.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrintCopy.Name = "txtPrintCopy";
            this.txtPrintCopy.Size = new System.Drawing.Size(169, 20);
            this.txtPrintCopy.TabIndex = 11;
            this.txtPrintCopy.Text = "2";
            this.txtPrintCopy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrintCopy_KeyPress);
            // 
            // txtRatePerTon
            // 
            this.txtRatePerTon.Location = new System.Drawing.Point(26, 141);
            this.txtRatePerTon.Margin = new System.Windows.Forms.Padding(2);
            this.txtRatePerTon.Name = "txtRatePerTon";
            this.txtRatePerTon.Size = new System.Drawing.Size(169, 20);
            this.txtRatePerTon.TabIndex = 6;
            this.txtRatePerTon.TextChanged += new System.EventHandler(this.TxtRatePerTon_TextChanged);
            this.txtRatePerTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRatePerTon_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(511, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 116;
            this.label6.Text = "Print Copy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(514, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "Bill No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(26, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "Amount Payable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(26, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Sale Rate (Ton)";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(514, 141);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(169, 20);
            this.txtInvoiceNo.TabIndex = 8;
            // 
            // txtCollectionAmt
            // 
            this.txtCollectionAmt.Enabled = false;
            this.txtCollectionAmt.Location = new System.Drawing.Point(26, 248);
            this.txtCollectionAmt.Margin = new System.Windows.Forms.Padding(2);
            this.txtCollectionAmt.Name = "txtCollectionAmt";
            this.txtCollectionAmt.Size = new System.Drawing.Size(169, 20);
            this.txtCollectionAmt.TabIndex = 12;
            // 
            // tbView
            // 
            this.tbView.BackColor = System.Drawing.Color.SandyBrown;
            this.tbView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbView.Controls.Add(this.grdInvoiceDetails);
            this.tbView.Controls.Add(this.label10);
            this.tbView.Controls.Add(this.txtOldInvoiceNo);
            this.tbView.Controls.Add(this.label9);
            this.tbView.Location = new System.Drawing.Point(4, 22);
            this.tbView.Margin = new System.Windows.Forms.Padding(2);
            this.tbView.Name = "tbView";
            this.tbView.Padding = new System.Windows.Forms.Padding(2);
            this.tbView.Size = new System.Drawing.Size(733, 417);
            this.tbView.TabIndex = 1;
            this.tbView.Text = "Re-Print Old Bill";
            // 
            // grdInvoiceDetails
            // 
            this.grdInvoiceDetails.AllowUserToAddRows = false;
            this.grdInvoiceDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInvoiceDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInvoiceDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInvoiceDetails.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdInvoiceDetails.Location = new System.Drawing.Point(31, 83);
            this.grdInvoiceDetails.Name = "grdInvoiceDetails";
            this.grdInvoiceDetails.ReadOnly = true;
            this.grdInvoiceDetails.RowHeadersVisible = false;
            this.grdInvoiceDetails.RowHeadersWidth = 62;
            this.grdInvoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInvoiceDetails.Size = new System.Drawing.Size(656, 280);
            this.grdInvoiceDetails.TabIndex = 121;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(34, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 120;
            this.label10.Text = "View Details";
            // 
            // txtOldInvoiceNo
            // 
            this.txtOldInvoiceNo.Location = new System.Drawing.Point(147, 25);
            this.txtOldInvoiceNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtOldInvoiceNo.Name = "txtOldInvoiceNo";
            this.txtOldInvoiceNo.Size = new System.Drawing.Size(126, 20);
            this.txtOldInvoiceNo.TabIndex = 118;
            this.txtOldInvoiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOldInvoiceNo_KeyPress);
            this.txtOldInvoiceNo.Leave += new System.EventHandler(this.TxtOldInvoiceNo_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(34, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 114;
            this.label9.Text = "Old Invoice No";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Image = global::EagleEye.Properties.Resources.img_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(616, 531);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 30);
            this.btnExit.TabIndex = 21;
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
            // frmInvoiceWR
            // 
            this.AcceptButton = this.btnGenerateInvoice;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1025, 680);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInvoiceWR";
            this.Text = "Bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInvoiceWR_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbEdit.ResumeLayout(false);
            this.tbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenseDetails)).EndInit();
            this.tbView.ResumeLayout(false);
            this.tbView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoiceDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnGenerateInvoice;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbEdit;
        private System.Windows.Forms.TextBox txtActualSaleQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAmountReceived;
        private System.Windows.Forms.DataGridView dgExpenseDetails;
        private System.Windows.Forms.TextBox txtPrintCopy;
        private System.Windows.Forms.TextBox txtRatePerTon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.TextBox txtCollectionAmt;
        private System.Windows.Forms.TabPage tbView;
        private System.Windows.Forms.DataGridView grdInvoiceDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOldInvoiceNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTruckNo;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.ComboBox cmbBuyer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.ComboBox cmbTaxType;
        private System.Windows.Forms.TextBox txtItemSlipRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSlipWeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkPaymentMade;
        private System.Windows.Forms.CheckBox chkTaxableInvoice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTaxInvoiceRate;
        private System.Windows.Forms.CheckBox chkOtherBuyer;
        private System.Windows.Forms.ComboBox cmbOtherBuyer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtInvoiceQty;
        private System.Windows.Forms.DateTimePicker dtBillDate;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.TextBox txtGSTNo;
    }
}
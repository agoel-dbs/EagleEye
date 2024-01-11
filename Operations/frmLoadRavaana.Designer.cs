namespace EagleEye.Operations
{
    partial class frmLoadRavaana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadRavaana));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbEdit = new System.Windows.Forms.TabPage();
            this.txtItemSlipRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSlipWeight = new System.Windows.Forms.TextBox();
            this.chkPaymentMade = new System.Windows.Forms.CheckBox();
            this.cmbBuyer = new System.Windows.Forms.ComboBox();
            this.chkOtherBuyer = new System.Windows.Forms.CheckBox();
            this.txtActualSaleQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmountReceived = new System.Windows.Forms.TextBox();
            this.dgExpenseDetails = new System.Windows.Forms.DataGridView();
            this.txtPrintCopy = new System.Windows.Forms.TextBox();
            this.grdRavaanaDetails = new System.Windows.Forms.DataGridView();
            this.txtRatePerTon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtCollectionAmt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbView = new System.Windows.Forms.TabPage();
            this.chkPrintMs = new System.Windows.Forms.CheckBox();
            this.chkPrintInvoice = new System.Windows.Forms.CheckBox();
            this.chkPrintSlip = new System.Windows.Forms.CheckBox();
            this.grdInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOldInvoiceNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenseDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRavaanaDetails)).BeginInit();
            this.tbView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoiceDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnCreateAccount);
            this.pnlMain.Controls.Add(this.btnReset);
            this.pnlMain.Controls.Add(this.btnPrintInvoice);
            this.pnlMain.Controls.Add(this.btnGenerateInvoice);
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.lblFormHeader);
            this.pnlMain.Controls.Add(this.btnLoadData);
            this.pnlMain.Location = new System.Drawing.Point(30, 21);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(880, 537);
            this.pnlMain.TabIndex = 44;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateAccount.Enabled = false;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCreateAccount.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnCreateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCreateAccount.Location = new System.Drawing.Point(477, 494);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(129, 30);
            this.btnCreateAccount.TabIndex = 92;
            this.btnCreateAccount.Text = "  &New Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReset.Image = global::EagleEye.Properties.Resources.img_load;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReset.Location = new System.Drawing.Point(625, 494);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 30);
            this.btnReset.TabIndex = 91;
            this.btnReset.Text = "   &Clear Files";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrintInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPrintInvoice.Image = global::EagleEye.Properties.Resources.img_print;
            this.btnPrintInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintInvoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrintInvoice.Location = new System.Drawing.Point(318, 494);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(140, 30);
            this.btnPrintInvoice.TabIndex = 12;
            this.btnPrintInvoice.Text = "  &Re-Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.BtnPrintInvoice_Click);
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerateInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerateInvoice.Enabled = false;
            this.btnGenerateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateInvoice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGenerateInvoice.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnGenerateInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateInvoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGenerateInvoice.Location = new System.Drawing.Point(156, 494);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(143, 30);
            this.btnGenerateInvoice.TabIndex = 11;
            this.btnGenerateInvoice.Text = "  &Generate Invoice";
            this.btnGenerateInvoice.UseVisualStyleBackColor = false;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.BtnGenerateInvoice_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbEdit);
            this.tabMain.Controls.Add(this.tbView);
            this.tabMain.Location = new System.Drawing.Point(29, 64);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(837, 425);
            this.tabMain.TabIndex = 90;
            // 
            // tbEdit
            // 
            this.tbEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.tbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEdit.Controls.Add(this.txtItemSlipRate);
            this.tbEdit.Controls.Add(this.label12);
            this.tbEdit.Controls.Add(this.label11);
            this.tbEdit.Controls.Add(this.txtSlipWeight);
            this.tbEdit.Controls.Add(this.chkPaymentMade);
            this.tbEdit.Controls.Add(this.cmbBuyer);
            this.tbEdit.Controls.Add(this.chkOtherBuyer);
            this.tbEdit.Controls.Add(this.txtActualSaleQty);
            this.tbEdit.Controls.Add(this.label7);
            this.tbEdit.Controls.Add(this.label8);
            this.tbEdit.Controls.Add(this.txtAmountReceived);
            this.tbEdit.Controls.Add(this.dgExpenseDetails);
            this.tbEdit.Controls.Add(this.txtPrintCopy);
            this.tbEdit.Controls.Add(this.grdRavaanaDetails);
            this.tbEdit.Controls.Add(this.txtRatePerTon);
            this.tbEdit.Controls.Add(this.label6);
            this.tbEdit.Controls.Add(this.label4);
            this.tbEdit.Controls.Add(this.label3);
            this.tbEdit.Controls.Add(this.label1);
            this.tbEdit.Controls.Add(this.txtInvoiceNo);
            this.tbEdit.Controls.Add(this.txtCollectionAmt);
            this.tbEdit.Controls.Add(this.label5);
            this.tbEdit.Controls.Add(this.label2);
            this.tbEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEdit.Location = new System.Drawing.Point(4, 22);
            this.tbEdit.Margin = new System.Windows.Forms.Padding(2);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Padding = new System.Windows.Forms.Padding(2);
            this.tbEdit.Size = new System.Drawing.Size(829, 399);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.Text = "View Ravaana Details";
            // 
            // txtItemSlipRate
            // 
            this.txtItemSlipRate.Location = new System.Drawing.Point(484, 250);
            this.txtItemSlipRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemSlipRate.Name = "txtItemSlipRate";
            this.txtItemSlipRate.Size = new System.Drawing.Size(153, 20);
            this.txtItemSlipRate.TabIndex = 129;
            this.txtItemSlipRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItemSlipRate_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(484, 233);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 130;
            this.label12.Text = "Slip Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(668, 233);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 128;
            this.label11.Text = "Slip Qty(MT)";
            // 
            // txtSlipWeight
            // 
            this.txtSlipWeight.Location = new System.Drawing.Point(668, 250);
            this.txtSlipWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtSlipWeight.Name = "txtSlipWeight";
            this.txtSlipWeight.Size = new System.Drawing.Size(153, 20);
            this.txtSlipWeight.TabIndex = 127;
            this.txtSlipWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSlipWeight_KeyPress);
            // 
            // chkPaymentMade
            // 
            this.chkPaymentMade.AutoSize = true;
            this.chkPaymentMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.chkPaymentMade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkPaymentMade.Location = new System.Drawing.Point(671, 365);
            this.chkPaymentMade.Margin = new System.Windows.Forms.Padding(2);
            this.chkPaymentMade.Name = "chkPaymentMade";
            this.chkPaymentMade.Size = new System.Drawing.Size(83, 17);
            this.chkPaymentMade.TabIndex = 126;
            this.chkPaymentMade.Text = "Cash Paid";
            this.chkPaymentMade.UseVisualStyleBackColor = true;
            this.chkPaymentMade.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkPaymentMade_MouseClick);
            // 
            // cmbBuyer
            // 
            this.cmbBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuyer.Enabled = false;
            this.cmbBuyer.FormattingEnabled = true;
            this.cmbBuyer.Location = new System.Drawing.Point(671, 151);
            this.cmbBuyer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBuyer.Name = "cmbBuyer";
            this.cmbBuyer.Size = new System.Drawing.Size(153, 21);
            this.cmbBuyer.TabIndex = 4;
            // 
            // chkOtherBuyer
            // 
            this.chkOtherBuyer.AutoSize = true;
            this.chkOtherBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.chkOtherBuyer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkOtherBuyer.Location = new System.Drawing.Point(482, 153);
            this.chkOtherBuyer.Margin = new System.Windows.Forms.Padding(2);
            this.chkOtherBuyer.Name = "chkOtherBuyer";
            this.chkOtherBuyer.Size = new System.Drawing.Size(157, 17);
            this.chkOtherBuyer.TabIndex = 3;
            this.chkOtherBuyer.Text = "Paid by Different Buyer";
            this.chkOtherBuyer.UseVisualStyleBackColor = true;
            this.chkOtherBuyer.CheckedChanged += new System.EventHandler(this.ChkOtherBuyer_CheckedChanged);
            // 
            // txtActualSaleQty
            // 
            this.txtActualSaleQty.Location = new System.Drawing.Point(671, 205);
            this.txtActualSaleQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualSaleQty.Name = "txtActualSaleQty";
            this.txtActualSaleQty.Size = new System.Drawing.Size(153, 20);
            this.txtActualSaleQty.TabIndex = 6;
            this.txtActualSaleQty.TextChanged += new System.EventHandler(this.TxtActualSaleQty_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(671, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "Material Qty(MT)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(671, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 124;
            this.label8.Text = "Amount Received";
            // 
            // txtAmountReceived
            // 
            this.txtAmountReceived.Location = new System.Drawing.Point(671, 338);
            this.txtAmountReceived.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmountReceived.Name = "txtAmountReceived";
            this.txtAmountReceived.Size = new System.Drawing.Size(153, 20);
            this.txtAmountReceived.TabIndex = 10;
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
            this.dgExpenseDetails.Location = new System.Drawing.Point(482, 28);
            this.dgExpenseDetails.Name = "dgExpenseDetails";
            this.dgExpenseDetails.RowHeadersVisible = false;
            this.dgExpenseDetails.RowHeadersWidth = 62;
            this.dgExpenseDetails.Size = new System.Drawing.Size(341, 108);
            this.dgExpenseDetails.TabIndex = 2;
            // 
            // txtPrintCopy
            // 
            this.txtPrintCopy.Location = new System.Drawing.Point(671, 294);
            this.txtPrintCopy.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrintCopy.Name = "txtPrintCopy";
            this.txtPrintCopy.Size = new System.Drawing.Size(153, 20);
            this.txtPrintCopy.TabIndex = 8;
            this.txtPrintCopy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrintCopy_KeyPress);
            // 
            // grdRavaanaDetails
            // 
            this.grdRavaanaDetails.AllowUserToAddRows = false;
            this.grdRavaanaDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRavaanaDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRavaanaDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdRavaanaDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRavaanaDetails.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdRavaanaDetails.Location = new System.Drawing.Point(10, 28);
            this.grdRavaanaDetails.Name = "grdRavaanaDetails";
            this.grdRavaanaDetails.ReadOnly = true;
            this.grdRavaanaDetails.RowHeadersVisible = false;
            this.grdRavaanaDetails.RowHeadersWidth = 62;
            this.grdRavaanaDetails.Size = new System.Drawing.Size(450, 367);
            this.grdRavaanaDetails.TabIndex = 119;
            // 
            // txtRatePerTon
            // 
            this.txtRatePerTon.Location = new System.Drawing.Point(482, 205);
            this.txtRatePerTon.Margin = new System.Windows.Forms.Padding(2);
            this.txtRatePerTon.Name = "txtRatePerTon";
            this.txtRatePerTon.Size = new System.Drawing.Size(153, 20);
            this.txtRatePerTon.TabIndex = 5;
            this.txtRatePerTon.TextChanged += new System.EventHandler(this.TxtRatePerTon_TextChanged);
            this.txtRatePerTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRatePerTon_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(671, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 116;
            this.label6.Text = "Print Copy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(482, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "Invoice No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(482, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "Amount Payable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(482, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Sale Rate (Ton)";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(482, 294);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(153, 20);
            this.txtInvoiceNo.TabIndex = 7;
            this.txtInvoiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInvoiceNo_KeyPress);
            // 
            // txtCollectionAmt
            // 
            this.txtCollectionAmt.Enabled = false;
            this.txtCollectionAmt.Location = new System.Drawing.Point(482, 338);
            this.txtCollectionAmt.Margin = new System.Windows.Forms.Padding(2);
            this.txtCollectionAmt.Name = "txtCollectionAmt";
            this.txtCollectionAmt.Size = new System.Drawing.Size(153, 20);
            this.txtCollectionAmt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(4, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "Ravaana Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(481, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Expense Details";
            // 
            // tbView
            // 
            this.tbView.BackColor = System.Drawing.Color.SandyBrown;
            this.tbView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbView.Controls.Add(this.chkPrintMs);
            this.tbView.Controls.Add(this.chkPrintInvoice);
            this.tbView.Controls.Add(this.chkPrintSlip);
            this.tbView.Controls.Add(this.grdInvoiceDetails);
            this.tbView.Controls.Add(this.label10);
            this.tbView.Controls.Add(this.txtOldInvoiceNo);
            this.tbView.Controls.Add(this.label9);
            this.tbView.Location = new System.Drawing.Point(4, 22);
            this.tbView.Margin = new System.Windows.Forms.Padding(2);
            this.tbView.Name = "tbView";
            this.tbView.Padding = new System.Windows.Forms.Padding(2);
            this.tbView.Size = new System.Drawing.Size(829, 399);
            this.tbView.TabIndex = 1;
            this.tbView.Text = "Re-Print Old Invoice";
            // 
            // chkPrintMs
            // 
            this.chkPrintMs.AutoSize = true;
            this.chkPrintMs.Checked = true;
            this.chkPrintMs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrintMs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkPrintMs.Location = new System.Drawing.Point(716, 24);
            this.chkPrintMs.Margin = new System.Windows.Forms.Padding(2);
            this.chkPrintMs.Name = "chkPrintMs";
            this.chkPrintMs.Size = new System.Drawing.Size(72, 17);
            this.chkPrintMs.TabIndex = 124;
            this.chkPrintMs.Text = "Print M/s ";
            this.chkPrintMs.UseVisualStyleBackColor = true;
            // 
            // chkPrintInvoice
            // 
            this.chkPrintInvoice.AutoSize = true;
            this.chkPrintInvoice.Checked = true;
            this.chkPrintInvoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrintInvoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkPrintInvoice.Location = new System.Drawing.Point(575, 23);
            this.chkPrintInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.chkPrintInvoice.Name = "chkPrintInvoice";
            this.chkPrintInvoice.Size = new System.Drawing.Size(85, 17);
            this.chkPrintInvoice.TabIndex = 123;
            this.chkPrintInvoice.Text = "Print Invoice";
            this.chkPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // chkPrintSlip
            // 
            this.chkPrintSlip.AutoSize = true;
            this.chkPrintSlip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkPrintSlip.Location = new System.Drawing.Point(455, 23);
            this.chkPrintSlip.Margin = new System.Windows.Forms.Padding(2);
            this.chkPrintSlip.Name = "chkPrintSlip";
            this.chkPrintSlip.Size = new System.Drawing.Size(67, 17);
            this.chkPrintSlip.TabIndex = 122;
            this.chkPrintSlip.Text = "Print Slip";
            this.chkPrintSlip.UseVisualStyleBackColor = true;
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
            this.grdInvoiceDetails.Location = new System.Drawing.Point(34, 83);
            this.grdInvoiceDetails.Name = "grdInvoiceDetails";
            this.grdInvoiceDetails.ReadOnly = true;
            this.grdInvoiceDetails.RowHeadersVisible = false;
            this.grdInvoiceDetails.RowHeadersWidth = 62;
            this.grdInvoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInvoiceDetails.Size = new System.Drawing.Size(767, 314);
            this.grdInvoiceDetails.TabIndex = 121;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(34, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 120;
            this.label10.Text = "View Details";
            // 
            // txtOldInvoiceNo
            // 
            this.txtOldInvoiceNo.Location = new System.Drawing.Point(163, 23);
            this.txtOldInvoiceNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtOldInvoiceNo.Name = "txtOldInvoiceNo";
            this.txtOldInvoiceNo.Size = new System.Drawing.Size(126, 20);
            this.txtOldInvoiceNo.TabIndex = 118;
            this.txtOldInvoiceNo.Leave += new System.EventHandler(this.TxtOldInvoiceNo_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(763, 494);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "   &Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblFormHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFormHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFormHeader.Location = new System.Drawing.Point(189, 0);
            this.lblFormHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(67, 15);
            this.lblFormHeader.TabIndex = 89;
            this.lblFormHeader.Text = "Header";
            this.lblFormHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadData.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLoadData.Image = global::EagleEye.Properties.Resources.img_load;
            this.btnLoadData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLoadData.Location = new System.Drawing.Point(29, 494);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(107, 30);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "   &Load Data";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.BtnLoadData_Click);
            // 
            // frmLoadRavaana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(960, 582);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLoadRavaana";
            this.Text = "frmLoadRavaana";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLoadRavaana_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbEdit.ResumeLayout(false);
            this.tbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenseDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRavaanaDetails)).EndInit();
            this.tbView.ResumeLayout(false);
            this.tbView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoiceDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnGenerateInvoice;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbEdit;
        private System.Windows.Forms.TextBox txtItemSlipRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSlipWeight;
        private System.Windows.Forms.CheckBox chkPaymentMade;
        private System.Windows.Forms.ComboBox cmbBuyer;
        private System.Windows.Forms.CheckBox chkOtherBuyer;
        private System.Windows.Forms.TextBox txtActualSaleQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAmountReceived;
        private System.Windows.Forms.DataGridView dgExpenseDetails;
        private System.Windows.Forms.TextBox txtPrintCopy;
        private System.Windows.Forms.DataGridView grdRavaanaDetails;
        private System.Windows.Forms.TextBox txtRatePerTon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.TextBox txtCollectionAmt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbView;
        private System.Windows.Forms.CheckBox chkPrintInvoice;
        private System.Windows.Forms.CheckBox chkPrintSlip;
        private System.Windows.Forms.DataGridView grdInvoiceDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOldInvoiceNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.CheckBox chkPrintMs;
    }
}
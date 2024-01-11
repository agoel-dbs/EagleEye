namespace EagleEye
{
    partial class frmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.tplOtherInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblSellerSign = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.tplTaxInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalAmtWord = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblAccountDetail = new System.Windows.Forms.Label();
            this.lblCertify = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCGST = new System.Windows.Forms.Label();
            this.lblSGST = new System.Windows.Forms.Label();
            this.lblIGST = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblBeforeTaxAmt = new System.Windows.Forms.Label();
            this.lblCGSTAmt = new System.Windows.Forms.Label();
            this.lblSGSTAmt = new System.Windows.Forms.Label();
            this.lblIGSTAmt = new System.Windows.Forms.Label();
            this.lblTotalAmt = new System.Windows.Forms.Label();
            this.tplMaterialInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInvUOM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.lblHSN = new System.Windows.Forms.Label();
            this.lblInvQty = new System.Windows.Forms.Label();
            this.lblInvAmt = new System.Windows.Forms.Label();
            this.tplBuyerInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.lblSellerAdd1 = new System.Windows.Forms.Label();
            this.lblSellerAdd2 = new System.Windows.Forms.Label();
            this.lblSellerAdd3 = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.lblBuyerAdd1 = new System.Windows.Forms.Label();
            this.lblBuyerGSTIN = new System.Windows.Forms.Label();
            this.lblSellerGSTNo = new System.Windows.Forms.Label();
            this.tpInvoiceInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblInvoiceHeader = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblInvoiceNoValue = new System.Windows.Forms.Label();
            this.lblInvDate = new System.Windows.Forms.Label();
            this.lblInvTime = new System.Windows.Forms.Label();
            this.lblInvDateVal = new System.Windows.Forms.Label();
            this.lblTruckNo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblRavannaNo = new System.Windows.Forms.Label();
            this.printInvoiceDoc = new System.Drawing.Printing.PrintDocument();
            this.printInvoicePreview = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrintInv = new System.Windows.Forms.Button();
            this.pnlInvoice.SuspendLayout();
            this.tplOtherInfo.SuspendLayout();
            this.tplTaxInfo.SuspendLayout();
            this.tplMaterialInfo.SuspendLayout();
            this.tplBuyerInfo.SuspendLayout();
            this.tpInvoiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.Controls.Add(this.tplOtherInfo);
            this.pnlInvoice.Controls.Add(this.tplTaxInfo);
            this.pnlInvoice.Controls.Add(this.tplMaterialInfo);
            this.pnlInvoice.Controls.Add(this.tplBuyerInfo);
            this.pnlInvoice.Controls.Add(this.tpInvoiceInfo);
            this.pnlInvoice.Location = new System.Drawing.Point(15, 28);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(677, 844);
            this.pnlInvoice.TabIndex = 0;
            // 
            // tplOtherInfo
            // 
            this.tplOtherInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tplOtherInfo.ColumnCount = 2;
            this.tplOtherInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplOtherInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplOtherInfo.Controls.Add(this.lblSellerSign, 1, 0);
            this.tplOtherInfo.Controls.Add(this.label5, 0, 1);
            this.tplOtherInfo.Controls.Add(this.lblInstruction, 0, 2);
            this.tplOtherInfo.Location = new System.Drawing.Point(3, 743);
            this.tplOtherInfo.Name = "tplOtherInfo";
            this.tplOtherInfo.RowCount = 3;
            this.tplOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tplOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tplOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tplOtherInfo.Size = new System.Drawing.Size(671, 93);
            this.tplOtherInfo.TabIndex = 4;
            // 
            // lblSellerSign
            // 
            this.lblSellerSign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSellerSign.AutoSize = true;
            this.lblSellerSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerSign.Location = new System.Drawing.Point(443, 2);
            this.lblSellerSign.Name = "lblSellerSign";
            this.lblSellerSign.Size = new System.Drawing.Size(119, 25);
            this.lblSellerSign.TabIndex = 1;
            this.lblSellerSign.Text = "Seller Name";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Receiver\'s Signature";
            // 
            // lblInstruction
            // 
            this.lblInstruction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInstruction.AutoSize = true;
            this.tplOtherInfo.SetColumnSpan(this.lblInstruction, 2);
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(265, 68);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(141, 17);
            this.lblInstruction.TabIndex = 3;
            this.lblInstruction.Text = "Computer Generated";
            // 
            // tplTaxInfo
            // 
            this.tplTaxInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tplTaxInfo.ColumnCount = 3;
            this.tplTaxInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.4871F));
            this.tplTaxInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.25407F));
            this.tplTaxInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.25883F));
            this.tplTaxInfo.Controls.Add(this.lblTotalAmtWord, 0, 0);
            this.tplTaxInfo.Controls.Add(this.label7, 0, 1);
            this.tplTaxInfo.Controls.Add(this.lblBankName, 0, 2);
            this.tplTaxInfo.Controls.Add(this.lblAccountDetail, 0, 3);
            this.tplTaxInfo.Controls.Add(this.lblCertify, 0, 4);
            this.tplTaxInfo.Controls.Add(this.label11, 1, 0);
            this.tplTaxInfo.Controls.Add(this.lblCGST, 1, 1);
            this.tplTaxInfo.Controls.Add(this.lblSGST, 1, 2);
            this.tplTaxInfo.Controls.Add(this.lblIGST, 1, 3);
            this.tplTaxInfo.Controls.Add(this.lblGrandTotal, 1, 4);
            this.tplTaxInfo.Controls.Add(this.lblBeforeTaxAmt, 2, 0);
            this.tplTaxInfo.Controls.Add(this.lblCGSTAmt, 2, 1);
            this.tplTaxInfo.Controls.Add(this.lblSGSTAmt, 2, 2);
            this.tplTaxInfo.Controls.Add(this.lblIGSTAmt, 2, 3);
            this.tplTaxInfo.Controls.Add(this.lblTotalAmt, 2, 4);
            this.tplTaxInfo.Location = new System.Drawing.Point(3, 533);
            this.tplTaxInfo.Name = "tplTaxInfo";
            this.tplTaxInfo.RowCount = 5;
            this.tplTaxInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tplTaxInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tplTaxInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tplTaxInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tplTaxInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tplTaxInfo.Size = new System.Drawing.Size(671, 208);
            this.tplTaxInfo.TabIndex = 3;
            // 
            // lblTotalAmtWord
            // 
            this.lblTotalAmtWord.AutoSize = true;
            this.lblTotalAmtWord.Location = new System.Drawing.Point(4, 1);
            this.lblTotalAmtWord.Name = "lblTotalAmtWord";
            this.lblTotalAmtWord.Size = new System.Drawing.Size(105, 20);
            this.lblTotalAmtWord.TabIndex = 0;
            this.lblTotalAmtWord.Text = "Amount in Rs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Company Bank Details";
            // 
            // lblBankName
            // 
            this.lblBankName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.Location = new System.Drawing.Point(4, 114);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(90, 17);
            this.lblBankName.TabIndex = 2;
            this.lblBankName.Text = "Bank Name";
            // 
            // lblAccountDetail
            // 
            this.lblAccountDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAccountDetail.AutoSize = true;
            this.lblAccountDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountDetail.Location = new System.Drawing.Point(4, 154);
            this.lblAccountDetail.Name = "lblAccountDetail";
            this.lblAccountDetail.Size = new System.Drawing.Size(195, 20);
            this.lblAccountDetail.TabIndex = 3;
            this.lblAccountDetail.Text = "Account No IFSC Code";
            // 
            // lblCertify
            // 
            this.lblCertify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCertify.AutoSize = true;
            this.lblCertify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertify.Location = new System.Drawing.Point(4, 187);
            this.lblCertify.Name = "lblCertify";
            this.lblCertify.Size = new System.Drawing.Size(48, 17);
            this.lblCertify.TabIndex = 4;
            this.lblCertify.Text = "Certify";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(455, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Total";
            // 
            // lblCGST
            // 
            this.lblCGST.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCGST.AutoSize = true;
            this.lblCGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCGST.Location = new System.Drawing.Point(455, 73);
            this.lblCGST.Name = "lblCGST";
            this.lblCGST.Size = new System.Drawing.Size(46, 17);
            this.lblCGST.TabIndex = 6;
            this.lblCGST.Text = "CGST";
            // 
            // lblSGST
            // 
            this.lblSGST.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSGST.AutoSize = true;
            this.lblSGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSGST.Location = new System.Drawing.Point(455, 114);
            this.lblSGST.Name = "lblSGST";
            this.lblSGST.Size = new System.Drawing.Size(46, 17);
            this.lblSGST.TabIndex = 7;
            this.lblSGST.Text = "SGST";
            // 
            // lblIGST
            // 
            this.lblIGST.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIGST.AutoSize = true;
            this.lblIGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGST.Location = new System.Drawing.Point(455, 155);
            this.lblIGST.Name = "lblIGST";
            this.lblIGST.Size = new System.Drawing.Size(40, 17);
            this.lblIGST.TabIndex = 8;
            this.lblIGST.Text = "IGST";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(455, 186);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(68, 20);
            this.lblGrandTotal.TabIndex = 9;
            this.lblGrandTotal.Text = "G.Total";
            // 
            // lblBeforeTaxAmt
            // 
            this.lblBeforeTaxAmt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBeforeTaxAmt.AutoSize = true;
            this.lblBeforeTaxAmt.Location = new System.Drawing.Point(653, 21);
            this.lblBeforeTaxAmt.Name = "lblBeforeTaxAmt";
            this.lblBeforeTaxAmt.Size = new System.Drawing.Size(14, 20);
            this.lblBeforeTaxAmt.TabIndex = 10;
            this.lblBeforeTaxAmt.Text = "-";
            // 
            // lblCGSTAmt
            // 
            this.lblCGSTAmt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCGSTAmt.AutoSize = true;
            this.lblCGSTAmt.Location = new System.Drawing.Point(653, 72);
            this.lblCGSTAmt.Name = "lblCGSTAmt";
            this.lblCGSTAmt.Size = new System.Drawing.Size(14, 20);
            this.lblCGSTAmt.TabIndex = 11;
            this.lblCGSTAmt.Text = "-";
            // 
            // lblSGSTAmt
            // 
            this.lblSGSTAmt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSGSTAmt.AutoSize = true;
            this.lblSGSTAmt.Location = new System.Drawing.Point(653, 113);
            this.lblSGSTAmt.Name = "lblSGSTAmt";
            this.lblSGSTAmt.Size = new System.Drawing.Size(14, 20);
            this.lblSGSTAmt.TabIndex = 12;
            this.lblSGSTAmt.Text = "-";
            // 
            // lblIGSTAmt
            // 
            this.lblIGSTAmt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIGSTAmt.AutoSize = true;
            this.lblIGSTAmt.Location = new System.Drawing.Point(653, 154);
            this.lblIGSTAmt.Name = "lblIGSTAmt";
            this.lblIGSTAmt.Size = new System.Drawing.Size(14, 20);
            this.lblIGSTAmt.TabIndex = 13;
            this.lblIGSTAmt.Text = "-";
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalAmt.AutoSize = true;
            this.lblTotalAmt.Location = new System.Drawing.Point(653, 186);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(14, 20);
            this.lblTotalAmt.TabIndex = 14;
            this.lblTotalAmt.Text = "-";
            // 
            // tplMaterialInfo
            // 
            this.tplMaterialInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tplMaterialInfo.ColumnCount = 4;
            this.tplMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tplMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tplMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.37267F));
            this.tplMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            this.tplMaterialInfo.Controls.Add(this.label2, 0, 0);
            this.tplMaterialInfo.Controls.Add(this.label3, 1, 0);
            this.tplMaterialInfo.Controls.Add(this.lblInvUOM, 2, 0);
            this.tplMaterialInfo.Controls.Add(this.label6, 3, 0);
            this.tplMaterialInfo.Controls.Add(this.lblItemDesc, 0, 1);
            this.tplMaterialInfo.Controls.Add(this.lblHSN, 1, 1);
            this.tplMaterialInfo.Controls.Add(this.lblInvQty, 2, 1);
            this.tplMaterialInfo.Controls.Add(this.lblInvAmt, 3, 1);
            this.tplMaterialInfo.Location = new System.Drawing.Point(3, 296);
            this.tplMaterialInfo.Name = "tplMaterialInfo";
            this.tplMaterialInfo.RowCount = 2;
            this.tplMaterialInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.47418F));
            this.tplMaterialInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.52582F));
            this.tplMaterialInfo.Size = new System.Drawing.Size(671, 231);
            this.tplMaterialInfo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item Description";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "HSN";
            // 
            // lblInvUOM
            // 
            this.lblInvUOM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvUOM.AutoSize = true;
            this.lblInvUOM.Location = new System.Drawing.Point(467, 17);
            this.lblInvUOM.Name = "lblInvUOM";
            this.lblInvUOM.Size = new System.Drawing.Size(69, 20);
            this.lblInvUOM.TabIndex = 2;
            this.lblInvUOM.Text = "Qty (MT)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 40);
            this.label6.TabIndex = 4;
            this.label6.Text = "Before Tax Amount (INR)";
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.AutoSize = true;
            this.lblItemDesc.Location = new System.Drawing.Point(4, 55);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(41, 20);
            this.lblItemDesc.TabIndex = 5;
            this.lblItemDesc.Text = "Item";
            // 
            // lblHSN
            // 
            this.lblHSN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHSN.AutoSize = true;
            this.lblHSN.Location = new System.Drawing.Point(386, 55);
            this.lblHSN.Name = "lblHSN";
            this.lblHSN.Size = new System.Drawing.Size(43, 20);
            this.lblHSN.TabIndex = 6;
            this.lblHSN.Text = "HSN";
            // 
            // lblInvQty
            // 
            this.lblInvQty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInvQty.AutoSize = true;
            this.lblInvQty.Location = new System.Drawing.Point(481, 55);
            this.lblInvQty.Name = "lblInvQty";
            this.lblInvQty.Size = new System.Drawing.Size(41, 20);
            this.lblInvQty.TabIndex = 7;
            this.lblInvQty.Text = "QTY";
            // 
            // lblInvAmt
            // 
            this.lblInvAmt.AutoSize = true;
            this.lblInvAmt.Location = new System.Drawing.Point(556, 55);
            this.lblInvAmt.Name = "lblInvAmt";
            this.lblInvAmt.Size = new System.Drawing.Size(65, 20);
            this.lblInvAmt.TabIndex = 9;
            this.lblInvAmt.Text = "Amount";
            // 
            // tplBuyerInfo
            // 
            this.tplBuyerInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tplBuyerInfo.ColumnCount = 2;
            this.tplBuyerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.16418F));
            this.tplBuyerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.83582F));
            this.tplBuyerInfo.Controls.Add(this.lblSellerName, 0, 0);
            this.tplBuyerInfo.Controls.Add(this.lblSellerAdd1, 0, 1);
            this.tplBuyerInfo.Controls.Add(this.lblSellerAdd2, 0, 2);
            this.tplBuyerInfo.Controls.Add(this.lblSellerAdd3, 0, 3);
            this.tplBuyerInfo.Controls.Add(this.lblBuyer, 1, 0);
            this.tplBuyerInfo.Controls.Add(this.lblBuyerAdd1, 1, 2);
            this.tplBuyerInfo.Controls.Add(this.lblBuyerGSTIN, 1, 4);
            this.tplBuyerInfo.Controls.Add(this.lblSellerGSTNo, 0, 4);
            this.tplBuyerInfo.Location = new System.Drawing.Point(3, 142);
            this.tplBuyerInfo.Name = "tplBuyerInfo";
            this.tplBuyerInfo.RowCount = 5;
            this.tplBuyerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tplBuyerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tplBuyerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tplBuyerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tplBuyerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tplBuyerInfo.Size = new System.Drawing.Size(671, 148);
            this.tplBuyerInfo.TabIndex = 1;
            // 
            // lblSellerName
            // 
            this.lblSellerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.Location = new System.Drawing.Point(4, 5);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(91, 20);
            this.lblSellerName.TabIndex = 0;
            this.lblSellerName.Text = "SellerName";
            // 
            // lblSellerAdd1
            // 
            this.lblSellerAdd1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSellerAdd1.AutoSize = true;
            this.lblSellerAdd1.Location = new System.Drawing.Point(4, 34);
            this.lblSellerAdd1.Name = "lblSellerAdd1";
            this.lblSellerAdd1.Size = new System.Drawing.Size(47, 20);
            this.lblSellerAdd1.TabIndex = 1;
            this.lblSellerAdd1.Text = "Add1";
            // 
            // lblSellerAdd2
            // 
            this.lblSellerAdd2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSellerAdd2.AutoSize = true;
            this.lblSellerAdd2.Location = new System.Drawing.Point(4, 63);
            this.lblSellerAdd2.Name = "lblSellerAdd2";
            this.lblSellerAdd2.Size = new System.Drawing.Size(47, 20);
            this.lblSellerAdd2.TabIndex = 2;
            this.lblSellerAdd2.Text = "Add2";
            // 
            // lblSellerAdd3
            // 
            this.lblSellerAdd3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSellerAdd3.AutoSize = true;
            this.lblSellerAdd3.Location = new System.Drawing.Point(4, 92);
            this.lblSellerAdd3.Name = "lblSellerAdd3";
            this.lblSellerAdd3.Size = new System.Drawing.Size(47, 20);
            this.lblSellerAdd3.TabIndex = 3;
            this.lblSellerAdd3.Text = "Add3";
            // 
            // lblBuyer
            // 
            this.lblBuyer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Location = new System.Drawing.Point(320, 19);
            this.lblBuyer.Name = "lblBuyer";
            this.tplBuyerInfo.SetRowSpan(this.lblBuyer, 2);
            this.lblBuyer.Size = new System.Drawing.Size(50, 20);
            this.lblBuyer.TabIndex = 8;
            this.lblBuyer.Text = "Buyer";
            // 
            // lblBuyerAdd1
            // 
            this.lblBuyerAdd1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuyerAdd1.AutoSize = true;
            this.lblBuyerAdd1.Location = new System.Drawing.Point(320, 77);
            this.lblBuyerAdd1.Name = "lblBuyerAdd1";
            this.tplBuyerInfo.SetRowSpan(this.lblBuyerAdd1, 2);
            this.lblBuyerAdd1.Size = new System.Drawing.Size(47, 20);
            this.lblBuyerAdd1.TabIndex = 5;
            this.lblBuyerAdd1.Text = "Add1";
            // 
            // lblBuyerGSTIN
            // 
            this.lblBuyerGSTIN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuyerGSTIN.AutoSize = true;
            this.lblBuyerGSTIN.Location = new System.Drawing.Point(320, 122);
            this.lblBuyerGSTIN.Name = "lblBuyerGSTIN";
            this.lblBuyerGSTIN.Size = new System.Drawing.Size(58, 20);
            this.lblBuyerGSTIN.TabIndex = 7;
            this.lblBuyerGSTIN.Text = "GSTIN";
            // 
            // lblSellerGSTNo
            // 
            this.lblSellerGSTNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSellerGSTNo.AutoSize = true;
            this.lblSellerGSTNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerGSTNo.Location = new System.Drawing.Point(4, 120);
            this.lblSellerGSTNo.Name = "lblSellerGSTNo";
            this.lblSellerGSTNo.Size = new System.Drawing.Size(61, 24);
            this.lblSellerGSTNo.TabIndex = 9;
            this.lblSellerGSTNo.Text = "GSTIN:";
            this.lblSellerGSTNo.UseCompatibleTextRendering = true;
            // 
            // tpInvoiceInfo
            // 
            this.tpInvoiceInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tpInvoiceInfo.ColumnCount = 4;
            this.tpInvoiceInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.50835F));
            this.tpInvoiceInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.85075F));
            this.tpInvoiceInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.22388F));
            this.tpInvoiceInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.27162F));
            this.tpInvoiceInfo.Controls.Add(this.lblInvoiceHeader, 1, 0);
            this.tpInvoiceInfo.Controls.Add(this.lblInvoiceNo, 2, 0);
            this.tpInvoiceInfo.Controls.Add(this.lblInvoiceNoValue, 3, 0);
            this.tpInvoiceInfo.Controls.Add(this.lblInvDate, 2, 1);
            this.tpInvoiceInfo.Controls.Add(this.lblInvTime, 2, 2);
            this.tpInvoiceInfo.Controls.Add(this.lblInvDateVal, 3, 1);
            this.tpInvoiceInfo.Controls.Add(this.lblTruckNo, 3, 2);
            this.tpInvoiceInfo.Controls.Add(this.picLogo, 0, 0);
            this.tpInvoiceInfo.Controls.Add(this.lblRavannaNo, 1, 1);
            this.tpInvoiceInfo.Location = new System.Drawing.Point(3, 3);
            this.tpInvoiceInfo.Name = "tpInvoiceInfo";
            this.tpInvoiceInfo.RowCount = 3;
            this.tpInvoiceInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tpInvoiceInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tpInvoiceInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tpInvoiceInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpInvoiceInfo.Size = new System.Drawing.Size(671, 130);
            this.tpInvoiceInfo.TabIndex = 0;
            // 
            // lblInvoiceHeader
            // 
            this.lblInvoiceHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvoiceHeader.AutoSize = true;
            this.lblInvoiceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceHeader.Location = new System.Drawing.Point(264, 7);
            this.lblInvoiceHeader.Name = "lblInvoiceHeader";
            this.lblInvoiceHeader.Size = new System.Drawing.Size(146, 29);
            this.lblInvoiceHeader.TabIndex = 1;
            this.lblInvoiceHeader.Text = "Tax Invoice";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(441, 12);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(87, 20);
            this.lblInvoiceNo.TabIndex = 3;
            this.lblInvoiceNo.Text = "InvoiceNo :";
            // 
            // lblInvoiceNoValue
            // 
            this.lblInvoiceNoValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvoiceNoValue.AutoSize = true;
            this.lblInvoiceNoValue.Location = new System.Drawing.Point(593, 12);
            this.lblInvoiceNoValue.Name = "lblInvoiceNoValue";
            this.lblInvoiceNoValue.Size = new System.Drawing.Size(23, 20);
            this.lblInvoiceNoValue.TabIndex = 4;
            this.lblInvoiceNoValue.Text = "-1";
            // 
            // lblInvDate
            // 
            this.lblInvDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInvDate.AutoSize = true;
            this.lblInvDate.Location = new System.Drawing.Point(441, 45);
            this.lblInvDate.Name = "lblInvDate";
            this.lblInvDate.Size = new System.Drawing.Size(76, 40);
            this.lblInvDate.TabIndex = 5;
            this.lblInvDate.Text = "Dispatch Time:";
            // 
            // lblInvTime
            // 
            this.lblInvTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInvTime.AutoSize = true;
            this.lblInvTime.Location = new System.Drawing.Point(441, 98);
            this.lblInvTime.Name = "lblInvTime";
            this.lblInvTime.Size = new System.Drawing.Size(89, 20);
            this.lblInvTime.TabIndex = 6;
            this.lblInvTime.Text = "Vechile No:";
            // 
            // lblInvDateVal
            // 
            this.lblInvDateVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvDateVal.AutoSize = true;
            this.lblInvDateVal.Location = new System.Drawing.Point(598, 55);
            this.lblInvDateVal.Name = "lblInvDateVal";
            this.lblInvDateVal.Size = new System.Drawing.Size(14, 20);
            this.lblInvDateVal.TabIndex = 7;
            this.lblInvDateVal.Text = "-";
            // 
            // lblTruckNo
            // 
            this.lblTruckNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTruckNo.AutoSize = true;
            this.lblTruckNo.Location = new System.Drawing.Point(598, 98);
            this.lblTruckNo.Name = "lblTruckNo";
            this.lblTruckNo.Size = new System.Drawing.Size(14, 20);
            this.lblTruckNo.TabIndex = 8;
            this.lblTruckNo.Text = "-";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(4, 4);
            this.picLogo.Name = "picLogo";
            this.tpInvoiceInfo.SetRowSpan(this.picLogo, 3);
            this.picLogo.Size = new System.Drawing.Size(220, 119);
            this.picLogo.TabIndex = 11;
            this.picLogo.TabStop = false;
            // 
            // lblRavannaNo
            // 
            this.lblRavannaNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRavannaNo.AutoSize = true;
            this.lblRavannaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRavannaNo.Location = new System.Drawing.Point(241, 56);
            this.lblRavannaNo.Name = "lblRavannaNo";
            this.lblRavannaNo.Size = new System.Drawing.Size(0, 17);
            this.lblRavannaNo.TabIndex = 12;
            // 
            // printInvoiceDoc
            // 
            this.printInvoiceDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintInvoiceDoc_PrintPage);
            // 
            // printInvoicePreview
            // 
            this.printInvoicePreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printInvoicePreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printInvoicePreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printInvoicePreview.Document = this.printInvoiceDoc;
            this.printInvoicePreview.Enabled = true;
            this.printInvoicePreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printInvoicePreview.Icon")));
            this.printInvoicePreview.Name = "printPreviewInv";
            this.printInvoicePreview.ShowIcon = false;
            this.printInvoicePreview.UseAntiAlias = true;
            this.printInvoicePreview.Visible = false;
            // 
            // btnPrintInv
            // 
            this.btnPrintInv.Location = new System.Drawing.Point(12, 878);
            this.btnPrintInv.Name = "btnPrintInv";
            this.btnPrintInv.Size = new System.Drawing.Size(140, 30);
            this.btnPrintInv.TabIndex = 1;
            this.btnPrintInv.Text = "&Print";
            this.btnPrintInv.UseVisualStyleBackColor = true;
            this.btnPrintInv.Click += new System.EventHandler(this.BtnPrintInv_Click);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 920);
            this.Controls.Add(this.btnPrintInv);
            this.Controls.Add(this.pnlInvoice);
            this.Name = "frmInvoice";
            this.Text = "frmInvoice";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            this.pnlInvoice.ResumeLayout(false);
            this.tplOtherInfo.ResumeLayout(false);
            this.tplOtherInfo.PerformLayout();
            this.tplTaxInfo.ResumeLayout(false);
            this.tplTaxInfo.PerformLayout();
            this.tplMaterialInfo.ResumeLayout(false);
            this.tplMaterialInfo.PerformLayout();
            this.tplBuyerInfo.ResumeLayout(false);
            this.tplBuyerInfo.PerformLayout();
            this.tpInvoiceInfo.ResumeLayout(false);
            this.tpInvoiceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.TableLayoutPanel tpInvoiceInfo;
        private System.Windows.Forms.Label lblInvoiceHeader;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNoValue;
        private System.Windows.Forms.Label lblInvDate;
        private System.Windows.Forms.Label lblInvTime;
        private System.Windows.Forms.Label lblInvDateVal;
        private System.Windows.Forms.Label lblTruckNo;
        private System.Windows.Forms.Label lblSellerGSTNo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Drawing.Printing.PrintDocument printInvoiceDoc;
        private System.Windows.Forms.PrintPreviewDialog printInvoicePreview;
        private System.Windows.Forms.Button btnPrintInv;
        private System.Windows.Forms.TableLayoutPanel tplBuyerInfo;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.Label lblSellerAdd1;
        private System.Windows.Forms.Label lblSellerAdd2;
        private System.Windows.Forms.Label lblSellerAdd3;
        private System.Windows.Forms.Label lblBuyerAdd1;
        private System.Windows.Forms.Label lblBuyerGSTIN;
        private System.Windows.Forms.TableLayoutPanel tplMaterialInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInvUOM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblItemDesc;
        private System.Windows.Forms.Label lblHSN;
        private System.Windows.Forms.Label lblInvQty;
        private System.Windows.Forms.Label lblInvAmt;
        private System.Windows.Forms.Label lblRavannaNo;
        private System.Windows.Forms.TableLayoutPanel tplTaxInfo;
        private System.Windows.Forms.Label lblTotalAmtWord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblAccountDetail;
        private System.Windows.Forms.Label lblCertify;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCGST;
        private System.Windows.Forms.Label lblSGST;
        private System.Windows.Forms.Label lblIGST;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblBeforeTaxAmt;
        private System.Windows.Forms.Label lblCGSTAmt;
        private System.Windows.Forms.Label lblSGSTAmt;
        private System.Windows.Forms.Label lblIGSTAmt;
        private System.Windows.Forms.Label lblTotalAmt;
        private System.Windows.Forms.TableLayoutPanel tplOtherInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSellerSign;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblBuyer;
    }
}
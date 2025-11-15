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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tpInvoiceInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblSellerAdd3 = new System.Windows.Forms.Label();
            this.lblSellerAdd2 = new System.Windows.Forms.Label();
            this.lblSellerAdd1 = new System.Windows.Forms.Label();
            this.lblSellerGSTNo = new System.Windows.Forms.Label();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.lblInvoiceNoValue = new System.Windows.Forms.Label();
            this.lblInvDateVal = new System.Windows.Forms.Label();
            this.lblTruckNo = new System.Windows.Forms.Label();
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
            this.lblBuyerGSTIN = new System.Windows.Forms.Label();
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.lblBuyerAdd1 = new System.Windows.Forms.Label();
            this.lblBuyerAdd2 = new System.Windows.Forms.Label();
            this.lblBuyerAdd3 = new System.Windows.Forms.Label();
            this.lblShiptoName = new System.Windows.Forms.Label();
            this.lblShiptoAdd1 = new System.Windows.Forms.Label();
            this.lblShiptoAdd2 = new System.Windows.Forms.Label();
            this.lblShiptoAdd3 = new System.Windows.Forms.Label();
            this.lblShiptoGSTIN = new System.Windows.Forms.Label();
            this.printInvoiceDoc = new System.Drawing.Printing.PrintDocument();
            this.printInvoicePreview = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrintInv = new System.Windows.Forms.Button();
            this.pnlInvoice.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpInvoiceInfo.SuspendLayout();
            this.tplOtherInfo.SuspendLayout();
            this.tplTaxInfo.SuspendLayout();
            this.tplMaterialInfo.SuspendLayout();
            this.tplBuyerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.Controls.Add(this.panel1);
            this.pnlInvoice.Controls.Add(this.tpInvoiceInfo);
            this.pnlInvoice.Controls.Add(this.tplOtherInfo);
            this.pnlInvoice.Controls.Add(this.tplTaxInfo);
            this.pnlInvoice.Controls.Add(this.tplMaterialInfo);
            this.pnlInvoice.Controls.Add(this.tplBuyerInfo);
            this.pnlInvoice.Location = new System.Drawing.Point(10, 18);
            this.pnlInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(451, 549);
            this.pnlInvoice.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 23);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tax Invoice";
            // 
            // tpInvoiceInfo
            // 
            this.tpInvoiceInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tpInvoiceInfo.ColumnCount = 2;
            this.tpInvoiceInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpInvoiceInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpInvoiceInfo.Controls.Add(this.lblSellerAdd3, 0, 3);
            this.tpInvoiceInfo.Controls.Add(this.lblSellerAdd2, 0, 2);
            this.tpInvoiceInfo.Controls.Add(this.lblSellerAdd1, 0, 1);
            this.tpInvoiceInfo.Controls.Add(this.lblSellerGSTNo, 0, 4);
            this.tpInvoiceInfo.Controls.Add(this.lblSellerName, 0, 0);
            this.tpInvoiceInfo.Controls.Add(this.lblInvoiceNoValue, 1, 0);
            this.tpInvoiceInfo.Controls.Add(this.lblInvDateVal, 1, 2);
            this.tpInvoiceInfo.Controls.Add(this.lblTruckNo, 1, 4);
            this.tpInvoiceInfo.Location = new System.Drawing.Point(1, 31);
            this.tpInvoiceInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tpInvoiceInfo.Name = "tpInvoiceInfo";
            this.tpInvoiceInfo.RowCount = 5;
            this.tpInvoiceInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpInvoiceInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpInvoiceInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpInvoiceInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpInvoiceInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpInvoiceInfo.Size = new System.Drawing.Size(447, 98);
            this.tpInvoiceInfo.TabIndex = 6;
            // 
            // lblSellerAdd3
            // 
            this.lblSellerAdd3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSellerAdd3.AutoSize = true;
            this.lblSellerAdd3.Location = new System.Drawing.Point(3, 60);
            this.lblSellerAdd3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSellerAdd3.Name = "lblSellerAdd3";
            this.lblSellerAdd3.Size = new System.Drawing.Size(32, 13);
            this.lblSellerAdd3.TabIndex = 3;
            this.lblSellerAdd3.Text = "Add3";
            // 
            // lblSellerAdd2
            // 
            this.lblSellerAdd2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSellerAdd2.AutoSize = true;
            this.lblSellerAdd2.Location = new System.Drawing.Point(3, 41);
            this.lblSellerAdd2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSellerAdd2.Name = "lblSellerAdd2";
            this.lblSellerAdd2.Size = new System.Drawing.Size(32, 13);
            this.lblSellerAdd2.TabIndex = 2;
            this.lblSellerAdd2.Text = "Add2";
            // 
            // lblSellerAdd1
            // 
            this.lblSellerAdd1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSellerAdd1.AutoSize = true;
            this.lblSellerAdd1.Location = new System.Drawing.Point(3, 22);
            this.lblSellerAdd1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSellerAdd1.Name = "lblSellerAdd1";
            this.lblSellerAdd1.Size = new System.Drawing.Size(32, 13);
            this.lblSellerAdd1.TabIndex = 1;
            this.lblSellerAdd1.Text = "Add1";
            // 
            // lblSellerGSTNo
            // 
            this.lblSellerGSTNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSellerGSTNo.AutoSize = true;
            this.lblSellerGSTNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerGSTNo.Location = new System.Drawing.Point(3, 78);
            this.lblSellerGSTNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSellerGSTNo.Name = "lblSellerGSTNo";
            this.lblSellerGSTNo.Size = new System.Drawing.Size(41, 17);
            this.lblSellerGSTNo.TabIndex = 9;
            this.lblSellerGSTNo.Text = "GSTIN:";
            this.lblSellerGSTNo.UseCompatibleTextRendering = true;
            // 
            // lblSellerName
            // 
            this.lblSellerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerName.Location = new System.Drawing.Point(3, 3);
            this.lblSellerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(71, 13);
            this.lblSellerName.TabIndex = 0;
            this.lblSellerName.Text = "SellerName";
            // 
            // lblInvoiceNoValue
            // 
            this.lblInvoiceNoValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInvoiceNoValue.AutoSize = true;
            this.lblInvoiceNoValue.Location = new System.Drawing.Point(226, 3);
            this.lblInvoiceNoValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceNoValue.Name = "lblInvoiceNoValue";
            this.lblInvoiceNoValue.Size = new System.Drawing.Size(59, 13);
            this.lblInvoiceNoValue.TabIndex = 10;
            this.lblInvoiceNoValue.Text = "Invoice No";
            // 
            // lblInvDateVal
            // 
            this.lblInvDateVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInvDateVal.AutoSize = true;
            this.lblInvDateVal.Location = new System.Drawing.Point(226, 41);
            this.lblInvDateVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvDateVal.Name = "lblInvDateVal";
            this.lblInvDateVal.Size = new System.Drawing.Size(75, 13);
            this.lblInvDateVal.TabIndex = 11;
            this.lblInvDateVal.Text = "Dispatch Date";
            // 
            // lblTruckNo
            // 
            this.lblTruckNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTruckNo.AutoSize = true;
            this.lblTruckNo.Location = new System.Drawing.Point(226, 80);
            this.lblTruckNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTruckNo.Name = "lblTruckNo";
            this.lblTruckNo.Size = new System.Drawing.Size(59, 13);
            this.lblTruckNo.TabIndex = 12;
            this.lblTruckNo.Text = "Vechile No";
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
            this.tplOtherInfo.Location = new System.Drawing.Point(2, 483);
            this.tplOtherInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tplOtherInfo.Name = "tplOtherInfo";
            this.tplOtherInfo.RowCount = 3;
            this.tplOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tplOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tplOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tplOtherInfo.Size = new System.Drawing.Size(447, 60);
            this.tplOtherInfo.TabIndex = 4;
            // 
            // lblSellerSign
            // 
            this.lblSellerSign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSellerSign.AutoSize = true;
            this.lblSellerSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerSign.Location = new System.Drawing.Point(292, 2);
            this.lblSellerSign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSellerSign.Name = "lblSellerSign";
            this.lblSellerSign.Size = new System.Drawing.Size(85, 17);
            this.lblSellerSign.TabIndex = 1;
            this.lblSellerSign.Text = "Seller Name";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Receiver\'s Signature";
            // 
            // lblInstruction
            // 
            this.lblInstruction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInstruction.AutoSize = true;
            this.tplOtherInfo.SetColumnSpan(this.lblInstruction, 2);
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(171, 42);
            this.lblInstruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(105, 13);
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
            this.tplTaxInfo.Location = new System.Drawing.Point(2, 346);
            this.tplTaxInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tplTaxInfo.Name = "tplTaxInfo";
            this.tplTaxInfo.RowCount = 5;
            this.tplTaxInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tplTaxInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tplTaxInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tplTaxInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tplTaxInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tplTaxInfo.Size = new System.Drawing.Size(447, 135);
            this.tplTaxInfo.TabIndex = 3;
            // 
            // lblTotalAmtWord
            // 
            this.lblTotalAmtWord.AutoSize = true;
            this.lblTotalAmtWord.Location = new System.Drawing.Point(3, 1);
            this.lblTotalAmtWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmtWord.Name = "lblTotalAmtWord";
            this.lblTotalAmtWord.Size = new System.Drawing.Size(70, 13);
            this.lblTotalAmtWord.TabIndex = 0;
            this.lblTotalAmtWord.Text = "Amount in Rs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Company Bank Details";
            // 
            // lblBankName
            // 
            this.lblBankName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.Location = new System.Drawing.Point(3, 72);
            this.lblBankName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(70, 13);
            this.lblBankName.TabIndex = 2;
            this.lblBankName.Text = "Bank Name";
            // 
            // lblAccountDetail
            // 
            this.lblAccountDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAccountDetail.AutoSize = true;
            this.lblAccountDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountDetail.Location = new System.Drawing.Point(3, 98);
            this.lblAccountDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountDetail.Name = "lblAccountDetail";
            this.lblAccountDetail.Size = new System.Drawing.Size(138, 13);
            this.lblAccountDetail.TabIndex = 3;
            this.lblAccountDetail.Text = "Account No IFSC Code";
            // 
            // lblCertify
            // 
            this.lblCertify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCertify.AutoSize = true;
            this.lblCertify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertify.Location = new System.Drawing.Point(3, 119);
            this.lblCertify.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCertify.Name = "lblCertify";
            this.lblCertify.Size = new System.Drawing.Size(36, 13);
            this.lblCertify.TabIndex = 4;
            this.lblCertify.Text = "Certify";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Total";
            // 
            // lblCGST
            // 
            this.lblCGST.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCGST.AutoSize = true;
            this.lblCGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCGST.Location = new System.Drawing.Point(302, 46);
            this.lblCGST.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCGST.Name = "lblCGST";
            this.lblCGST.Size = new System.Drawing.Size(34, 13);
            this.lblCGST.TabIndex = 6;
            this.lblCGST.Text = "CGST";
            // 
            // lblSGST
            // 
            this.lblSGST.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSGST.AutoSize = true;
            this.lblSGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSGST.Location = new System.Drawing.Point(302, 72);
            this.lblSGST.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSGST.Name = "lblSGST";
            this.lblSGST.Size = new System.Drawing.Size(34, 13);
            this.lblSGST.TabIndex = 7;
            this.lblSGST.Text = "SGST";
            // 
            // lblIGST
            // 
            this.lblIGST.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIGST.AutoSize = true;
            this.lblIGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGST.Location = new System.Drawing.Point(302, 98);
            this.lblIGST.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIGST.Name = "lblIGST";
            this.lblIGST.Size = new System.Drawing.Size(30, 13);
            this.lblIGST.TabIndex = 8;
            this.lblIGST.Text = "IGST";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(302, 119);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(49, 13);
            this.lblGrandTotal.TabIndex = 9;
            this.lblGrandTotal.Text = "G.Total";
            // 
            // lblBeforeTaxAmt
            // 
            this.lblBeforeTaxAmt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBeforeTaxAmt.AutoSize = true;
            this.lblBeforeTaxAmt.Location = new System.Drawing.Point(434, 13);
            this.lblBeforeTaxAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBeforeTaxAmt.Name = "lblBeforeTaxAmt";
            this.lblBeforeTaxAmt.Size = new System.Drawing.Size(10, 13);
            this.lblBeforeTaxAmt.TabIndex = 10;
            this.lblBeforeTaxAmt.Text = "-";
            // 
            // lblCGSTAmt
            // 
            this.lblCGSTAmt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCGSTAmt.AutoSize = true;
            this.lblCGSTAmt.Location = new System.Drawing.Point(434, 46);
            this.lblCGSTAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCGSTAmt.Name = "lblCGSTAmt";
            this.lblCGSTAmt.Size = new System.Drawing.Size(10, 13);
            this.lblCGSTAmt.TabIndex = 11;
            this.lblCGSTAmt.Text = "-";
            // 
            // lblSGSTAmt
            // 
            this.lblSGSTAmt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSGSTAmt.AutoSize = true;
            this.lblSGSTAmt.Location = new System.Drawing.Point(434, 72);
            this.lblSGSTAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSGSTAmt.Name = "lblSGSTAmt";
            this.lblSGSTAmt.Size = new System.Drawing.Size(10, 13);
            this.lblSGSTAmt.TabIndex = 12;
            this.lblSGSTAmt.Text = "-";
            // 
            // lblIGSTAmt
            // 
            this.lblIGSTAmt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIGSTAmt.AutoSize = true;
            this.lblIGSTAmt.Location = new System.Drawing.Point(434, 98);
            this.lblIGSTAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIGSTAmt.Name = "lblIGSTAmt";
            this.lblIGSTAmt.Size = new System.Drawing.Size(10, 13);
            this.lblIGSTAmt.TabIndex = 13;
            this.lblIGSTAmt.Text = "-";
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalAmt.AutoSize = true;
            this.lblTotalAmt.Location = new System.Drawing.Point(434, 119);
            this.lblTotalAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(10, 13);
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
            this.tplMaterialInfo.Location = new System.Drawing.Point(2, 263);
            this.tplMaterialInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tplMaterialInfo.Name = "tplMaterialInfo";
            this.tplMaterialInfo.RowCount = 2;
            this.tplMaterialInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.47418F));
            this.tplMaterialInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.52582F));
            this.tplMaterialInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tplMaterialInfo.Size = new System.Drawing.Size(447, 80);
            this.tplMaterialInfo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item Description";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "HSN";
            // 
            // lblInvUOM
            // 
            this.lblInvUOM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvUOM.AutoSize = true;
            this.lblInvUOM.Location = new System.Drawing.Point(310, 3);
            this.lblInvUOM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvUOM.Name = "lblInvUOM";
            this.lblInvUOM.Size = new System.Drawing.Size(48, 13);
            this.lblInvUOM.TabIndex = 2;
            this.lblInvUOM.Text = "Qty (MT)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Before Tax Amount (INR)";
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.AutoSize = true;
            this.lblItemDesc.Location = new System.Drawing.Point(3, 20);
            this.lblItemDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(27, 13);
            this.lblItemDesc.TabIndex = 5;
            this.lblItemDesc.Text = "Item";
            // 
            // lblHSN
            // 
            this.lblHSN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHSN.AutoSize = true;
            this.lblHSN.Location = new System.Drawing.Point(256, 20);
            this.lblHSN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHSN.Name = "lblHSN";
            this.lblHSN.Size = new System.Drawing.Size(30, 13);
            this.lblHSN.TabIndex = 6;
            this.lblHSN.Text = "HSN";
            // 
            // lblInvQty
            // 
            this.lblInvQty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInvQty.AutoSize = true;
            this.lblInvQty.Location = new System.Drawing.Point(320, 20);
            this.lblInvQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvQty.Name = "lblInvQty";
            this.lblInvQty.Size = new System.Drawing.Size(29, 13);
            this.lblInvQty.TabIndex = 7;
            this.lblInvQty.Text = "QTY";
            // 
            // lblInvAmt
            // 
            this.lblInvAmt.AutoSize = true;
            this.lblInvAmt.Location = new System.Drawing.Point(371, 20);
            this.lblInvAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvAmt.Name = "lblInvAmt";
            this.lblInvAmt.Size = new System.Drawing.Size(43, 13);
            this.lblInvAmt.TabIndex = 9;
            this.lblInvAmt.Text = "Amount";
            // 
            // tplBuyerInfo
            // 
            this.tplBuyerInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tplBuyerInfo.ColumnCount = 2;
            this.tplBuyerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplBuyerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplBuyerInfo.Controls.Add(this.lblBuyerGSTIN, 0, 4);
            this.tplBuyerInfo.Controls.Add(this.lblBuyerName, 0, 0);
            this.tplBuyerInfo.Controls.Add(this.lblBuyerAdd1, 0, 1);
            this.tplBuyerInfo.Controls.Add(this.lblBuyerAdd2, 0, 2);
            this.tplBuyerInfo.Controls.Add(this.lblBuyerAdd3, 0, 3);
            this.tplBuyerInfo.Controls.Add(this.lblShiptoName, 1, 0);
            this.tplBuyerInfo.Controls.Add(this.lblShiptoAdd1, 1, 1);
            this.tplBuyerInfo.Controls.Add(this.lblShiptoAdd2, 1, 2);
            this.tplBuyerInfo.Controls.Add(this.lblShiptoAdd3, 1, 3);
            this.tplBuyerInfo.Controls.Add(this.lblShiptoGSTIN, 1, 4);
            this.tplBuyerInfo.Location = new System.Drawing.Point(2, 133);
            this.tplBuyerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tplBuyerInfo.Name = "tplBuyerInfo";
            this.tplBuyerInfo.RowCount = 5;
            this.tplBuyerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.04167F));
            this.tplBuyerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tplBuyerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tplBuyerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.625F));
            this.tplBuyerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tplBuyerInfo.Size = new System.Drawing.Size(447, 126);
            this.tplBuyerInfo.TabIndex = 1;
            // 
            // lblBuyerGSTIN
            // 
            this.lblBuyerGSTIN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuyerGSTIN.AutoSize = true;
            this.lblBuyerGSTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerGSTIN.Location = new System.Drawing.Point(3, 103);
            this.lblBuyerGSTIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuyerGSTIN.Name = "lblBuyerGSTIN";
            this.lblBuyerGSTIN.Size = new System.Drawing.Size(41, 17);
            this.lblBuyerGSTIN.TabIndex = 10;
            this.lblBuyerGSTIN.Text = "GSTIN:";
            this.lblBuyerGSTIN.UseCompatibleTextRendering = true;
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuyerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerName.Location = new System.Drawing.Point(3, 4);
            this.lblBuyerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(218, 25);
            this.lblBuyerName.TabIndex = 1;
            this.lblBuyerName.Text = "BuyerName";
            // 
            // lblBuyerAdd1
            // 
            this.lblBuyerAdd1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuyerAdd1.Location = new System.Drawing.Point(3, 37);
            this.lblBuyerAdd1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuyerAdd1.Name = "lblBuyerAdd1";
            this.lblBuyerAdd1.Size = new System.Drawing.Size(218, 13);
            this.lblBuyerAdd1.TabIndex = 2;
            this.lblBuyerAdd1.Text = "Add1";
            // 
            // lblBuyerAdd2
            // 
            this.lblBuyerAdd2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuyerAdd2.Location = new System.Drawing.Point(3, 60);
            this.lblBuyerAdd2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuyerAdd2.Name = "lblBuyerAdd2";
            this.lblBuyerAdd2.Size = new System.Drawing.Size(218, 13);
            this.lblBuyerAdd2.TabIndex = 3;
            this.lblBuyerAdd2.Text = "Add2";
            // 
            // lblBuyerAdd3
            // 
            this.lblBuyerAdd3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuyerAdd3.Location = new System.Drawing.Point(3, 81);
            this.lblBuyerAdd3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuyerAdd3.Name = "lblBuyerAdd3";
            this.lblBuyerAdd3.Size = new System.Drawing.Size(218, 13);
            this.lblBuyerAdd3.TabIndex = 4;
            this.lblBuyerAdd3.Text = "Add3";
            // 
            // lblShiptoName
            // 
            this.lblShiptoName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShiptoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiptoName.Location = new System.Drawing.Point(226, 4);
            this.lblShiptoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShiptoName.Name = "lblShiptoName";
            this.lblShiptoName.Size = new System.Drawing.Size(218, 25);
            this.lblShiptoName.TabIndex = 11;
            this.lblShiptoName.Text = "BuyerName";
            // 
            // lblShiptoAdd1
            // 
            this.lblShiptoAdd1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShiptoAdd1.Location = new System.Drawing.Point(226, 37);
            this.lblShiptoAdd1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShiptoAdd1.Name = "lblShiptoAdd1";
            this.lblShiptoAdd1.Size = new System.Drawing.Size(218, 13);
            this.lblShiptoAdd1.TabIndex = 12;
            this.lblShiptoAdd1.Text = "Add1";
            // 
            // lblShiptoAdd2
            // 
            this.lblShiptoAdd2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShiptoAdd2.Location = new System.Drawing.Point(226, 60);
            this.lblShiptoAdd2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShiptoAdd2.Name = "lblShiptoAdd2";
            this.lblShiptoAdd2.Size = new System.Drawing.Size(218, 13);
            this.lblShiptoAdd2.TabIndex = 13;
            this.lblShiptoAdd2.Text = "Add2";
            // 
            // lblShiptoAdd3
            // 
            this.lblShiptoAdd3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShiptoAdd3.Location = new System.Drawing.Point(226, 81);
            this.lblShiptoAdd3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShiptoAdd3.Name = "lblShiptoAdd3";
            this.lblShiptoAdd3.Size = new System.Drawing.Size(218, 13);
            this.lblShiptoAdd3.TabIndex = 14;
            this.lblShiptoAdd3.Text = "Add3";
            // 
            // lblShiptoGSTIN
            // 
            this.lblShiptoGSTIN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShiptoGSTIN.AutoSize = true;
            this.lblShiptoGSTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiptoGSTIN.Location = new System.Drawing.Point(226, 103);
            this.lblShiptoGSTIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShiptoGSTIN.Name = "lblShiptoGSTIN";
            this.lblShiptoGSTIN.Size = new System.Drawing.Size(41, 17);
            this.lblShiptoGSTIN.TabIndex = 15;
            this.lblShiptoGSTIN.Text = "GSTIN:";
            this.lblShiptoGSTIN.UseCompatibleTextRendering = true;
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
            this.btnPrintInv.Location = new System.Drawing.Point(8, 571);
            this.btnPrintInv.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintInv.Name = "btnPrintInv";
            this.btnPrintInv.Size = new System.Drawing.Size(93, 19);
            this.btnPrintInv.TabIndex = 1;
            this.btnPrintInv.Text = "&Print";
            this.btnPrintInv.UseVisualStyleBackColor = true;
            this.btnPrintInv.Click += new System.EventHandler(this.BtnPrintInv_Click);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 487);
            this.Controls.Add(this.btnPrintInv);
            this.Controls.Add(this.pnlInvoice);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInvoice";
            this.Text = "frmInvoice";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            this.pnlInvoice.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpInvoiceInfo.ResumeLayout(false);
            this.tpInvoiceInfo.PerformLayout();
            this.tplOtherInfo.ResumeLayout(false);
            this.tplOtherInfo.PerformLayout();
            this.tplTaxInfo.ResumeLayout(false);
            this.tplTaxInfo.PerformLayout();
            this.tplMaterialInfo.ResumeLayout(false);
            this.tplMaterialInfo.PerformLayout();
            this.tplBuyerInfo.ResumeLayout(false);
            this.tplBuyerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.Label lblSellerGSTNo;
        private System.Drawing.Printing.PrintDocument printInvoiceDoc;
        private System.Windows.Forms.PrintPreviewDialog printInvoicePreview;
        private System.Windows.Forms.Button btnPrintInv;
        private System.Windows.Forms.TableLayoutPanel tplBuyerInfo;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.Label lblSellerAdd1;
        private System.Windows.Forms.Label lblSellerAdd2;
        private System.Windows.Forms.Label lblSellerAdd3;
        private System.Windows.Forms.TableLayoutPanel tplMaterialInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInvUOM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblItemDesc;
        private System.Windows.Forms.Label lblHSN;
        private System.Windows.Forms.Label lblInvQty;
        private System.Windows.Forms.Label lblInvAmt;
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
        private System.Windows.Forms.TableLayoutPanel tpInvoiceInfo;
        private System.Windows.Forms.Label lblBuyerGSTIN;
        private System.Windows.Forms.Label lblBuyerName;
        private System.Windows.Forms.Label lblBuyerAdd1;
        private System.Windows.Forms.Label lblBuyerAdd2;
        private System.Windows.Forms.Label lblBuyerAdd3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInvoiceNoValue;
        private System.Windows.Forms.Label lblInvDateVal;
        private System.Windows.Forms.Label lblTruckNo;
        private System.Windows.Forms.Label lblShiptoName;
        private System.Windows.Forms.Label lblShiptoAdd1;
        private System.Windows.Forms.Label lblShiptoAdd2;
        private System.Windows.Forms.Label lblShiptoAdd3;
        private System.Windows.Forms.Label lblShiptoGSTIN;
    }
}
namespace EagleEye.Operations
{
    partial class frmSupplierBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierBill));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbEdit = new System.Windows.Forms.TabPage();
            this.txtItemRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.chkPaidtoVendor = new System.Windows.Forms.CheckBox();
            this.lblOutstanding = new System.Windows.Forms.Label();
            this.dtBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtCGST = new System.Windows.Forms.TextBox();
            this.lblGstinNo = new System.Windows.Forms.Label();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.txtIGST = new System.Windows.Forms.TextBox();
            this.txtSGST = new System.Windows.Forms.TextBox();
            this.lblAdd2 = new System.Windows.Forms.Label();
            this.rtxtRemarks = new System.Windows.Forms.RichTextBox();
            this.lblIGST = new System.Windows.Forms.Label();
            this.cmbHead = new System.Windows.Forms.ComboBox();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillDetails = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtBillAmt = new System.Windows.Forms.TextBox();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.tbView = new System.Windows.Forms.TabPage();
            this.grdBillDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grdOutstandingDetails = new System.Windows.Forms.DataGridView();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbEdit.SuspendLayout();
            this.tbView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBillDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOutstandingDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.lblFormHeader);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.pnlMain.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnlMain.Location = new System.Drawing.Point(41, 19);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(625, 428);
            this.pnlMain.TabIndex = 43;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbEdit);
            this.tabMain.Controls.Add(this.tbView);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(29, 57);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(563, 310);
            this.tabMain.TabIndex = 90;
            // 
            // tbEdit
            // 
            this.tbEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.tbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEdit.Controls.Add(this.txtItemRate);
            this.tbEdit.Controls.Add(this.label4);
            this.tbEdit.Controls.Add(this.txtItemQty);
            this.tbEdit.Controls.Add(this.label2);
            this.tbEdit.Controls.Add(this.label5);
            this.tbEdit.Controls.Add(this.cmbItem);
            this.tbEdit.Controls.Add(this.chkPaidtoVendor);
            this.tbEdit.Controls.Add(this.lblOutstanding);
            this.tbEdit.Controls.Add(this.dtBillDate);
            this.tbEdit.Controls.Add(this.txtCGST);
            this.tbEdit.Controls.Add(this.lblGstinNo);
            this.tbEdit.Controls.Add(this.lblEmailId);
            this.tbEdit.Controls.Add(this.txtIGST);
            this.tbEdit.Controls.Add(this.txtSGST);
            this.tbEdit.Controls.Add(this.lblAdd2);
            this.tbEdit.Controls.Add(this.rtxtRemarks);
            this.tbEdit.Controls.Add(this.lblIGST);
            this.tbEdit.Controls.Add(this.cmbHead);
            this.tbEdit.Controls.Add(this.lblContactPerson);
            this.tbEdit.Controls.Add(this.lblVendor);
            this.tbEdit.Controls.Add(this.cmbVendor);
            this.tbEdit.Controls.Add(this.label3);
            this.tbEdit.Controls.Add(this.txtBillDetails);
            this.tbEdit.Controls.Add(this.lblCity);
            this.tbEdit.Controls.Add(this.txtBillAmt);
            this.tbEdit.Controls.Add(this.lblAdd1);
            this.tbEdit.Controls.Add(this.txtBillNo);
            this.tbEdit.Controls.Add(this.lblVendorName);
            this.tbEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEdit.Location = new System.Drawing.Point(4, 22);
            this.tbEdit.Margin = new System.Windows.Forms.Padding(2);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Padding = new System.Windows.Forms.Padding(2);
            this.tbEdit.Size = new System.Drawing.Size(555, 284);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.Text = "Manage Vendor";
            // 
            // txtItemRate
            // 
            this.txtItemRate.Location = new System.Drawing.Point(371, 119);
            this.txtItemRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemRate.Name = "txtItemRate";
            this.txtItemRate.Size = new System.Drawing.Size(167, 20);
            this.txtItemRate.TabIndex = 7;
            this.txtItemRate.Text = "0";
            this.txtItemRate.TextChanged += new System.EventHandler(this.TxtItemRate_TextChanged);
            this.txtItemRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItemRate_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(304, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 138;
            this.label4.Text = "Rate";
            // 
            // txtItemQty
            // 
            this.txtItemQty.Location = new System.Drawing.Point(97, 119);
            this.txtItemQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemQty.Name = "txtItemQty";
            this.txtItemQty.Size = new System.Drawing.Size(167, 20);
            this.txtItemQty.TabIndex = 6;
            this.txtItemQty.Text = "0";
            this.txtItemQty.TextChanged += new System.EventHandler(this.TxtItemQty_TextChanged);
            this.txtItemQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItemQty_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(6, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 136;
            this.label2.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(304, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 134;
            this.label5.Text = "Item";
            // 
            // cmbItem
            // 
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(371, 82);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(169, 21);
            this.cmbItem.TabIndex = 5;
            // 
            // chkPaidtoVendor
            // 
            this.chkPaidtoVendor.AutoSize = true;
            this.chkPaidtoVendor.Checked = true;
            this.chkPaidtoVendor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPaidtoVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaidtoVendor.Location = new System.Drawing.Point(7, 227);
            this.chkPaidtoVendor.Margin = new System.Windows.Forms.Padding(2);
            this.chkPaidtoVendor.Name = "chkPaidtoVendor";
            this.chkPaidtoVendor.Size = new System.Drawing.Size(110, 17);
            this.chkPaidtoVendor.TabIndex = 12;
            this.chkPaidtoVendor.Text = "Bill Paid in Full";
            this.chkPaidtoVendor.UseVisualStyleBackColor = true;
            // 
            // lblOutstanding
            // 
            this.lblOutstanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutstanding.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblOutstanding.Location = new System.Drawing.Point(9, 254);
            this.lblOutstanding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutstanding.Name = "lblOutstanding";
            this.lblOutstanding.Size = new System.Drawing.Size(259, 17);
            this.lblOutstanding.TabIndex = 119;
            this.lblOutstanding.Text = "OS Balance";
            // 
            // dtBillDate
            // 
            this.dtBillDate.Location = new System.Drawing.Point(371, 46);
            this.dtBillDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtBillDate.Name = "dtBillDate";
            this.dtBillDate.Size = new System.Drawing.Size(169, 20);
            this.dtBillDate.TabIndex = 3;
            // 
            // txtCGST
            // 
            this.txtCGST.Location = new System.Drawing.Point(371, 155);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.Size = new System.Drawing.Size(169, 20);
            this.txtCGST.TabIndex = 9;
            this.txtCGST.Text = "0";
            this.txtCGST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCGST_KeyPress);
            // 
            // lblGstinNo
            // 
            this.lblGstinNo.AutoSize = true;
            this.lblGstinNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGstinNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblGstinNo.Location = new System.Drawing.Point(304, 155);
            this.lblGstinNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGstinNo.Name = "lblGstinNo";
            this.lblGstinNo.Size = new System.Drawing.Size(40, 13);
            this.lblGstinNo.TabIndex = 118;
            this.lblGstinNo.Text = "CGST";
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmailId.Location = new System.Drawing.Point(304, 46);
            this.lblEmailId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(55, 13);
            this.lblEmailId.TabIndex = 116;
            this.lblEmailId.Text = "Bill Date";
            // 
            // txtIGST
            // 
            this.txtIGST.Location = new System.Drawing.Point(371, 190);
            this.txtIGST.Name = "txtIGST";
            this.txtIGST.Size = new System.Drawing.Size(169, 20);
            this.txtIGST.TabIndex = 11;
            this.txtIGST.Text = "0";
            this.txtIGST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIGST_KeyPress);
            // 
            // txtSGST
            // 
            this.txtSGST.Location = new System.Drawing.Point(97, 190);
            this.txtSGST.Margin = new System.Windows.Forms.Padding(2);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.Size = new System.Drawing.Size(167, 20);
            this.txtSGST.TabIndex = 10;
            this.txtSGST.Text = "0";
            this.txtSGST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSGST_KeyPress);
            // 
            // lblAdd2
            // 
            this.lblAdd2.AutoSize = true;
            this.lblAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAdd2.Location = new System.Drawing.Point(6, 190);
            this.lblAdd2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdd2.Name = "lblAdd2";
            this.lblAdd2.Size = new System.Drawing.Size(40, 13);
            this.lblAdd2.TabIndex = 113;
            this.lblAdd2.Text = "SGST";
            // 
            // rtxtRemarks
            // 
            this.rtxtRemarks.Location = new System.Drawing.Point(371, 226);
            this.rtxtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtRemarks.Name = "rtxtRemarks";
            this.rtxtRemarks.Size = new System.Drawing.Size(169, 45);
            this.rtxtRemarks.TabIndex = 13;
            this.rtxtRemarks.Text = "";
            // 
            // lblIGST
            // 
            this.lblIGST.AutoSize = true;
            this.lblIGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGST.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblIGST.Location = new System.Drawing.Point(304, 190);
            this.lblIGST.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIGST.Name = "lblIGST";
            this.lblIGST.Size = new System.Drawing.Size(36, 13);
            this.lblIGST.TabIndex = 111;
            this.lblIGST.Text = "IGST";
            // 
            // cmbHead
            // 
            this.cmbHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHead.FormattingEnabled = true;
            this.cmbHead.Location = new System.Drawing.Point(371, 9);
            this.cmbHead.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHead.Name = "cmbHead";
            this.cmbHead.Size = new System.Drawing.Size(169, 21);
            this.cmbHead.TabIndex = 1;
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactPerson.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblContactPerson.Location = new System.Drawing.Point(304, 9);
            this.lblContactPerson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(37, 13);
            this.lblContactPerson.TabIndex = 109;
            this.lblContactPerson.Text = "Head";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblVendor.Location = new System.Drawing.Point(6, 9);
            this.lblVendor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(87, 13);
            this.lblVendor.TabIndex = 107;
            this.lblVendor.Text = "Select Vendor";
            // 
            // cmbVendor
            // 
            this.cmbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(97, 9);
            this.cmbVendor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(169, 21);
            this.cmbVendor.TabIndex = 0;
            this.cmbVendor.SelectedIndexChanged += new System.EventHandler(this.CmbVendor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(304, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Remarks";
            // 
            // txtBillDetails
            // 
            this.txtBillDetails.Location = new System.Drawing.Point(97, 82);
            this.txtBillDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillDetails.Name = "txtBillDetails";
            this.txtBillDetails.Size = new System.Drawing.Size(167, 20);
            this.txtBillDetails.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCity.Location = new System.Drawing.Point(6, 85);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(67, 13);
            this.lblCity.TabIndex = 101;
            this.lblCity.Text = "Bill Details";
            // 
            // txtBillAmt
            // 
            this.txtBillAmt.Location = new System.Drawing.Point(97, 155);
            this.txtBillAmt.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillAmt.Name = "txtBillAmt";
            this.txtBillAmt.Size = new System.Drawing.Size(167, 20);
            this.txtBillAmt.TabIndex = 8;
            this.txtBillAmt.Text = "0";
            this.txtBillAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBillAmt_KeyPress);
            // 
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAdd1.Location = new System.Drawing.Point(6, 155);
            this.lblAdd1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(82, 13);
            this.lblAdd1.TabIndex = 99;
            this.lblAdd1.Text = "Total Amount";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(97, 46);
            this.txtBillNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(167, 20);
            this.txtBillNo.TabIndex = 2;
            this.txtBillNo.Text = "-";
            this.txtBillNo.Leave += new System.EventHandler(this.txtBillNo_Leave);
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblVendorName.Location = new System.Drawing.Point(6, 46);
            this.lblVendorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(44, 13);
            this.lblVendorName.TabIndex = 98;
            this.lblVendorName.Text = "Bill No";
            // 
            // tbView
            // 
            this.tbView.BackColor = System.Drawing.Color.SandyBrown;
            this.tbView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbView.Controls.Add(this.grdBillDetails);
            this.tbView.Controls.Add(this.label1);
            this.tbView.Controls.Add(this.label7);
            this.tbView.Controls.Add(this.grdOutstandingDetails);
            this.tbView.Location = new System.Drawing.Point(4, 22);
            this.tbView.Margin = new System.Windows.Forms.Padding(2);
            this.tbView.Name = "tbView";
            this.tbView.Padding = new System.Windows.Forms.Padding(2);
            this.tbView.Size = new System.Drawing.Size(555, 284);
            this.tbView.TabIndex = 1;
            this.tbView.Text = "Old Bills";
            // 
            // grdBillDetails
            // 
            this.grdBillDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBillDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBillDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBillDetails.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdBillDetails.Location = new System.Drawing.Point(5, 96);
            this.grdBillDetails.Name = "grdBillDetails";
            this.grdBillDetails.RowHeadersVisible = false;
            this.grdBillDetails.Size = new System.Drawing.Size(535, 147);
            this.grdBillDetails.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(5, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 127;
            this.label1.Text = "Old Bills";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 126;
            this.label7.Text = "Ledger Balance";
            // 
            // grdOutstandingDetails
            // 
            this.grdOutstandingDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOutstandingDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOutstandingDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdOutstandingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOutstandingDetails.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdOutstandingDetails.Location = new System.Drawing.Point(5, 21);
            this.grdOutstandingDetails.Name = "grdOutstandingDetails";
            this.grdOutstandingDetails.RowHeadersVisible = false;
            this.grdOutstandingDetails.Size = new System.Drawing.Size(535, 46);
            this.grdOutstandingDetails.TabIndex = 125;
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
            this.btnSave.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(206, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "   &Proceed";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Image = global::EagleEye.Properties.Resources.img_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(490, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "   &Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmSupplierBill
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(707, 463);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSupplierBill";
            this.Text = "Supplier Bill Entry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSupplierBill_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbEdit.ResumeLayout(false);
            this.tbEdit.PerformLayout();
            this.tbView.ResumeLayout(false);
            this.tbView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBillDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOutstandingDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbEdit;
        private System.Windows.Forms.TextBox txtCGST;
        private System.Windows.Forms.Label lblGstinNo;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.TextBox txtIGST;
        private System.Windows.Forms.TextBox txtSGST;
        private System.Windows.Forms.Label lblAdd2;
        private System.Windows.Forms.RichTextBox rtxtRemarks;
        private System.Windows.Forms.Label lblIGST;
        private System.Windows.Forms.ComboBox cmbHead;
        private System.Windows.Forms.Label lblContactPerson;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.ComboBox cmbVendor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillDetails;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtBillAmt;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.TabPage tbView;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtBillDate;
        private System.Windows.Forms.Label lblOutstanding;
        private System.Windows.Forms.DataGridView grdBillDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdOutstandingDetails;
        private System.Windows.Forms.CheckBox chkPaidtoVendor;
        private System.Windows.Forms.TextBox txtItemRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbItem;
    }
}
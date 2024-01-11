namespace EagleEye.Administration
{
    partial class frmManageBuyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageBuyer));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbEdit = new System.Windows.Forms.TabPage();
            this.txtGstin = new System.Windows.Forms.TextBox();
            this.lblGstinNo = new System.Windows.Forms.Label();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.lblAdd2 = new System.Windows.Forms.Label();
            this.rtxtRemarks = new System.Windows.Forms.RichTextBox();
            this.Active = new System.Windows.Forms.Label();
            this.cmbActive = new System.Windows.Forms.ComboBox();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.cmbBuyer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.tbView = new System.Windows.Forms.TabPage();
            this.grdBuyerDetails = new System.Windows.Forms.DataGridView();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbEdit.SuspendLayout();
            this.tbView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuyerDetails)).BeginInit();
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
            this.pnlMain.Location = new System.Drawing.Point(87, 30);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(625, 377);
            this.pnlMain.TabIndex = 42;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbEdit);
            this.tabMain.Controls.Add(this.tbView);
            this.tabMain.Location = new System.Drawing.Point(29, 57);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(563, 277);
            this.tabMain.TabIndex = 90;
            // 
            // tbEdit
            // 
            this.tbEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.tbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEdit.Controls.Add(this.txtGstin);
            this.tbEdit.Controls.Add(this.lblGstinNo);
            this.tbEdit.Controls.Add(this.txtEmailId);
            this.tbEdit.Controls.Add(this.lblEmailId);
            this.tbEdit.Controls.Add(this.txtState);
            this.tbEdit.Controls.Add(this.txtContactPerson);
            this.tbEdit.Controls.Add(this.txtAdd2);
            this.tbEdit.Controls.Add(this.lblAdd2);
            this.tbEdit.Controls.Add(this.rtxtRemarks);
            this.tbEdit.Controls.Add(this.Active);
            this.tbEdit.Controls.Add(this.cmbActive);
            this.tbEdit.Controls.Add(this.lblContactPerson);
            this.tbEdit.Controls.Add(this.lblBuyer);
            this.tbEdit.Controls.Add(this.cmbBuyer);
            this.tbEdit.Controls.Add(this.label3);
            this.tbEdit.Controls.Add(this.lblState);
            this.tbEdit.Controls.Add(this.txtCity);
            this.tbEdit.Controls.Add(this.lblCity);
            this.tbEdit.Controls.Add(this.txtAdd1);
            this.tbEdit.Controls.Add(this.lblAdd1);
            this.tbEdit.Controls.Add(this.txtBuyerName);
            this.tbEdit.Controls.Add(this.lblBuyerName);
            this.tbEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEdit.Location = new System.Drawing.Point(4, 22);
            this.tbEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEdit.Size = new System.Drawing.Size(555, 251);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.Text = "Manage Buyer";
            // 
            // txtGstin
            // 
            this.txtGstin.Location = new System.Drawing.Point(373, 106);
            this.txtGstin.Name = "txtGstin";
            this.txtGstin.Size = new System.Drawing.Size(167, 20);
            this.txtGstin.TabIndex = 119;
            // 
            // lblGstinNo
            // 
            this.lblGstinNo.AutoSize = true;
            this.lblGstinNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGstinNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblGstinNo.Location = new System.Drawing.Point(278, 105);
            this.lblGstinNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGstinNo.Name = "lblGstinNo";
            this.lblGstinNo.Size = new System.Drawing.Size(65, 13);
            this.lblGstinNo.TabIndex = 118;
            this.lblGstinNo.Text = "GSTIN No";
            // 
            // txtEmailId
            // 
            this.txtEmailId.Location = new System.Drawing.Point(373, 59);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(167, 20);
            this.txtEmailId.TabIndex = 117;
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmailId.Location = new System.Drawing.Point(278, 60);
            this.lblEmailId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(54, 13);
            this.lblEmailId.TabIndex = 116;
            this.lblEmailId.Text = "Email ID";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(89, 220);
            this.txtState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(167, 20);
            this.txtState.TabIndex = 115;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(373, 12);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(167, 20);
            this.txtContactPerson.TabIndex = 114;
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(89, 136);
            this.txtAdd2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(167, 20);
            this.txtAdd2.TabIndex = 3;
            // 
            // lblAdd2
            // 
            this.lblAdd2.AutoSize = true;
            this.lblAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAdd2.Location = new System.Drawing.Point(6, 135);
            this.lblAdd2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdd2.Name = "lblAdd2";
            this.lblAdd2.Size = new System.Drawing.Size(36, 13);
            this.lblAdd2.TabIndex = 113;
            this.lblAdd2.Text = "Add2";
            // 
            // rtxtRemarks
            // 
            this.rtxtRemarks.Location = new System.Drawing.Point(373, 195);
            this.rtxtRemarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtRemarks.Name = "rtxtRemarks";
            this.rtxtRemarks.Size = new System.Drawing.Size(169, 45);
            this.rtxtRemarks.TabIndex = 8;
            this.rtxtRemarks.Text = "";
            // 
            // Active
            // 
            this.Active.AutoSize = true;
            this.Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Active.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Active.Location = new System.Drawing.Point(278, 150);
            this.Active.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(43, 13);
            this.Active.TabIndex = 111;
            this.Active.Text = "Active";
            // 
            // cmbActive
            // 
            this.cmbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActive.FormattingEnabled = true;
            this.cmbActive.Location = new System.Drawing.Point(373, 153);
            this.cmbActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.Size = new System.Drawing.Size(169, 21);
            this.cmbActive.TabIndex = 7;
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactPerson.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblContactPerson.Location = new System.Drawing.Point(278, 15);
            this.lblContactPerson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(94, 13);
            this.lblContactPerson.TabIndex = 109;
            this.lblContactPerson.Text = "Contact Person";
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBuyer.Location = new System.Drawing.Point(6, 12);
            this.lblBuyer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(79, 13);
            this.lblBuyer.TabIndex = 107;
            this.lblBuyer.Text = "Select Buyer";
            // 
            // cmbBuyer
            // 
            this.cmbBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuyer.FormattingEnabled = true;
            this.cmbBuyer.Location = new System.Drawing.Point(89, 9);
            this.cmbBuyer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBuyer.Name = "cmbBuyer";
            this.cmbBuyer.Size = new System.Drawing.Size(169, 21);
            this.cmbBuyer.TabIndex = 0;
            this.cmbBuyer.SelectedIndexChanged += new System.EventHandler(this.cmbBuyer_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(278, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Remarks";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblState.Location = new System.Drawing.Point(6, 217);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(37, 13);
            this.lblState.TabIndex = 103;
            this.lblState.Text = "State";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(89, 178);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(167, 20);
            this.txtCity.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCity.Location = new System.Drawing.Point(6, 176);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 13);
            this.lblCity.TabIndex = 101;
            this.lblCity.Text = "City";
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(89, 94);
            this.txtAdd1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(167, 20);
            this.txtAdd1.TabIndex = 2;
            // 
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAdd1.Location = new System.Drawing.Point(6, 94);
            this.lblAdd1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(36, 13);
            this.lblAdd1.TabIndex = 99;
            this.lblAdd1.Text = "Add1";
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Location = new System.Drawing.Point(89, 52);
            this.txtBuyerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(167, 20);
            this.txtBuyerName.TabIndex = 1;
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AutoSize = true;
            this.lblBuyerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBuyerName.Location = new System.Drawing.Point(6, 53);
            this.lblBuyerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(75, 13);
            this.lblBuyerName.TabIndex = 98;
            this.lblBuyerName.Text = "Buyer Name";
            // 
            // tbView
            // 
            this.tbView.BackColor = System.Drawing.Color.SandyBrown;
            this.tbView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbView.Controls.Add(this.grdBuyerDetails);
            this.tbView.Location = new System.Drawing.Point(4, 22);
            this.tbView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbView.Name = "tbView";
            this.tbView.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbView.Size = new System.Drawing.Size(555, 251);
            this.tbView.TabIndex = 1;
            this.tbView.Text = "View Complete Details";
            // 
            // grdBuyerDetails
            // 
            this.grdBuyerDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBuyerDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBuyerDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdBuyerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuyerDetails.GridColor = System.Drawing.Color.LemonChiffon;
            this.grdBuyerDetails.Location = new System.Drawing.Point(5, 27);
            this.grdBuyerDetails.Name = "grdBuyerDetails";
            this.grdBuyerDetails.RowHeadersVisible = false;
            this.grdBuyerDetails.Size = new System.Drawing.Size(539, 215);
            this.grdBuyerDetails.TabIndex = 121;
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
            this.btnSave.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(123, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 9;
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
            this.btnExit.Location = new System.Drawing.Point(407, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "    &Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmManageBuyer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(833, 445);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageBuyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageBuyer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmManageBuyer_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbEdit.ResumeLayout(false);
            this.tbEdit.PerformLayout();
            this.tbView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBuyerDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbEdit;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.ComboBox cmbBuyer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.Label lblBuyerName;
        private System.Windows.Forms.TabPage tbView;
        private System.Windows.Forms.Label Active;
        private System.Windows.Forms.ComboBox cmbActive;
        private System.Windows.Forms.Label lblContactPerson;
        private System.Windows.Forms.RichTextBox rtxtRemarks;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.Label lblAdd2;
        private System.Windows.Forms.DataGridView grdBuyerDetails;
        private System.Windows.Forms.TextBox txtGstin;
        private System.Windows.Forms.Label lblGstinNo;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtContactPerson;
    }
}
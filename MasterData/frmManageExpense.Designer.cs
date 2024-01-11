namespace EagleEye.MasterData
{
    partial class frmManageExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageExpense));
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.rtxtRemarks = new System.Windows.Forms.RichTextBox();
            this.cmbExpense = new System.Windows.Forms.ComboBox();
            this.txtExpenseDesc = new System.Windows.Forms.TextBox();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.txtExpenseID = new System.Windows.Forms.TextBox();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.tbEdit = new System.Windows.Forms.TabPage();
            this.Active = new System.Windows.Forms.Label();
            this.cmbActive = new System.Windows.Forms.ComboBox();
            this.lblVendor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbEdit.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
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
            // rtxtRemarks
            // 
            this.rtxtRemarks.Location = new System.Drawing.Point(314, 298);
            this.rtxtRemarks.Name = "rtxtRemarks";
            this.rtxtRemarks.Size = new System.Drawing.Size(252, 67);
            this.rtxtRemarks.TabIndex = 4;
            this.rtxtRemarks.Text = "";
            // 
            // cmbExpense
            // 
            this.cmbExpense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpense.FormattingEnabled = true;
            this.cmbExpense.Location = new System.Drawing.Point(314, 18);
            this.cmbExpense.Name = "cmbExpense";
            this.cmbExpense.Size = new System.Drawing.Size(252, 28);
            this.cmbExpense.TabIndex = 0;
            this.cmbExpense.SelectedIndexChanged += new System.EventHandler(this.CmbExpense_SelectedIndexChanged);
            // 
            // txtExpenseDesc
            // 
            this.txtExpenseDesc.Location = new System.Drawing.Point(314, 158);
            this.txtExpenseDesc.Name = "txtExpenseDesc";
            this.txtExpenseDesc.Size = new System.Drawing.Size(248, 26);
            this.txtExpenseDesc.TabIndex = 2;
            // 
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAdd1.Location = new System.Drawing.Point(63, 158);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(174, 20);
            this.lblAdd1.TabIndex = 99;
            this.lblAdd1.Text = "Expense Description";
            // 
            // txtExpenseID
            // 
            this.txtExpenseID.Location = new System.Drawing.Point(314, 89);
            this.txtExpenseID.Name = "txtExpenseID";
            this.txtExpenseID.Size = new System.Drawing.Size(248, 26);
            this.txtExpenseID.TabIndex = 1;
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblVendorName.Location = new System.Drawing.Point(63, 88);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(102, 20);
            this.lblVendorName.TabIndex = 98;
            this.lblVendorName.Text = "Expense ID";
            // 
            // tbEdit
            // 
            this.tbEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.tbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEdit.Controls.Add(this.Active);
            this.tbEdit.Controls.Add(this.cmbActive);
            this.tbEdit.Controls.Add(this.rtxtRemarks);
            this.tbEdit.Controls.Add(this.lblVendor);
            this.tbEdit.Controls.Add(this.cmbExpense);
            this.tbEdit.Controls.Add(this.label3);
            this.tbEdit.Controls.Add(this.txtExpenseDesc);
            this.tbEdit.Controls.Add(this.lblAdd1);
            this.tbEdit.Controls.Add(this.txtExpenseID);
            this.tbEdit.Controls.Add(this.lblVendorName);
            this.tbEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEdit.Location = new System.Drawing.Point(4, 29);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tbEdit.Size = new System.Drawing.Size(636, 393);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.Text = "Manage Expense Head";
            // 
            // Active
            // 
            this.Active.AutoSize = true;
            this.Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Active.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Active.Location = new System.Drawing.Point(63, 228);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(58, 20);
            this.Active.TabIndex = 113;
            this.Active.Text = "Active";
            // 
            // cmbActive
            // 
            this.cmbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActive.FormattingEnabled = true;
            this.cmbActive.Location = new System.Drawing.Point(314, 227);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.Size = new System.Drawing.Size(252, 28);
            this.cmbActive.TabIndex = 3;
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblVendor.Location = new System.Drawing.Point(63, 18);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(134, 20);
            this.lblVendor.TabIndex = 107;
            this.lblVendor.Text = "Select Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(63, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Remarks";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbEdit);
            this.tabMain.Location = new System.Drawing.Point(44, 88);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(644, 426);
            this.tabMain.TabIndex = 90;
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
            this.pnlMain.Location = new System.Drawing.Point(62, 52);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(782, 579);
            this.pnlMain.TabIndex = 43;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(184, 525);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "   &Proceed";
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
            this.btnExit.Location = new System.Drawing.Point(491, 522);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "   &Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmManageExpense
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(909, 682);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageExpense";
            this.Text = "Manage Expense Heads";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmManageExpense_Load);
            this.tbEdit.ResumeLayout(false);
            this.tbEdit.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtxtRemarks;
        private System.Windows.Forms.ComboBox cmbExpense;
        private System.Windows.Forms.TextBox txtExpenseDesc;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.TextBox txtExpenseID;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tbEdit;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Active;
        private System.Windows.Forms.ComboBox cmbActive;
    }
}
namespace EagleEye.Operations
{
    partial class frmManageParameters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageParameters));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbEdit = new System.Windows.Forms.TabPage();
            this.dgParameters = new System.Windows.Forms.DataGridView();
            this.lblParameter = new System.Windows.Forms.Label();
            this.cmbParameter = new System.Windows.Forms.ComboBox();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgParameters)).BeginInit();
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
            this.pnlMain.Location = new System.Drawing.Point(64, 29);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(625, 377);
            this.pnlMain.TabIndex = 43;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbEdit);
            this.tabMain.Location = new System.Drawing.Point(29, 64);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(563, 270);
            this.tabMain.TabIndex = 90;
            // 
            // tbEdit
            // 
            this.tbEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.tbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEdit.Controls.Add(this.dgParameters);
            this.tbEdit.Controls.Add(this.lblParameter);
            this.tbEdit.Controls.Add(this.cmbParameter);
            this.tbEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbEdit.Location = new System.Drawing.Point(4, 22);
            this.tbEdit.Margin = new System.Windows.Forms.Padding(2);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Padding = new System.Windows.Forms.Padding(2);
            this.tbEdit.Size = new System.Drawing.Size(555, 244);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.Text = "Manage Parameters";
            // 
            // dgParameters
            // 
            this.dgParameters.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgParameters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgParameters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgParameters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParameters.GridColor = System.Drawing.Color.LemonChiffon;
            this.dgParameters.Location = new System.Drawing.Point(16, 52);
            this.dgParameters.Name = "dgParameters";
            this.dgParameters.RowHeadersVisible = false;
            this.dgParameters.Size = new System.Drawing.Size(521, 185);
            this.dgParameters.TabIndex = 121;
            // 
            // lblParameter
            // 
            this.lblParameter.AutoSize = true;
            this.lblParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParameter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblParameter.Location = new System.Drawing.Point(13, 20);
            this.lblParameter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParameter.Name = "lblParameter";
            this.lblParameter.Size = new System.Drawing.Size(104, 13);
            this.lblParameter.TabIndex = 107;
            this.lblParameter.Text = "Select Parameter";
            // 
            // cmbParameter
            // 
            this.cmbParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParameter.FormattingEnabled = true;
            this.cmbParameter.Location = new System.Drawing.Point(158, 17);
            this.cmbParameter.Margin = new System.Windows.Forms.Padding(2);
            this.cmbParameter.Name = "cmbParameter";
            this.cmbParameter.Size = new System.Drawing.Size(379, 21);
            this.cmbParameter.TabIndex = 0;
            this.cmbParameter.SelectedIndexChanged += new System.EventHandler(this.cmbParameter_SelectedIndexChanged);
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
            this.btnSave.Location = new System.Drawing.Point(154, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::EagleEye.Properties.Resources.img_btn_exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Location = new System.Drawing.Point(468, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 31);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmManageParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(752, 435);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManageParameters";
            this.Text = "Manage Parameters";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManageParameters_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbEdit.ResumeLayout(false);
            this.tbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgParameters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbEdit;
        private System.Windows.Forms.Label lblParameter;
        private System.Windows.Forms.ComboBox cmbParameter;
        private System.Windows.Forms.DataGridView dgParameters;
    }
}
namespace EagleEye.About
{
    partial class frmLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicense));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbSoftwareLicense = new System.Windows.Forms.TabPage();
            this.rtbLicence = new System.Windows.Forms.RichTextBox();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbSoftwareLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.lblFormHeader);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Location = new System.Drawing.Point(130, 46);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(936, 579);
            this.pnlMain.TabIndex = 42;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbSoftwareLicense);
            this.tabMain.Location = new System.Drawing.Point(44, 98);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(844, 415);
            this.tabMain.TabIndex = 90;
            // 
            // tbSoftwareLicense
            // 
            this.tbSoftwareLicense.BackColor = System.Drawing.Color.SandyBrown;
            this.tbSoftwareLicense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSoftwareLicense.Controls.Add(this.rtbLicence);
            this.tbSoftwareLicense.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbSoftwareLicense.Location = new System.Drawing.Point(4, 29);
            this.tbSoftwareLicense.Name = "tbSoftwareLicense";
            this.tbSoftwareLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tbSoftwareLicense.Size = new System.Drawing.Size(836, 382);
            this.tbSoftwareLicense.TabIndex = 0;
            this.tbSoftwareLicense.Text = "Software License ";
            // 
            // rtbLicence
            // 
            this.rtbLicence.Enabled = false;
            this.rtbLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLicence.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rtbLicence.Location = new System.Drawing.Point(92, 11);
            this.rtbLicence.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbLicence.Name = "rtbLicence";
            this.rtbLicence.ReadOnly = true;
            this.rtbLicence.Size = new System.Drawing.Size(662, 354);
            this.rtbLicence.TabIndex = 0;
            this.rtbLicence.Text = "";
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
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Image = global::EagleEye.Properties.Resources.img_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(552, 522);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "   &Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1250, 685);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageUsers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLicense_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbSoftwareLicense.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbSoftwareLicense;
        private System.Windows.Forms.RichTextBox rtbLicence;
    }
}
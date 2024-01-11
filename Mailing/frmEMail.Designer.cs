namespace EagleEye.Mailing
{
    partial class frmEmail
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabEmail = new System.Windows.Forms.TabPage();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.chkBoxPriority = new System.Windows.Forms.CheckBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lnkAttachment = new System.Windows.Forms.LinkLabel();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.lblCc = new System.Windows.Forms.Label();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.tabMailSetting = new System.Windows.Forms.TabPage();
            this.cmdUpdateEmailSetting = new System.Windows.Forms.Button();
            this.cmbEmailType = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabEmail.SuspendLayout();
            this.tabMailSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.lblFormHeader);
            this.pnlMain.Location = new System.Drawing.Point(55, 39);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(625, 475);
            this.pnlMain.TabIndex = 92;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabEmail);
            this.tabMain.Controls.Add(this.tabMailSetting);
            this.tabMain.Location = new System.Drawing.Point(14, 51);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(590, 406);
            this.tabMain.TabIndex = 90;
            // 
            // tabEmail
            // 
            this.tabEmail.BackColor = System.Drawing.Color.SandyBrown;
            this.tabEmail.Controls.Add(this.btnSendMail);
            this.tabEmail.Controls.Add(this.chkBoxPriority);
            this.tabEmail.Controls.Add(this.lblFilePath);
            this.tabEmail.Controls.Add(this.lnkAttachment);
            this.tabEmail.Controls.Add(this.lblAttachment);
            this.tabEmail.Controls.Add(this.txtCc);
            this.tabEmail.Controls.Add(this.lblCc);
            this.tabEmail.Controls.Add(this.rtxtMessage);
            this.tabEmail.Controls.Add(this.lblMessage);
            this.tabEmail.Controls.Add(this.lblSubject);
            this.tabEmail.Controls.Add(this.txtSubject);
            this.tabEmail.Controls.Add(this.txtTo);
            this.tabEmail.Controls.Add(this.lblTo);
            this.tabEmail.ForeColor = System.Drawing.Color.SandyBrown;
            this.tabEmail.Location = new System.Drawing.Point(4, 22);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmail.Size = new System.Drawing.Size(582, 380);
            this.tabEmail.TabIndex = 0;
            this.tabEmail.Text = "Documents Mailing";
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSendMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSendMail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSendMail.Image = global::EagleEye.Properties.Resources.img_login;
            this.btnSendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMail.Location = new System.Drawing.Point(388, 320);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(149, 30);
            this.btnSendMail.TabIndex = 118;
            this.btnSendMail.Text = "   &Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.BtnSendMail_Click);
            // 
            // chkBoxPriority
            // 
            this.chkBoxPriority.AutoSize = true;
            this.chkBoxPriority.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkBoxPriority.Location = new System.Drawing.Point(117, 320);
            this.chkBoxPriority.Name = "chkBoxPriority";
            this.chkBoxPriority.Size = new System.Drawing.Size(93, 17);
            this.chkBoxPriority.TabIndex = 6;
            this.chkBoxPriority.Text = "Is High Priority";
            this.chkBoxPriority.UseVisualStyleBackColor = true;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFilePath.Location = new System.Drawing.Point(193, 139);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(48, 13);
            this.lblFilePath.TabIndex = 113;
            this.lblFilePath.Text = "File Path";
            this.lblFilePath.Visible = false;
            // 
            // lnkAttachment
            // 
            this.lnkAttachment.AutoSize = true;
            this.lnkAttachment.Location = new System.Drawing.Point(116, 139);
            this.lnkAttachment.Name = "lnkAttachment";
            this.lnkAttachment.Size = new System.Drawing.Size(57, 13);
            this.lnkAttachment.TabIndex = 4;
            this.lnkAttachment.TabStop = true;
            this.lnkAttachment.Text = "File Attach";
            this.lnkAttachment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAttachment_LinkClicked);
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAttachment.Location = new System.Drawing.Point(45, 139);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(61, 13);
            this.lblAttachment.TabIndex = 112;
            this.lblAttachment.Text = "Attachment";
            // 
            // txtCc
            // 
            this.txtCc.Location = new System.Drawing.Point(116, 68);
            this.txtCc.Name = "txtCc";
            this.txtCc.Size = new System.Drawing.Size(421, 20);
            this.txtCc.TabIndex = 2;
            // 
            // lblCc
            // 
            this.lblCc.AutoSize = true;
            this.lblCc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCc.Location = new System.Drawing.Point(45, 71);
            this.lblCc.Name = "lblCc";
            this.lblCc.Size = new System.Drawing.Size(21, 13);
            this.lblCc.TabIndex = 111;
            this.lblCc.Text = "CC";
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.Location = new System.Drawing.Point(116, 172);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(421, 132);
            this.rtxtMessage.TabIndex = 5;
            this.rtxtMessage.Text = "";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMessage.Location = new System.Drawing.Point(45, 172);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 109;
            this.lblMessage.Text = "Message";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSubject.Location = new System.Drawing.Point(45, 105);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 106;
            this.lblSubject.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(116, 102);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(421, 20);
            this.txtSubject.TabIndex = 3;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(116, 37);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(421, 20);
            this.txtTo.TabIndex = 1;
            this.txtTo.Tag = "E-mail Address ";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTo.Location = new System.Drawing.Point(45, 40);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 103;
            this.lblTo.Text = "To";
            // 
            // tabMailSetting
            // 
            this.tabMailSetting.BackColor = System.Drawing.Color.SandyBrown;
            this.tabMailSetting.Controls.Add(this.cmdUpdateEmailSetting);
            this.tabMailSetting.Controls.Add(this.cmbEmailType);
            this.tabMailSetting.Controls.Add(this.txtPassword);
            this.tabMailSetting.Controls.Add(this.label1);
            this.tabMailSetting.Controls.Add(this.label2);
            this.tabMailSetting.Controls.Add(this.txtEmailID);
            this.tabMailSetting.Controls.Add(this.label3);
            this.tabMailSetting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabMailSetting.Location = new System.Drawing.Point(4, 22);
            this.tabMailSetting.Name = "tabMailSetting";
            this.tabMailSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabMailSetting.Size = new System.Drawing.Size(582, 380);
            this.tabMailSetting.TabIndex = 1;
            this.tabMailSetting.Text = "Mail Setting";
            // 
            // cmdUpdateEmailSetting
            // 
            this.cmdUpdateEmailSetting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdUpdateEmailSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdUpdateEmailSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmdUpdateEmailSetting.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmdUpdateEmailSetting.Image = global::EagleEye.Properties.Resources.img_proceed;
            this.cmdUpdateEmailSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdUpdateEmailSetting.Location = new System.Drawing.Point(126, 137);
            this.cmdUpdateEmailSetting.Name = "cmdUpdateEmailSetting";
            this.cmdUpdateEmailSetting.Size = new System.Drawing.Size(149, 30);
            this.cmdUpdateEmailSetting.TabIndex = 117;
            this.cmdUpdateEmailSetting.Text = "   &Save Changes";
            this.cmdUpdateEmailSetting.UseVisualStyleBackColor = false;
            this.cmdUpdateEmailSetting.Click += new System.EventHandler(this.CmdUpdateEmailSetting_Click);
            // 
            // cmbEmailType
            // 
            this.cmbEmailType.FormattingEnabled = true;
            this.cmbEmailType.Location = new System.Drawing.Point(126, 88);
            this.cmbEmailType.Name = "cmbEmailType";
            this.cmbEmailType.Size = new System.Drawing.Size(416, 21);
            this.cmbEmailType.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(126, 58);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(416, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(51, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(51, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Email Type";
            // 
            // txtEmailID
            // 
            this.txtEmailID.Location = new System.Drawing.Point(126, 27);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(416, 20);
            this.txtEmailID.TabIndex = 8;
            this.txtEmailID.Tag = "E-mail Address ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(51, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Email ID";
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
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(734, 456);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmEmail";
            this.Text = "ContactUs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEmail_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabEmail.ResumeLayout(false);
            this.tabEmail.PerformLayout();
            this.tabMailSetting.ResumeLayout(false);
            this.tabMailSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabEmail;
        private System.Windows.Forms.CheckBox chkBoxPriority;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.LinkLabel lnkAttachment;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.Label lblCc;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TabPage tabMailSetting;
        private System.Windows.Forms.ComboBox cmbEmailType;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdUpdateEmailSetting;
        private System.Windows.Forms.Button btnSendMail;
    }
}
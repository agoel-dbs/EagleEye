using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Configuration;
using EagleEye.DBLayer;
using EagleEye.Lib;

namespace EagleEye.Mailing
{
    public partial class frmEmail : Form
    {
        MailMessage message;
        SmtpClient smtp;
        string streMailForNetworkCred = ConfigurationManager.AppSettings["EMAIL_FOR_NETWORK_CRED"];
        string strePassForNetworkCred = ConfigurationManager.AppSettings["PASS_FOR_NETWORK_CRED"];
        string streSmtpClient = ConfigurationManager.AppSettings["SMTP_CLIENT"];

        static public string FormCaption { get; set; }

        public frmEmail()
        {
            InitializeComponent();
        }

        private void SendEmail(object sender, EventArgs e)
        {
            try
            {
                // btnSendMail.Enabled = false;
                if (txtTo.Text.Trim() == String.Empty)
                {
                    commonLib.showUIMessage("E-mail address is Empty.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtTo.Focus();
                    return;
                }
                if (!fnIsValidEmail(txtTo.Text.Trim()))
                {
                    commonLib.showUIMessage("Enter a valid email Id", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtTo.Focus();
                    return;
                }
                
                if (txtSubject.Text.Trim() == String.Empty)
                {
                    commonLib.showUIMessage("Enter Subject of the mail.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtSubject.Focus();
                    return;
                }
                if (!fnIsValidEmail(txtCc.Text.Trim()))
                {
                    commonLib.showUIMessage("Enter a valid email Id", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtTo.Focus();
                    return;
                }

                ControlEnableDisable(false);


                if (chkBoxPriority.Checked == true)
                {
                    MailingFunc.HighPriorty= true;
                }
                MailingFunc.To = txtTo.Text.Trim();
                MailingFunc.CC= txtCc.Text.Trim();
                MailingFunc.Subject= txtSubject.Text.Trim();
                MailingFunc.MailingUserID = Global.gMailID;
                MailingFunc.MailingPWD = commonLib.GetDecryptedPassword(Global.gMailPWd);
                MailingFunc.Body= rtxtMessage.Text.Trim();
                MailingFunc.AttachmentPath= lblFilePath.Text;

                // set smtp details
                MailingFunc.SMPTPPort = Global.gSMTPSSLPort;
                MailingFunc.EnableSSL = true;
                MailingFunc.SmtpClient= Global.gSMTPAddress;
                string strReturn=  MailingFunc.SendEmail();
                commonLib.showUIMessage(strReturn, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ControlEnableDisable(true); //btnSendMail.Enabled = true;
            }
        }

        private void ControlEnableDisable(bool value)
        {
            txtTo.Enabled = value;
            txtCc.Enabled = value;
            txtSubject.Enabled = value;
            rtxtMessage.Enabled = value;
            lblFilePath.Enabled = value;
            btnSendMail.Enabled = value;
            lnkAttachment.Enabled = value;
            chkBoxPriority.Enabled = value;
        }
        void smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Email sending cancelled!");
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                txtTo.Text = String.Empty;
                txtCc.Text = String.Empty;
                txtSubject.Text = String.Empty;
                rtxtMessage.Text = String.Empty;
                lblFilePath.Text = String.Empty;
                chkBoxPriority.Checked = false;
                MessageBox.Show("Email sent sucessfully!");
            }

            ControlEnableDisable(true); //btnSendMail.Enabled = true;
        }
        private bool fnIsValidEmail(string strEmail)
        {
            if (strEmail == string.Empty)
                return true;
            Regex mRegxExpression;

            mRegxExpression = new Regex(@"^(([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)(\s*(;|,)\s*|\s*$))*$");   //@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

            if (!mRegxExpression.IsMatch(strEmail))
            {
                MessageBox.Show("E-mail address format is not correct.", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void lnkAttachment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofdAttachment = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                //DefaultExt = "txt",
                //Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (ofdAttachment.ShowDialog() != DialogResult.Cancel)
            {
                lblFilePath.Text = ofdAttachment.FileName;
                lblFilePath.Visible = true;
                // lnkAttachment.Visible = false;
            }
            else
            {
                lblFilePath.Text = String.Empty;
            }
        }

        private void FrmEmail_Load(object sender, EventArgs e)
        {
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, FormCaption);
            loadUserMailSetting();
            loadEmailType();

        }

        private void loadUserMailSetting()
        {
            try
            {

                loadEmailType();
                // load user settings

                if (Global.gMailID == String.Empty || Global.gMailID == null)
                {
                    commonLib.showUIMessage("Your Email account is not set-up , please set-up your account before sending the emails!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    ControlEnableDisable(false);
                    tabMain.SelectTab(tabEmail);
                    return;
                }
                else
                {
                    txtEmailID.Text = Global.gMailID;
                    txtPassword.Text = commonLib.GetDecryptedPassword(Global.gMailPWd);
                    cmbEmailType.SelectedValue = Global.gSMTPRK.ToString();
                }

            }

            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        
        private void loadEmailType()
            {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "smtp_master";
                objCommonDBFunc.CodeColumnName = "smtp_rk";
                objCommonDBFunc.DisplayColumnName = "smtp_name";
                objCommonDBFunc.ShowAddNew = "N";
                objCommonDBFunc.DataFilter = " is_active = 1";
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, cmbEmailType, true);

            }

            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void CmdUpdateEmailSetting_Click(object sender, EventArgs e)
        {
            try
            {
                string strEmailID;
                string strPassword;
                int SmtpRk;

                strEmailID = txtEmailID.Text.Trim();

                if (strEmailID == String.Empty)
                {
                    commonLib.showUIMessage("Enter your email Id.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtEmailID.Focus();
                    return;
                }
                if (!fnIsValidEmail(strEmailID))
                {
                    commonLib.showUIMessage("Enter a valid email Id", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtEmailID.Focus();
                    return;
                }

                if (txtPassword.Text.Trim() == String.Empty)
                {
                    commonLib.showUIMessage("Enter your email password.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtPassword.Focus();
                    return;
                }

                strPassword = commonLib.GetEncryptedPassword(txtPassword.Text);
                SmtpRk = Convert.ToInt16(cmbEmailType.SelectedValue.ToString());
                // save data
                EmailManagement objEmail = new EmailManagement();

                objEmail.UserId = Global.gUserID;
                objEmail.MailID= strEmailID;
                objEmail.MailPWD= strPassword;
                objEmail.CreatedBy = Global.gUserID;
                objEmail.SmtpRK = SmtpRk;

                //Display Message
                string strReturn = objEmail.SetMailSetting();
                commonLib.ShowDBMessage(strReturn);

                // set global parameter

                commonLib.PopulateLoginBasedGlobalParameter();

            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            try { 
                SendEmail(sender,e);
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        
    }
}

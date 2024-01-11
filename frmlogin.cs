using EagleEye.DBLayer;
using EagleEye.Lib;
using System;
using System.Configuration;
using System.Windows.Forms;
namespace EagleEye
{
    public partial class frmlogin : Form
    {
        bool bSpecialAccess;
        public frmlogin()
        {
            InitializeComponent();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {
            try
            {
                commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Login Details");
                commonLib.ControlSetting(this);
                PopulateLastLoginUser();
                CheckApplicationVersion();
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void CheckApplicationVersion()
        {
            try
            {
                string strMsg;
                lblCurrentVersion.Text = "Current Version: " + Global.gCurrentApplicationVersion;
                lblReleasedVersion.Text = "Released Version: " + Global.gReleasedApplicationVersion;

                strMsg = "You are running the older version of this application." + Environment.NewLine +
                         "All the features may not be available. " + Environment.NewLine +
                          Global.gContactUs;
                if (Global.gCurrentApplicationVersion != Global.gReleasedApplicationVersion)
                {
                    commonLib.showUIMessage(strMsg, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                lblMode.Text = "Mode:" + commonLib.fnCheckNull1(ConfigurationManager.AppSettings.Get("APP_RUN_MODE"));


            }

            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }



        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string UserId;
            string PWD;
            string strResult;
            string strMsg;
            UserManagment objUser = new UserManagment();

            // check valid license or Not

            CheckSpecialAccess();

            bSpecialAccess = Global.gSpecialAdminPower;

            if (bSpecialAccess == false)
            {
                if (!CheckValidLicence())
                {

                    strMsg = "This software is not licensed to your Company." + Environment.NewLine +
                              Global.gContactUs;
                    commonLib.showUIMessage(strMsg, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    frmlogin.ActiveForm.Close();
                }

                // check licese expiry

                if (!CheckLicenseDateValidity())
                {
                    strMsg = "Software license has been expired." + Environment.NewLine +
                              Global.gContactUs;
                    commonLib.showUIMessage(strMsg, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    frmlogin.ActiveForm.Close();
                }

                if (!CheckCorrectSystemDate())
                {
                    strMsg = "Your computer system date time is not same as today's date ." + Environment.NewLine +
                              Global.gContactUs;
                    commonLib.showUIMessage(strMsg, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    frmlogin.ActiveForm.Close();
                }

                UserId = txtUserID.Text.Trim();
                PWD = commonLib.GetEncryptedPassword(txtPassword.Text);

                if ((UserId == "") || (PWD == ""))
                {
                    commonLib.showUIMessage("User ID and Password can not be blank. Enter valid details", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                objUser.UserId = UserId.ToUpper();
                objUser.Password = PWD;
                strResult = objUser.AuthenticateUser();

                // User Details not found

                if (strResult == "0")
                {
                    commonLib.showUIMessage("Your account or password is incorrect." +
                                            "If you don't remember your password,contact system administrator."
                                            , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                // user is Autheticated
                if (chkRememberMe.Checked == false)
                {
                    UserId = "";
                    PWD = "";
                }
                commonLib.UpdateConfigKey("LAST_LOGIN_USER", UserId);
                commonLib.UpdateConfigKey("PWD", PWD);
            }

            Global.gUserID = txtUserID.Text.Trim().ToUpper(); 
            // load global parameters based on the login user id
            commonLib.PopulateLoginBasedGlobalParameter();

            // take db backup 
            if (ConfigurationManager.AppSettings.Get("AUTO_BACKUP_ALLOWED") == "Y")
            {
                Cursor.Current = Cursors.WaitCursor;
                commonLib.DataBackupAuto();
                Cursor.Current = Cursors.Default;
                //commonLib.showUIMessage("Backup created and uploaded to Dropbox sucessfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

            // load MDI form
            frmMain objMain = new frmMain();
            objMain.ShowDialog();

            this.Close();
        }

        

        private  void PopulateLastLoginUser()
        {
            try
            {
                txtUserID.Text  = ConfigurationManager.AppSettings.Get("LAST_LOGIN_USER").Trim();
                txtPassword.Text = commonLib.GetDecryptedPassword(ConfigurationManager.AppSettings.Get("PWD").Trim());

                // cofig file does has user id then password would be excrypted so no need to encrypte further
                if (txtUserID.Text != "")
                {
                    chkRememberMe.Checked = true;
                    btnLogin.Focus();

                }
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private Boolean CheckValidLicence()
        {
            try
            {

                
                string strGSTIN;
                string strLicenseKey;
                ParameterDetails objParam;
                //strLicenseKey = commonLib.fnCheckNull1(ConfigurationManager.AppSettings.Get("LICESSE_KEY"));
                objParam = new ParameterDetails();
                objParam.ParaCode = "LICESSE_KEY";
                strLicenseKey = objParam.GetParameterValue();


                objParam = new ParameterDetails();
                objParam.ParaCode = "SELLER_GSTIN";
                Global.gSellerGSTIN = objParam.GetParameterValue();

                strGSTIN = Global.gSellerGSTIN;

                if (!commonLib.IsValidLicense(strGSTIN, strLicenseKey))
                {
                    return false;
                }
                else
                {
                    return true;
                }
         
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }



        private Boolean CheckLicenseDateValidity()
        {
            try
            {

                string strLicenseDate;
                string strLicenseValidityDate;
                DateTime LicenseValidityDate;
                TimeSpan DateDiff;
                int DaysLeft;
                string strMsg;
                ParameterDetails objParam;
                
                strLicenseDate = ConfigurationManager.AppSettings.Get("LICESSE_VALIDITY").Trim();
                objParam = new ParameterDetails();
                objParam.ParaCode = "LICESSE_VALIDITY";
                strLicenseDate = objParam.GetParameterValue();

                strLicenseValidityDate = commonLib.GetDecryptedPassword(strLicenseDate);

                LicenseValidityDate = commonLib.ConvertStringtoDate(strLicenseValidityDate);

                DateDiff = LicenseValidityDate - DateTime.Now;
                DaysLeft = DateDiff.Days;

                if (DaysLeft < 0)
                {
                    return false;
                }

                if (DaysLeft < Global.gAdvanceDaysofLicenceExpiry)
                {
                    if (DaysLeft == 0)
                    {
                        strMsg = "Your Licnese is going to expire today." + Environment.NewLine
                             + Global.gContactUs;                    }
                    else
                    {
                        strMsg = "Your Licnese is going to expire in next " + DaysLeft + " Days." + Environment.NewLine
                                 + ", renew your license otherwise application will stop working." + Environment.NewLine
                                 + Global.gContactUs; ;
                    }
                    commonLib.showUIMessage(strMsg , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                    return true;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }

        private void CheckSpecialAccess()
        {
            try
            {
                bSpecialAccess = false;
                if (commonLib.GetLicenseKey(txtPassword.Text) == Global.gAdminSecPass)
                {
                    Global.gSpecialAdminPower = true;
                }
                
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                bSpecialAccess = false;
            }
        }

        private Boolean CheckCorrectSystemDate()
        {
            try
            {
                string strRetult;
                DateTime dInvoiceDate;
                InvoiceDetails objInv = new InvoiceDetails();

                // sqlite returns yyyy-dd-mm format
                strRetult = objInv.GetLastInvoiceDate();
                dInvoiceDate = commonLib.ConvertSqlStringtoDate(strRetult.Substring(0,10));

                if ( DateTime.Now < dInvoiceDate)
                {
                    return false;
                }

                return true;
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }


    }
}

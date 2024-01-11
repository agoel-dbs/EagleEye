using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EagleEye.DBLayer;
using EagleEye.Lib;

namespace EagleEye.Administration
{
    public partial class frmManagePassword : Form
    {

        Boolean bFormLoad = false;
        string strUserID = "";
        public frmManagePassword()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Change Password");

        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManagePassword_Load(object sender, EventArgs e)
        {
           
            bFormLoad = true;
        }


        private void BlankControl()
        {
            try
            {
                txtCurrentPassword.Text = "";
                txtNewPassword.Text = "";                
                txtConfirmPassword.Text = "";
                           
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                string strCurrentPassword;
                string strNewPassword;
                string strConfirmPassword ;
                string strEncriptPassword;               
                string strReturn;  
                strCurrentPassword = txtCurrentPassword.Text.Trim();
                strNewPassword = txtNewPassword.Text.Trim();
                strConfirmPassword = txtConfirmPassword.Text.Trim();


                if (strCurrentPassword == "")
                {
                    commonLib.showUIMessage("Current Password can not be blank!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCurrentPassword.Focus();
                    return;
                }
                if (strNewPassword == "")
                {
                    commonLib.showUIMessage("New Password can not be blank!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNewPassword.Focus();
                    return;
                }
                if (strConfirmPassword == "")
                {
                    commonLib.showUIMessage("Confirm Password can not be blank!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtConfirmPassword.Focus();
                    return;
                }
                if (strNewPassword == strCurrentPassword)
                {
                    commonLib.showUIMessage("New password is same as current password. Please Change the New password!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtConfirmPassword.Focus();
                    return;
                }
                if (strNewPassword!= strConfirmPassword)
                {
                    commonLib.showUIMessage("New Password and Confirm Password not match. Please Check Confirm Password!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtConfirmPassword.Focus();
                    return;
                }

                UserManagment objUser = new UserManagment();
                strEncriptPassword =  commonLib.GetEncryptedPassword(strCurrentPassword);
                
                objUser.UserId = Global.gUserID;
                objUser.Password = strEncriptPassword;
                strReturn = objUser.AuthenticateUser();
                
                if (strReturn == "1")
                {
                    strEncriptPassword = commonLib.GetEncryptedPassword(strNewPassword);
                    objUser.UserId = Global.gUserID;
                    objUser.Password = strEncriptPassword;
                    objUser.CreatedBy = Global.gUserID;
                    strReturn = objUser.RestPassword();
                    if(strReturn.Contains("1~"))
                    {
                        commonLib.showUIMessage(strReturn.Replace("1~", ""), MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        BlankControl();
                    }
                    else
                    {
                        commonLib.showUIMessage(strReturn, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        BlankControl();
                    }
                }
                else
                {
                    commonLib.showUIMessage("Enter correct current password!! ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

      
    }
}

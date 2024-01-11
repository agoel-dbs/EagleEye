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
    public partial class frmManageUsers : Form
    {

        Boolean bFormLoad = false;
        string strUserID = "";
        public frmManageUsers()
        {
            InitializeComponent();
         

        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmManageUsers_Load(object sender, EventArgs e)
        {
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Manage Users");
            LoadDropDownData();
            bFormLoad = true;
        }

        private void LoadDropDownData()
        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "user_master";
                objCommonDBFunc.CodeColumnName = "usr_id";
                objCommonDBFunc.DisplayColumnName = "usr_name";
                objCommonDBFunc.ShowAddNew = "Y";
                objCommonDBFunc.DataFilter = " role_id <> '" + Global.gAdminRoleID + "'";
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, cmbUser,false);

                objCommonDBFunc.TableName = "role_master";
                objCommonDBFunc.CodeColumnName = "role_id";
                objCommonDBFunc.DisplayColumnName = "role_name";
                objCommonDBFunc.ShowAddNew = "N";
                objCommonDBFunc.DataFilter = " role_id <> '" + Global.gAdminRoleID +  "'";
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, cmbRole,false);


                commonLib.PopulateParamMasterCombo(cmbActive, "N", " para_group = 'YES_NO' ", "N");
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void CmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bFormLoad == false)
                    return;

                strUserID = cmbUser.SelectedValue.ToString(); 

                if (strUserID == Global.gAddNew)
                {
                    EnableControl(true);
                    BlankControl();
                }
                else
                {
                    EnableControl(false);
                    LoadDetails();

                }
            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private   void LoadDetails()
        {
            try
            {
                DataTable DT;
                UserManagment objUser = new UserManagment();
                objUser.UserId = strUserID ;
                DT= objUser.GetUserDetails();
               

                if (DT.Rows.Count == 0)
                {
                    commonLib.showUIMessage("User Information not found , reload the screen and try again !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                // enable active combo
                cmbActive.Enabled = true;

                // will return one row
                DataRow row = DT.Rows[0];
                //foreach (DataRow row in DT.Rows)
                //{
                    txtUserID.Text = row["UserId"].ToString();
                    txtPassword.Text = "";
                    txtUserName.Text = row["Name"].ToString();
                    txtContactNo.Text = row["ContactNo"].ToString();
                    txtMailId.Text = row["MailID"].ToString();
                    cmbActive.SelectedValue = row["Active"].ToString();
                    cmbRole.SelectedValue = row["RoleID"].ToString();
                    rtxtRemarks.Text = row["Remarks"].ToString();

                //}

                GridFunc.PopulateDataGrid(grdDetails, DT);
               
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BlankControl()
        {
            try
            {
                txtUserID.Text = "";
                txtUserName.Text = "";
                txtContactNo.Text = "";
                txtMailId.Text = "";
                txtPassword.Text = "";
                rtxtRemarks.Text = "";
                cmbActive.SelectedValue = 1;
                cmbActive.Enabled = false;
                cmbRole.SelectedIndex = 0;
                grdDetails.DataSource = null;
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void EnableControl(Boolean pEnable)
        {
            try
            {
                txtUserID.Enabled = pEnable;
                btnResetPwd.Enabled = !pEnable;
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

                string UserID;
                string UserName;
                string Password = "";
                string EmailID;
                string ContactNo;
                string RoleID;
                int IsActive;
                string Remarks;
                string CreatedBy;
                string strReturn;

                UserManagment objUser = new UserManagment();


                UserID = txtUserID.Text.Trim();
                if (UserID == "")
                {
                    commonLib.showUIMessage("User ID can not be blank!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                UserName = txtUserName.Text.Trim();
                if (txtPassword.Text.Trim() != "")
                    Password =  commonLib.GetEncryptedPassword(txtPassword.Text.Trim());
                EmailID = txtMailId.Text.Trim();
                ContactNo = txtContactNo.Text.Trim();
                RoleID = cmbRole.SelectedValue.ToString();
                IsActive = Convert.ToInt16(cmbActive.SelectedValue.ToString());
                Remarks = rtxtRemarks.Text.Trim();
                CreatedBy = Global.gUserID;

                


                if (strUserID == Global.gAddNew)
                {
                    if (Password== "")
                    {
                        commonLib.showUIMessage("Enter a valid password!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    if (UserName == "")
                    {
                        commonLib.showUIMessage("Enter user name!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    objUser.AddFlag = true;
                }
                else
                {
                    objUser.AddFlag = false;
                }


                //set DB Class Parameteres

                objUser.UserId = UserID;
                objUser.UserName= UserName;
                objUser.Password = Password;
                objUser.EmailID= EmailID;
                objUser.ContactNo = ContactNo;
                objUser.RoleID = RoleID;
                objUser.IsActive = IsActive;
                objUser.Remarks = Remarks;
                objUser.CreatedBy = CreatedBy;

                //Display Message
                strReturn = objUser.ManageUserDetails();
                commonLib.ShowDBMessage(strReturn);

            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void BtnResetPwd_Click(object sender, EventArgs e)
        {
            try
            {

                string UserID;
                string Password = "";
                string CreatedBy;
                string strReturn;
                CreatedBy = Global.gUserID;
                UserID = txtUserID.Text.Trim();


                if (txtPassword.Text.Trim() != "")
                    Password = commonLib.GetEncryptedPassword(txtPassword.Text.Trim());
                else
                {
                    commonLib.showUIMessage("Enter a valid password!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                
                UserManagment objUser = new UserManagment();




                //set DB Class Parameteres

                objUser.UserId = UserID;
                objUser.Password = Password;
                objUser.CreatedBy = CreatedBy;

                //Display Message
                strReturn = objUser.RestPassword();
                commonLib.ShowDBMessage(strReturn);

            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

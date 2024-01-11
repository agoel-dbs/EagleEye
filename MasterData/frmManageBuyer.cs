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
    public partial class frmManageBuyer : Form
    {

        Boolean bFormLoad = false;
        string strBuyerRk = "";
        public frmManageBuyer()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Manage Buyer");

        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmManageBuyer_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
            bFormLoad = true;
        }

        private void LoadDropDownData()
        {
            try
            {
                
                commonLib.PopulateBuyerCombo(cmbBuyer, "Y", "", "N");

                commonLib.PopulateParamMasterCombo(cmbActive, "N", " para_group = 'YES_NO' ", "N");
                
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void cmbBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bFormLoad == false)
                    return;

                strBuyerRk = cmbBuyer.SelectedValue.ToString(); 

                if (strBuyerRk == Global.gAddNew)
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
                BuyerManagement objBuyer = new BuyerManagement();
                objBuyer.BuyerRK = strBuyerRk;
                DT= objBuyer.GetBuyerDetails();
               

                if (DT.Rows.Count == 0)
                {
                    commonLib.showUIMessage("User Information not found , reload the screen and try again !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                // enable active combo
                cmbActive.Enabled = true;

                // will return one row
                DataRow row = DT.Rows[0];
                
                txtBuyerName.Text = row["Name"].ToString();
                txtAdd1.Text = row["Address1"].ToString(); 
                txtAdd2.Text = row["Address2"].ToString();
                txtState.Text = row["State"].ToString();
                txtCity.Text = row["City"].ToString();
                txtContactPerson.Text = row["ContactPerson"].ToString();
                txtEmailId.Text = row["EmailId"].ToString();
                txtGstin.Text = row["GSTIN"].ToString();

                cmbActive.SelectedValue = row["Active"].ToString();                    
                rtxtRemarks.Text = row["Remarks"].ToString();

               
                GridFunc.PopulateDataGrid(grdBuyerDetails, DT);
               
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
                txtBuyerName.Text = "";
                txtAdd1.Text = "";
                txtAdd2.Text = "";
                txtState.Text = "";
                txtCity.Text = "";
                txtContactPerson.Text = "";
                txtEmailId.Text = "";
                txtGstin.Text = "";
                rtxtRemarks.Text = "";
                cmbActive.SelectedValue = 1;
                
                cmbActive.Enabled = false;
                //cmbRole.SelectedIndex = 0;
                grdBuyerDetails.DataSource = null;
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
                txtBuyerName.Enabled = pEnable;               
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

                string strBuyerRk;
                string strBuyerName;
                string strAdd1;
                string strAdd2;
                string strState;
                string strCity;
                string strEmailId;
                string strContactPerson;
                string strGstin;
                int IsActive;
                string Remarks;
                string CreatedBy;
                string strReturn;
                
                BuyerManagement objBuyer = new BuyerManagement();

                strBuyerRk = cmbBuyer.SelectedValue.ToString();
                strBuyerName = txtBuyerName.Text.Trim();
                strAdd1 = txtAdd1.Text.Trim();
                strAdd2 = txtAdd2.Text.Trim();
                strEmailId = txtCity.Text.Trim();
                strState = txtState.Text.Trim();
                strCity = txtCity.Text.Trim();
                IsActive = Convert.ToInt16(cmbActive.SelectedValue.ToString());
                Remarks = rtxtRemarks.Text.Trim();
                CreatedBy = Global.gUserID;
                if (strBuyerRk == Global.gAddNew)
                {
                    
                    if (strBuyerName == "")
                    {
                        commonLib.showUIMessage("Enter buyer name!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    objBuyer.AddFlag = true;
                }
                else
                {
                    objBuyer.AddFlag = false;
                }


                //set DB Class Parameteres
                strBuyerRk = cmbBuyer.SelectedValue.ToString();
                strBuyerName = txtBuyerName.Text.Trim();
                strAdd1 = txtAdd1.Text.Trim();
                strAdd2 = txtAdd2.Text.Trim();
                strEmailId = txtCity.Text.Trim();
                strState = txtState.Text.Trim();
                strContactPerson = txtContactPerson.Text.Trim();
                strGstin = txtGstin.Text.Trim();
                IsActive = Convert.ToInt16(cmbActive.SelectedValue.ToString());
                Remarks = rtxtRemarks.Text.Trim();
                CreatedBy = Global.gUserID;

                objBuyer.BuyerRK = strBuyerRk;
                objBuyer.BuyerName= strBuyerName;
                objBuyer.Add1 = strAdd1;
                objBuyer.Add2= strAdd2;
                objBuyer.State = strState;
                objBuyer.City = strCity;
                objBuyer.ContactPerson = strContactPerson;
                objBuyer.Gstin = strGstin;
                objBuyer.EmailID = strEmailId;
                objBuyer.IsActive = IsActive;
                objBuyer.Remarks = Remarks;
                objBuyer.CreatedBy = CreatedBy;

                //Display Message
                strReturn = objBuyer.ManageBuyerDetails();
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

                UserManagment objUser = new UserManagment();

                UserID = txtBuyerName.Text.Trim();
                if (txtAdd1.Text.Trim() != "")
                    Password = commonLib.GetEncryptedPassword(txtAdd1.Text.Trim());
                CreatedBy = Global.gUserID;

            
                if (Password == "")
                {
                    commonLib.showUIMessage("Enter a valid password!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }



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

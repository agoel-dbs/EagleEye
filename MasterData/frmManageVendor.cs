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
    public partial class frmManageVendor : Form
    {

        Boolean bFormLoad = false;
        string strVendorRk = "";
        public frmManageVendor()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Manage Vendor");

        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmManageVendor_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
            bFormLoad = true;
        }

        private void LoadDropDownData()
        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                commonLib.PopulateVendorCombo(cmbVendor, "Y", "", "N");
                commonLib.PopulateParamMasterCombo(cmbActive, "N", " para_group = 'YES_NO' ", "N");

            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void cmbVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bFormLoad == false)
                    return;

                strVendorRk = cmbVendor.SelectedValue.ToString(); 

                if (strVendorRk == Global.gAddNew)
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
                VendorManagement objVendor = new VendorManagement();
                objVendor.VendorRK = strVendorRk;
                DT= objVendor.GetVendorDetails();
               

                if (DT.Rows.Count == 0)
                {
                    commonLib.showUIMessage("Vendor Information not found , reload the screen and try again !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                // enable active combo
                cmbActive.Enabled = true;

                // will return one row
                DataRow row = DT.Rows[0];
                
                txtVendorName.Text = row["Name"].ToString();
                txtAdd1.Text = row["Address1"].ToString(); 
                txtAdd2.Text = row["Address2"].ToString();
                txtState.Text = row["State"].ToString();
                txtCity.Text = row["City"].ToString();
                txtContactPerson.Text = row["ContactPerson"].ToString();
                txtEmailId.Text = row["EmailId"].ToString();
                txtGstin.Text = row["GSTIN"].ToString();

                cmbActive.SelectedValue = row["Active"].ToString();                    
                rtxtRemarks.Text = row["Remarks"].ToString();

               
                GridFunc.PopulateDataGrid(grdVendorDetails, DT);
               
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
                txtVendorName.Text = "";
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
                grdVendorDetails.DataSource = null;
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
                txtVendorName.Enabled = pEnable;               
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

                string strVendorRk;
                string strVendorName;
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
                
                VendorManagement objVendor = new VendorManagement();

                strVendorRk = cmbVendor.SelectedValue.ToString();
                strVendorName = txtVendorName.Text.Trim();
                strAdd1 = txtAdd1.Text.Trim();
                strAdd2 = txtAdd2.Text.Trim();
                strEmailId = txtCity.Text.Trim();
                strState = txtState.Text.Trim();
                strCity = txtCity.Text.Trim();
                IsActive = Convert.ToInt16(cmbActive.SelectedValue.ToString());
                Remarks = rtxtRemarks.Text.Trim();
                CreatedBy = Global.gUserID;
                if (strVendorRk == Global.gAddNew)
                {
                    
                    if (strVendorName == "")
                    {
                        commonLib.showUIMessage("Enter Vendor name!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    objVendor.AddFlag = true;
                }
                else
                {
                    objVendor.AddFlag = false;
                }


                //set DB Class Parameteres
                strVendorRk = cmbVendor.SelectedValue.ToString();
                strVendorName = txtVendorName.Text.Trim();
                strAdd1 = txtAdd1.Text.Trim();
                strAdd2 = txtAdd2.Text.Trim();
                strEmailId = txtCity.Text.Trim();
                strState = txtState.Text.Trim();
                strContactPerson = txtContactPerson.Text.Trim();
                strGstin = txtGstin.Text.Trim();
                IsActive = Convert.ToInt16(cmbActive.SelectedValue.ToString());
                Remarks = rtxtRemarks.Text.Trim();
                CreatedBy = Global.gUserID;

                objVendor.VendorRK = strVendorRk;
                objVendor.VendorName= strVendorName;
                objVendor.Add1 = strAdd1;
                objVendor.Add2= strAdd2;
                objVendor.State = strState;
                objVendor.City = strCity;
                objVendor.ContactPerson = strContactPerson;
                objVendor.Gstin = strGstin;
                objVendor.EmailID = strEmailId;
                objVendor.IsActive = IsActive;
                objVendor.Remarks = Remarks;
                objVendor.CreatedBy = CreatedBy;
                objVendor.bTransactionBound = false;

                //Display Message
                strReturn = objVendor.ManageVendorDetails();
                commonLib.ShowDBMessage(strReturn);

            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

      
    }
}

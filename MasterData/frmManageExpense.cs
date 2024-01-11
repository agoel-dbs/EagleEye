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

namespace EagleEye.MasterData
{
    public partial class frmManageExpense : Form
    {
        Boolean bFormLoad = false;
        string strExpenseRk = "";

        public frmManageExpense()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Manage Expense Head");

        }

        private void FrmManageExpense_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
            bFormLoad = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void LoadDropDownData()
        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                commonLib.PopulateExpenseHeadCombo (cmbExpense, "Y", "", "N");
                commonLib.PopulateParamMasterCombo(cmbActive, "N", " para_group = 'YES_NO' ", "N");

            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void CmbExpense_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bFormLoad == false)
                    return;

                strExpenseRk = cmbExpense.SelectedValue.ToString();

                if (strExpenseRk == Global.gAddNew)
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


        private void BlankControl()
        {
            try
            {
                txtExpenseID.Text = "";
                txtExpenseDesc.Text = "";
                rtxtRemarks.Text = "";
                cmbActive.SelectedValue = 1;
                cmbActive.Enabled = false;
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
                txtExpenseID.Enabled = pEnable;
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void LoadDetails()
        {
               try
                {
                    DataTable DT;
                    ExpenseMaster objExpense = new ExpenseMaster();
                    objExpense.ExpenseRK = strExpenseRk;
                    DT = objExpense.GetExpenseDetails();


                    if (DT.Rows.Count == 0)
                    {
                        commonLib.showUIMessage("Vendor Information not found , reload the screen and try again !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    // enable active combo
                    cmbActive.Enabled = true;

                    // will return one row
                    DataRow row = DT.Rows[0];

                    txtExpenseID.Text = row["ExpenseKey"].ToString();
                    txtExpenseDesc.Text = row["ExpenseDesc"].ToString();
                    cmbActive.SelectedValue = row["Active"].ToString();
                    rtxtRemarks.Text = row["Remarks"].ToString();
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
                string strExpenseKey;
                string strExpeDesc;
                int IsActive;
                string Remarks;
                string CreatedBy;
                string strReturn;

                ExpenseMaster objExpense= new ExpenseMaster();

                strExpenseRk = cmbExpense.SelectedValue.ToString();
                strExpenseKey = txtExpenseID.Text.Trim();
                strExpeDesc = txtExpenseDesc.Text.Trim();
                IsActive = Convert.ToInt16(cmbActive.SelectedValue.ToString());
                Remarks = rtxtRemarks.Text.Trim();
                CreatedBy = Global.gUserID;
                if (strExpenseRk== Global.gAddNew)
                {

                    if (strExpenseKey== "")
                    {
                        commonLib.showUIMessage("Enter unique Expense Key!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    if (strExpeDesc == "")
                    {
                        commonLib.showUIMessage("Enter Expense Description!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    objExpense.AddFlag = true;
                }
                else
                {
                    objExpense.AddFlag = false;
                }


                //set DB Class Parameteres
                IsActive = Convert.ToInt16(cmbActive.SelectedValue.ToString());
                Remarks = rtxtRemarks.Text.Trim();
                CreatedBy = Global.gUserID;

                objExpense.ExpenseRK= strExpenseRk;
                objExpense.ExpenseKey= strExpenseKey;
                objExpense.ExpenseDesc= strExpeDesc;
                objExpense.IsActive = IsActive;
                objExpense.Remarks = Remarks;
                objExpense.CreatedBy = CreatedBy;
                objExpense.DefaultValue= "0";
                objExpense.ExpImpact= "DR";
                objExpense.ExpGroup= "VENDOR_PAYMENT";
                objExpense.UserEditable= "N";
                //Display Message
                strReturn = objExpense.ManageExpenseDetails();
                commonLib.ShowDBMessage(strReturn);

            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

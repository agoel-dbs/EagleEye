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

namespace EagleEye.Operations
{
    public partial class frmManageParameters : Form
    {
        Boolean bFormLoad = false;
        string strParaGroup;
        public frmManageParameters()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Manage Parameter");
        }

        private void frmManageParameters_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
            bFormLoad = true;
        }
        private void LoadDropDownData()
        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "param_master";
                objCommonDBFunc.CodeColumnName = "para_group";
                objCommonDBFunc.DisplayColumnName = "para_group";
                objCommonDBFunc.ShowAddNew = "N";
                objCommonDBFunc.DataFilter = "";
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, cmbParameter, false);

               
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void cmbParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bFormLoad == false)
                    return;
                 if (cmbParameter.SelectedIndex == -1)
                    return;

                strParaGroup = cmbParameter.SelectedValue.ToString();
                LoadDetails();
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
                ParameterManagement objParameterManagement = new ParameterManagement();
                objParameterManagement.ParaGroup = strParaGroup;
                // parameter details
                DT = objParameterManagement.GetParameterDetails();
                
                //Convert bool type
                DataTable dtCloned = DT.Clone();
                dtCloned.Columns["Active"].DataType = typeof(bool);
                foreach (DataRow row in DT.Rows)
                    dtCloned.ImportRow(row);



                GridFunc.PopulateDataGrid(grdDetails, dtCloned);
                // set grid propoerties
                GridFunc.SetGridProperties(this.Name, grdDetails);
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

       

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(grdDetails.Rows.Count==0)
            {
                commonLib.showUIMessage("Kindly fetch data in Grid First!!! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ParameterManagement objParameterManagement = new ParameterManagement();
            string strMsg ="";
            try
            {
                for (int i = 0; i < grdDetails.Rows.Count; i++)
                {
                    string strCode;
                    string strName;
                    string strValue;
                    int iActive;
                    strCode = grdDetails.Rows[i].Cells[0].Value.ToString();
                    strName = grdDetails.Rows[i].Cells[1].Value.ToString();
                    strValue = grdDetails.Rows[i].Cells[2].Value.ToString();
                    iActive = Convert.ToInt32(grdDetails.Rows[i].Cells[3].Value);
                    objParameterManagement.ParaCode = strCode;
                    objParameterManagement.ParaName = strName;
                    objParameterManagement.ParaValue = strValue;
                    objParameterManagement.Active = iActive;
                    objParameterManagement.ParaGroup = strParaGroup;

                    strMsg += objParameterManagement.SetParameterDetails();                   


                }

                if(!strMsg.Contains("100~"))
                {
                    commonLib.showUIMessage("Parameter Information save sucessfully!!! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grdDetails.DataSource = null;
                    cmbParameter.SelectedIndex = -1;
                }
                else
                {
                    commonLib.showUIMessage("Error in Parameter Information save !!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
    }
}

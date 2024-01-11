using EagleEye.DBLayer;
using EagleEye.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EagleEye.Administration
{
    public partial class frmRoleMenuMap : Form
    {
        Boolean bFormLoad = false;
        string strRole;
        public frmRoleMenuMap()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Role Menu Map");
        }
        private void frmRoleMenuMap_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
            bFormLoad = true;
        }
        private void LoadDropDownData()
        {
            try
            {
                this.cmbRole.SelectedIndexChanged -= new System.EventHandler(this.cmbRole_SelectedIndexChanged);
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                DataTable DT;
                objCommonDBFunc.TableName = "role_master";
                objCommonDBFunc.CodeColumnName = "role_id";
                objCommonDBFunc.DisplayColumnName = "role_name";
                objCommonDBFunc.ShowAddNew = "N";
                objCommonDBFunc.DataFilter = "";
                DT = objCommonDBFunc.GetDropDownList();
                commonLib.PopulateCombo(DT, cmbRole, false);
                this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);

            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bFormLoad == false)
                    return;
                strRole = cmbRole.SelectedValue.ToString();
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


                RoleMenuMap objRoleMenuMap = new RoleMenuMap();
                objRoleMenuMap.RoleID = strRole;
                // parameter details
                DT = objRoleMenuMap.GetRoleDetails();

                //Convert bool type
                DataTable dtCloned = DT.Clone();                
                dtCloned.Columns["Visible"].DataType = typeof(bool);
                dtCloned.Columns["Editable"].DataType = typeof(bool);
                foreach (DataRow row in DT.Rows)
                    dtCloned.ImportRow(row);


                GridFunc.PopulateDataGrid(grdDetails, dtCloned);
                // set grid propoerties
                GridFunc.SetGridProperties(this.Name, grdDetails);
                if (grdDetails.Rows.Count > 0)
                {
                    btnSelectAll.Enabled = true;
                    btnUnCheckAll.Enabled = false;
                }
                   

            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grdDetails.Rows.Count == 0)
            {
                commonLib.showUIMessage("Kindly fetch data in Grid First!!! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RoleMenuMap objRoleMenuMap = new RoleMenuMap();
            string strMsg = "";
            try
            {
                for (int i = 0; i < grdDetails.Rows.Count; i++)
                {
                    int iVisible;
                    int iEditable;
                    string strName;
                    int iParentMenu;
                    string strParentId;
                    string strMenuId;
                    int iKey;

                    if (grdDetails.Rows[i].Cells[0].Value.ToString() != "")
                        iVisible = Convert.ToInt32(grdDetails.Rows[i].Cells[0].Value);
                    else
                        iVisible = 0;

                    if (grdDetails.Rows[i].Cells[1].Value.ToString() != "")
                        iEditable = Convert.ToInt32(grdDetails.Rows[i].Cells[1].Value);
                    else
                        iEditable = 0;

                    strMenuId = grdDetails.Rows[i].Cells[2].Value.ToString();
                    strName = grdDetails.Rows[i].Cells[3].Value.ToString();
                    if (grdDetails.Rows[i].Cells[4].Value.ToString() == "Yes")
                        iParentMenu = 1;
                    else
                        iParentMenu = 0;                    
                    strParentId = grdDetails.Rows[i].Cells[5].Value.ToString();
                    iKey = Convert.ToInt32(grdDetails.Rows[i].Cells[6].Value);


                    objRoleMenuMap.RoleID = strRole;
                    objRoleMenuMap.Visible = iVisible;
                    objRoleMenuMap.Editable = iEditable;
                    objRoleMenuMap.MenuId = strMenuId;
                    objRoleMenuMap.Name = strName;
                    objRoleMenuMap.ParentMenu = iParentMenu;
                    objRoleMenuMap.ParentMenuId = strParentId;
                    objRoleMenuMap.Key = iKey;
                    objRoleMenuMap.CreatedBy = Global.gUserID;


                    strMsg += objRoleMenuMap.SetRoleDetails();


                }

                if (!strMsg.Contains("100~"))
                {
                    commonLib.showUIMessage("Parameter Information save sucessfully!!! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grdDetails.DataSource = null;
                    //cmbParameter.SelectedIndex = -1;
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

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdDetails.RowCount; i++)
            {
                grdDetails.Rows[i].DataGridView[0, i].Value = true;
                grdDetails.Rows[i].DataGridView[1, i].Value = true;
            }
            btnUnCheckAll.Enabled = true;
            btnSelectAll.Enabled = false;
        }

        private void btnUnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdDetails.RowCount; i++)
            {
                grdDetails.Rows[i].DataGridView[0, i].Value = false;
                grdDetails.Rows[i].DataGridView[1, i].Value = false;
            }
            btnUnCheckAll.Enabled = false;
            btnSelectAll.Enabled = true;
        }
    }
}

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
using EagleEye.Administration;
using EagleEye.Operations;
using EagleEye.Mailing;
using EagleEye.Finance;
using EagleEye.Dashboard;
using EagleEye.About;
using EagleEye.MasterData;

namespace EagleEye
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void MnuRavaanaInvoice_Click(object sender, EventArgs e)
        {
            frmLoadRavaana frmRavanna = new frmLoadRavaana();
            frmRavanna.MdiParent = this;
            frmRavanna.WindowState = FormWindowState.Maximized;
            frmRavanna.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            EnableMenu();
        }

        private void EnableMenu()
        {
            try
            {

                DataTable DT = new DataTable();
                DataTable DTSub = new DataTable();

                RoleMenuManagment objRoleMenu = new RoleMenuManagment();
                // Main Menu enabling
                objRoleMenu.UserId = Global.gUserID;
                objRoleMenu.MenuLevel = 0;
                DT = objRoleMenu.GetMenuDetails();

                // disable Menus


                foreach (ToolStripMenuItem item in mnuMain.Items)
                {
                    item.Visible = false;
                    foreach (ToolStripItem subMenuItem in item.DropDownItems)
                    {
                        subMenuItem.Visible = false;
                    }
                };




                foreach (DataRow row in DT.Rows)
                {
                    string mnuName;
                    mnuName = row["menu_id"].ToString();
                    // enable Menu
                    foreach (ToolStripMenuItem item in mnuMain.Items)
                    {
                        if (mnuName.ToUpper().Trim() == item.Name.ToUpper().Trim())
                        {
                            item.Enabled = true;
                            item.Visible = true;
                            // Drawn Sub  Menu
                            objRoleMenu.UserId = Global.gUserID;
                            objRoleMenu.MenuLevel = 1;
                            objRoleMenu.ParentID = mnuName.Trim();
                            DTSub = objRoleMenu.GetSubMenuDetails();

                            foreach (DataRow row1 in DTSub.Rows)
                            {
                                string subMenuName;
                                subMenuName = row1["menu_id"].ToString();
                                // enable Menu
                                foreach (ToolStripItem subMenuItem in item.DropDownItems)
                                {
                                    if (subMenuName.ToUpper().Trim() == subMenuItem.Name.ToUpper())
                                    {
                                        subMenuItem.Visible = true;
                                        subMenuItem.Enabled = true;

                                    }
                                }
                            }
                        }
                    }

                }

                // Sub Menu enabling

                if (Global.gSpecialAdminPower == true)
                {
                    SpecialPowerMenuEnable(true);
                }
                else
                {
                    SpecialPowerMenuEnable(false);
                }

            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void SpecialPowerMenuEnable(bool pEnable)
        {
            mnuAdminActivity.Visible = pEnable;
            mnuInvoiceChanges.Visible = pEnable;
            mnuAdminActivity.Enabled = pEnable;
            mnuInvoiceChanges.Enabled = pEnable;
        }

        private void mnuUser_Click(object sender, EventArgs e)
        {
            frmManageUsers frmManageUsers = new frmManageUsers();
            frmManageUsers.MdiParent = this;
            //frmManageUsers.WindowState = FormWindowState.Maximized;
            frmManageUsers.Show();
        }

        private void MnuContactUs_Click(object sender, EventArgs e)
        {
            frmEmail frmEmail = new frmEmail();
            frmEmail.FormCaption = "Contact Us";
            frmEmail.MdiParent = this;
            frmEmail.WindowState = FormWindowState.Maximized;
            frmEmail.Show();
        }

        private void MnuPaymentReceived_Click(object sender, EventArgs e)
        {
            frmInwardRemmitance frmInward = new frmInwardRemmitance();
            frmInward.MdiParent = this;
            frmInward.WindowState = FormWindowState.Maximized;
            frmInward.Show();
        }

        private void mnuManageBuyer_Click(object sender, EventArgs e)
        {
            frmManageBuyer frmBuyer = new frmManageBuyer();
            frmBuyer.MdiParent = this;
            frmBuyer.WindowState = FormWindowState.Maximized;
            frmBuyer.Show();

        }

        private void mnuManageVendor_Click(object sender, EventArgs e)
        {
            //frmManageVendor frmVendor = new frmManageVendor();
            //frmVendor.MdiParent = this;
            //frmVendor.WindowState = FormWindowState.Maximized;
            //frmVendor.Show();
        }

        private void mnuParameters_Click(object sender, EventArgs e)
        {
            frmManageParameters frmParameter = new frmManageParameters();
            frmParameter.MdiParent = this;
            frmParameter.WindowState = FormWindowState.Maximized;
            frmParameter.Show();
        }

        private void MnuManageBuyer_Click_1(object sender, EventArgs e)
        {
            frmManageBuyer frmBuyer = new frmManageBuyer();
            frmBuyer.MdiParent = this;
            frmBuyer.WindowState = FormWindowState.Maximized;
            frmBuyer.Show();
        }

        private void MnuManageVendor_Click_1(object sender, EventArgs e)
        {
            frmManageVendor frmVendor = new frmManageVendor();
            frmVendor.MdiParent = this;
            frmVendor.WindowState = FormWindowState.Maximized;
            frmVendor.Show();
        }

        private void MnuPaymentReceived_Click_1(object sender, EventArgs e)
        {
            frmInwardRemmitance frmInward = new frmInwardRemmitance();
            frmInward.MdiParent = this;
            frmInward.WindowState = FormWindowState.Maximized;
            frmInward.Show();
        }

        private void MnuInvoiceCancel_Click(object sender, EventArgs e)
        {
            frmInvoiceCancellation frmInvoiceCancel = new frmInvoiceCancellation();
            frmInvoiceCancel.MdiParent = this;
            frmInvoiceCancel.WindowState = FormWindowState.Maximized;
            frmInvoiceCancel.Show();
        }

        private void MnuSupplierBill_Click(object sender, EventArgs e)
        {
            frmSupplierBill frmSupplierBill = new frmSupplierBill();
            frmSupplierBill.MdiParent = this;
            frmSupplierBill.WindowState = FormWindowState.Maximized;
            frmSupplierBill.Show();
        }

        private void MnuPaymentMade_Click(object sender, EventArgs e)
        {
            frmOutwordRemmitance frmOutward = new frmOutwordRemmitance();
            frmOutward.MdiParent = this;
            frmOutward.WindowState = FormWindowState.Maximized;
            frmOutward.Show();
        }

        private void MnuOtherInvoice_Click(object sender, EventArgs e)
        {
            frmInvoiceWR frmInvoiceWR = new frmInvoiceWR();
            frmInvoiceWR.MdiParent = this;
            frmInvoiceWR.WindowState = FormWindowState.Maximized;
            frmInvoiceWR.Show();
        }

        private void MnuChangePassword_Click(object sender, EventArgs e)
        {
            frmManagePassword frmManagePassword = new frmManagePassword();
            frmManagePassword.MdiParent = this;
            frmManagePassword.WindowState = FormWindowState.Maximized;
            frmManagePassword.Show();
        }

        private void MnuPartySaleReport_Click(object sender, EventArgs e)
        {
            frmPartywiseSaleReport frmPartySaleReport = new frmPartywiseSaleReport();
            frmPartySaleReport.MdiParent = this;
            frmPartySaleReport.WindowState = FormWindowState.Maximized;
            frmPartySaleReport.Show();
        }

        private void MnuPartyLedger_Click(object sender, EventArgs e)
        {
            frmPartyLedger frmPartyLedger = new frmPartyLedger();
            frmPartyLedger.MdiParent = this;
            frmPartyLedger.WindowState = FormWindowState.Maximized;
            frmPartyLedger.Show();

        }

        private void MnuVendorPurchaseReport_Click(object sender, EventArgs e)
        {
            frmVendorwiseExpenseReport frmVendorExpense = new frmVendorwiseExpenseReport();
            frmVendorExpense.MdiParent = this;
            frmVendorExpense.WindowState = FormWindowState.Maximized;
            frmVendorExpense.Show();
        }

        private void MnuVendorLedger_Click(object sender, EventArgs e)
        {

            frmVendorLedger frmVendorLedger = new frmVendorLedger();
            frmVendorLedger.MdiParent = this;
            frmVendorLedger.WindowState = FormWindowState.Maximized;
            frmVendorLedger.Show();
        }

        private void MnuCashLedger_Click(object sender, EventArgs e)
        {
            frmCashLedger frmCashLedger = new frmCashLedger();
            frmCashLedger.MdiParent = this;
            frmCashLedger.WindowState = FormWindowState.Maximized;
            frmCashLedger.Show();
        }

        private void MnuAdminActivity_Click(object sender, EventArgs e)
        {
            frmAdminTasks frmAdmin = new frmAdminTasks();
            frmAdmin.MdiParent = this;
            frmAdmin.WindowState = FormWindowState.Maximized;
            frmAdmin.Show();
        }

        private void mnuRoleMenuMap_Click(object sender, EventArgs e)
        {
            frmRoleMenuMap frmRoleMenu = new frmRoleMenuMap();
            frmRoleMenu.MdiParent = this;
            frmRoleMenu.WindowState = FormWindowState.Maximized;
            frmRoleMenu.Show();
        }

        private void MnuInvoiceChanges_Click(object sender, EventArgs e)
        {
            frmModifyInvoice frmInvModify = new frmModifyInvoice();
            frmInvModify.MdiParent = this;
            frmInvModify.WindowState = FormWindowState.Maximized;
            frmInvModify.Show();
        }
        private void mnuData_Click(object sender, EventArgs e)
        {
            frmManageData frmDataBaseBackup = new frmManageData();
            frmDataBaseBackup.MdiParent = this;
            frmDataBaseBackup.WindowState = FormWindowState.Maximized;
            frmDataBaseBackup.Show();
        }

        private void mnuLicenseDetails_Click(object sender, EventArgs e)
        {
            frmLicense objLicense = new frmLicense();
            objLicense.MdiParent = this;
            objLicense.WindowState = FormWindowState.Maximized;
            objLicense.Show();
        }

        private void MnuManageExpenseHead_Click(object sender, EventArgs e)
        {
            frmManageExpense objexpense = new frmManageExpense();
            objexpense.MdiParent = this;
            objexpense.WindowState = FormWindowState.Maximized;
            objexpense.Show();

        }

        private void MnuStockStatus_Click(object sender, EventArgs e)
        {
            frmStockStatusReport objStock = new frmStockStatusReport();
            objStock.MdiParent = this;
            objStock.WindowState = FormWindowState.Maximized;
            objStock.Show();
        }

        private void MnuStockVariance_Click(object sender, EventArgs e)
        {
            frmStockVariance objStockVar = new frmStockVariance ();
            objStockVar.MdiParent = this;
            objStockVar.WindowState = FormWindowState.Maximized;
            objStockVar.Show();

        }
    }
}

namespace EagleEye
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuParameterSep = new System.Windows.Forms.ToolStripSeparator();
            this.mnuParameters = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataSep = new System.Windows.Forms.ToolStripSeparator();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePasswordSep = new System.Windows.Forms.ToolStripSeparator();
            this.mnuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAdminActivity = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRoleMenuMap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasterData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageBuyer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuManageVendor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuManageExpenseHead = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRavaanaInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOtherInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuInvoiceCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSupplierBill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuInvoiceChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStockVariance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFinance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaymentReceived = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCompanyExpenseSep = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPaymentMade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDashBaord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPartySaleReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPartyLedger = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVendorPurchaseReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVendorLedger = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCashLedger = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStockStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContactUs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLicenseSep = new System.Windows.Forms.ToolStripSeparator();
            this.mnuLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin,
            this.mnuMasterData,
            this.mnuOperations,
            this.mnuFinance,
            this.mnuDashBaord,
            this.mnuAbout});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMain.Size = new System.Drawing.Size(1052, 33);
            this.mnuMain.TabIndex = 1;
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUser,
            this.mnuParameterSep,
            this.mnuParameters,
            this.mnuDataSep,
            this.mnuData,
            this.mnuChangePasswordSep,
            this.mnuChangePassword,
            this.toolStripMenuItem4,
            this.mnuAdminActivity,
            this.toolStripMenuItem5,
            this.mnuRoleMenuMap});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.ShowShortcutKeys = false;
            this.mnuAdmin.Size = new System.Drawing.Size(141, 29);
            this.mnuAdmin.Text = "Administration";
            // 
            // mnuUser
            // 
            this.mnuUser.Name = "mnuUser";
            this.mnuUser.Size = new System.Drawing.Size(252, 30);
            this.mnuUser.Text = "Manage Users";
            this.mnuUser.Click += new System.EventHandler(this.mnuUser_Click);
            // 
            // mnuParameterSep
            // 
            this.mnuParameterSep.Name = "mnuParameterSep";
            this.mnuParameterSep.Size = new System.Drawing.Size(249, 6);
            // 
            // mnuParameters
            // 
            this.mnuParameters.Name = "mnuParameters";
            this.mnuParameters.Size = new System.Drawing.Size(252, 30);
            this.mnuParameters.Text = "Manage Parameters";
            this.mnuParameters.Click += new System.EventHandler(this.mnuParameters_Click);
            // 
            // mnuDataSep
            // 
            this.mnuDataSep.Name = "mnuDataSep";
            this.mnuDataSep.Size = new System.Drawing.Size(249, 6);
            // 
            // mnuData
            // 
            this.mnuData.Name = "mnuData";
            this.mnuData.Size = new System.Drawing.Size(252, 30);
            this.mnuData.Text = "Manage Data";
            this.mnuData.Click += new System.EventHandler(this.mnuData_Click);
            // 
            // mnuChangePasswordSep
            // 
            this.mnuChangePasswordSep.Name = "mnuChangePasswordSep";
            this.mnuChangePasswordSep.Size = new System.Drawing.Size(249, 6);
            // 
            // mnuChangePassword
            // 
            this.mnuChangePassword.Name = "mnuChangePassword";
            this.mnuChangePassword.Size = new System.Drawing.Size(252, 30);
            this.mnuChangePassword.Text = "Change Password";
            this.mnuChangePassword.Click += new System.EventHandler(this.MnuChangePassword_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(249, 6);
            // 
            // mnuAdminActivity
            // 
            this.mnuAdminActivity.Name = "mnuAdminActivity";
            this.mnuAdminActivity.ShowShortcutKeys = false;
            this.mnuAdminActivity.Size = new System.Drawing.Size(252, 30);
            this.mnuAdminActivity.Text = "Admin Activities";
            this.mnuAdminActivity.Click += new System.EventHandler(this.MnuAdminActivity_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(249, 6);
            // 
            // mnuRoleMenuMap
            // 
            this.mnuRoleMenuMap.Name = "mnuRoleMenuMap";
            this.mnuRoleMenuMap.Size = new System.Drawing.Size(252, 30);
            this.mnuRoleMenuMap.Text = "Role Menu Access";
            this.mnuRoleMenuMap.Click += new System.EventHandler(this.mnuRoleMenuMap_Click);
            // 
            // mnuMasterData
            // 
            this.mnuMasterData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManageBuyer,
            this.toolStripMenuItem6,
            this.mnuManageVendor,
            this.toolStripMenuItem7,
            this.mnuManageExpenseHead});
            this.mnuMasterData.Name = "mnuMasterData";
            this.mnuMasterData.Size = new System.Drawing.Size(120, 29);
            this.mnuMasterData.Text = "Master Data";
            // 
            // mnuManageBuyer
            // 
            this.mnuManageBuyer.Name = "mnuManageBuyer";
            this.mnuManageBuyer.Size = new System.Drawing.Size(276, 30);
            this.mnuManageBuyer.Text = "Manage Buyer";
            this.mnuManageBuyer.Click += new System.EventHandler(this.MnuManageBuyer_Click_1);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(273, 6);
            // 
            // mnuManageVendor
            // 
            this.mnuManageVendor.Name = "mnuManageVendor";
            this.mnuManageVendor.Size = new System.Drawing.Size(276, 30);
            this.mnuManageVendor.Text = "Manage Vendor";
            this.mnuManageVendor.Click += new System.EventHandler(this.MnuManageVendor_Click_1);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(273, 6);
            // 
            // mnuManageExpenseHead
            // 
            this.mnuManageExpenseHead.Name = "mnuManageExpenseHead";
            this.mnuManageExpenseHead.Size = new System.Drawing.Size(276, 30);
            this.mnuManageExpenseHead.Text = "Manage Expense Head";
            this.mnuManageExpenseHead.Click += new System.EventHandler(this.MnuManageExpenseHead_Click);
            // 
            // mnuOperations
            // 
            this.mnuOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRavaanaInvoice,
            this.invoiceToolStripMenuItem,
            this.mnuOtherInvoice,
            this.toolStripMenuItem2,
            this.mnuInvoiceCancel,
            this.toolStripMenuItem1,
            this.mnuSupplierBill,
            this.toolStripMenuItem3,
            this.mnuInvoiceChanges,
            this.mnuStockVariance});
            this.mnuOperations.Name = "mnuOperations";
            this.mnuOperations.Size = new System.Drawing.Size(112, 29);
            this.mnuOperations.Text = "Operations";
            // 
            // mnuRavaanaInvoice
            // 
            this.mnuRavaanaInvoice.Name = "mnuRavaanaInvoice";
            this.mnuRavaanaInvoice.Size = new System.Drawing.Size(252, 30);
            this.mnuRavaanaInvoice.Text = "E-Ravaana Invoice";
            this.mnuRavaanaInvoice.Click += new System.EventHandler(this.MnuRavaanaInvoice_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(249, 6);
            // 
            // mnuOtherInvoice
            // 
            this.mnuOtherInvoice.Name = "mnuOtherInvoice";
            this.mnuOtherInvoice.Size = new System.Drawing.Size(252, 30);
            this.mnuOtherInvoice.Text = "Other Invoice";
            this.mnuOtherInvoice.Click += new System.EventHandler(this.MnuOtherInvoice_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(249, 6);
            // 
            // mnuInvoiceCancel
            // 
            this.mnuInvoiceCancel.Name = "mnuInvoiceCancel";
            this.mnuInvoiceCancel.Size = new System.Drawing.Size(252, 30);
            this.mnuInvoiceCancel.Text = "Invoice Cancellation";
            this.mnuInvoiceCancel.Click += new System.EventHandler(this.MnuInvoiceCancel_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(249, 6);
            // 
            // mnuSupplierBill
            // 
            this.mnuSupplierBill.Name = "mnuSupplierBill";
            this.mnuSupplierBill.Size = new System.Drawing.Size(252, 30);
            this.mnuSupplierBill.Text = "Supplier Bill Entry";
            this.mnuSupplierBill.Click += new System.EventHandler(this.MnuSupplierBill_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(249, 6);
            // 
            // mnuInvoiceChanges
            // 
            this.mnuInvoiceChanges.Name = "mnuInvoiceChanges";
            this.mnuInvoiceChanges.Size = new System.Drawing.Size(252, 30);
            this.mnuInvoiceChanges.Text = "Invoice Changes";
            this.mnuInvoiceChanges.Click += new System.EventHandler(this.MnuInvoiceChanges_Click);
            // 
            // mnuStockVariance
            // 
            this.mnuStockVariance.Name = "mnuStockVariance";
            this.mnuStockVariance.Size = new System.Drawing.Size(252, 30);
            this.mnuStockVariance.Text = "Stock Variance";
            this.mnuStockVariance.Click += new System.EventHandler(this.MnuStockVariance_Click);
            // 
            // mnuFinance
            // 
            this.mnuFinance.Checked = true;
            this.mnuFinance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuFinance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPaymentReceived,
            this.mnuCompanyExpenseSep,
            this.mnuPaymentMade});
            this.mnuFinance.Name = "mnuFinance";
            this.mnuFinance.Size = new System.Drawing.Size(83, 29);
            this.mnuFinance.Text = "Finance";
            // 
            // mnuPaymentReceived
            // 
            this.mnuPaymentReceived.Name = "mnuPaymentReceived";
            this.mnuPaymentReceived.Size = new System.Drawing.Size(252, 30);
            this.mnuPaymentReceived.Text = "Payment Received";
            this.mnuPaymentReceived.Click += new System.EventHandler(this.MnuPaymentReceived_Click_1);
            // 
            // mnuCompanyExpenseSep
            // 
            this.mnuCompanyExpenseSep.Name = "mnuCompanyExpenseSep";
            this.mnuCompanyExpenseSep.Size = new System.Drawing.Size(249, 6);
            // 
            // mnuPaymentMade
            // 
            this.mnuPaymentMade.Name = "mnuPaymentMade";
            this.mnuPaymentMade.Size = new System.Drawing.Size(252, 30);
            this.mnuPaymentMade.Text = "Company Expenses";
            this.mnuPaymentMade.Click += new System.EventHandler(this.MnuPaymentMade_Click);
            // 
            // mnuDashBaord
            // 
            this.mnuDashBaord.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPartySaleReport,
            this.mnuPartyLedger,
            this.mnuVendorPurchaseReport,
            this.mnuVendorLedger,
            this.mnuCashLedger,
            this.mnuStockStatus});
            this.mnuDashBaord.Name = "mnuDashBaord";
            this.mnuDashBaord.Size = new System.Drawing.Size(112, 29);
            this.mnuDashBaord.Text = "Dashboard";
            // 
            // mnuPartySaleReport
            // 
            this.mnuPartySaleReport.Name = "mnuPartySaleReport";
            this.mnuPartySaleReport.Size = new System.Drawing.Size(286, 30);
            this.mnuPartySaleReport.Text = "Party Sale Report";
            this.mnuPartySaleReport.Click += new System.EventHandler(this.MnuPartySaleReport_Click);
            // 
            // mnuPartyLedger
            // 
            this.mnuPartyLedger.Name = "mnuPartyLedger";
            this.mnuPartyLedger.Size = new System.Drawing.Size(286, 30);
            this.mnuPartyLedger.Text = "Party Ledger Report";
            this.mnuPartyLedger.Click += new System.EventHandler(this.MnuPartyLedger_Click);
            // 
            // mnuVendorPurchaseReport
            // 
            this.mnuVendorPurchaseReport.Name = "mnuVendorPurchaseReport";
            this.mnuVendorPurchaseReport.Size = new System.Drawing.Size(286, 30);
            this.mnuVendorPurchaseReport.Text = "Vendor Purchase Report";
            this.mnuVendorPurchaseReport.Click += new System.EventHandler(this.MnuVendorPurchaseReport_Click);
            // 
            // mnuVendorLedger
            // 
            this.mnuVendorLedger.Name = "mnuVendorLedger";
            this.mnuVendorLedger.Size = new System.Drawing.Size(286, 30);
            this.mnuVendorLedger.Text = "Vendor Ledger Report";
            this.mnuVendorLedger.Click += new System.EventHandler(this.MnuVendorLedger_Click);
            // 
            // mnuCashLedger
            // 
            this.mnuCashLedger.Name = "mnuCashLedger";
            this.mnuCashLedger.Size = new System.Drawing.Size(286, 30);
            this.mnuCashLedger.Text = "Company Cash Ledger";
            this.mnuCashLedger.Click += new System.EventHandler(this.MnuCashLedger_Click);
            // 
            // mnuStockStatus
            // 
            this.mnuStockStatus.Name = "mnuStockStatus";
            this.mnuStockStatus.Size = new System.Drawing.Size(286, 30);
            this.mnuStockStatus.Text = "Stock Status Report";
            this.mnuStockStatus.Click += new System.EventHandler(this.MnuStockStatus_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContactUs,
            this.mnuLicenseSep,
            this.mnuLicenseDetails});
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(74, 29);
            this.mnuAbout.Text = "About";
            // 
            // mnuContactUs
            // 
            this.mnuContactUs.Enabled = false;
            this.mnuContactUs.Name = "mnuContactUs";
            this.mnuContactUs.Size = new System.Drawing.Size(210, 30);
            this.mnuContactUs.Text = "Contact Us";
            this.mnuContactUs.Click += new System.EventHandler(this.MnuContactUs_Click);
            // 
            // mnuLicenseSep
            // 
            this.mnuLicenseSep.Name = "mnuLicenseSep";
            this.mnuLicenseSep.Size = new System.Drawing.Size(207, 6);
            // 
            // mnuLicenseDetails
            // 
            this.mnuLicenseDetails.Enabled = false;
            this.mnuLicenseDetails.Name = "mnuLicenseDetails";
            this.mnuLicenseDetails.Size = new System.Drawing.Size(210, 30);
            this.mnuLicenseDetails.Text = "License Details";
            this.mnuLicenseDetails.Click += new System.EventHandler(this.mnuLicenseDetails_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 702);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "Eagle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuUser;
        private System.Windows.Forms.ToolStripSeparator mnuParameterSep;
        private System.Windows.Forms.ToolStripMenuItem mnuParameters;
        private System.Windows.Forms.ToolStripSeparator mnuDataSep;
        private System.Windows.Forms.ToolStripMenuItem mnuData;
        private System.Windows.Forms.ToolStripSeparator mnuChangePasswordSep;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePassword;
        private System.Windows.Forms.ToolStripMenuItem mnuOperations;
        private System.Windows.Forms.ToolStripMenuItem mnuRavaanaInvoice;
        private System.Windows.Forms.ToolStripSeparator invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOtherInvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuDashBaord;
        private System.Windows.Forms.ToolStripMenuItem mnuPartySaleReport;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuLicenseDetails;
        private System.Windows.Forms.ToolStripSeparator mnuLicenseSep;
        private System.Windows.Forms.ToolStripMenuItem mnuContactUs;
        private System.Windows.Forms.ToolStripMenuItem mnuMasterData;
        private System.Windows.Forms.ToolStripMenuItem mnuManageBuyer;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem mnuManageVendor;
        private System.Windows.Forms.ToolStripMenuItem mnuFinance;
        private System.Windows.Forms.ToolStripMenuItem mnuPaymentReceived;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuInvoiceCancel;
        private System.Windows.Forms.ToolStripSeparator mnuCompanyExpenseSep;
        private System.Windows.Forms.ToolStripMenuItem mnuPaymentMade;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSupplierBill;
        private System.Windows.Forms.ToolStripMenuItem mnuPartyLedger;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuVendorPurchaseReport;
        private System.Windows.Forms.ToolStripMenuItem mnuVendorLedger;
        private System.Windows.Forms.ToolStripMenuItem mnuCashLedger;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuAdminActivity;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnuRoleMenuMap;
        private System.Windows.Forms.ToolStripMenuItem mnuInvoiceChanges;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem mnuManageExpenseHead;
        private System.Windows.Forms.ToolStripMenuItem mnuStockStatus;
        private System.Windows.Forms.ToolStripMenuItem mnuStockVariance;
    }
}
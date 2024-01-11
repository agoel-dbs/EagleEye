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

namespace EagleEye.Dashboard
{
    public partial class frmVendorLedger : Form
    {
        bool bFormload = false; 
        public frmVendorLedger()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Vendor Ledger");
        }

        private void FrmVendorLedger_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
            bFormload = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            GenerateReportData();
        }

        private void GenerateReportData()
        {
            try
            {
                DashboardRep objDB = new DashboardRep();

                objDB.VendorRk = commonLib.fnCheckNull(commonLib.GetComboSelectedValue(cmbVendor).ToString());
                objDB.FromDate = commonLib.ReportingDateStringHHMMSS(dtFromDate);
                objDB.ToDate = commonLib.ReportingDateStringHHMMSS(dtToDate);


                // Outstanding Balance
                string[] AggregateColumn = { "LedgerBalance" };
                GridFunc.PopulateDataGrid(grdReportAgg, commonLib.AddSummaryColumnDataTable(AggregateColumn, objDB.GetVendorOutstandingBalance()));

                // LedgerHistory
                string[] AggregateColumn1 = { "TransactionAmount" };
                GridFunc.PopulateDataGrid(grdReportDetails, commonLib.AddSummaryColumnDataTable(AggregateColumn1, objDB.GetVendorLedgerHistoryNew()));
                //GridFunc.PopulateDataGrid(grdReportDetails, objDB.GetVendorLedgerHistory());
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

        private void CmbBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bFormload == false)
                return;
            GenerateReportData();
        }


        private void LoadDropDownData()
        {
            try
            {

                commonLib.PopulateVendorCombo(cmbVendor, "N", "", "Y");
                cmbVendor.SelectedIndex = 0;
                commonLib.SetCustomDateFormat(dtFromDate);
                commonLib.SetCustomDateFormat(dtToDate);
                dtToDate.Value = DateTime.Now;
                dtFromDate.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void BtnExcelExport_Click(object sender, EventArgs e)
        {
            try
            {

                string strReportHeader;
                GridFunc objGrid = new GridFunc();

                //Aggregate Report

                strReportHeader = commonLib.fnCheckNull1(commonLib.GetComboSelectedText(cmbVendor).ToString()) +  
                                " - Account Status as-on Date " + DateTime.Now.ToString("dd-MMM-yyyy");

                objGrid.ExcelFileName = "Vendor Account Status.xls";
                objGrid.WorkSheetName = "Vendor Account Status";
                objGrid.ReportHeader = strReportHeader;
                objGrid.ExportToExcel(grdReportDetails, "");

                strReportHeader = "Vendor Ledger Report for - " +
                                   commonLib.fnCheckNull1(commonLib.GetComboSelectedText(cmbVendor).ToString()) +
                                   " From " + dtFromDate.Value.ToString("dd-MMM-yyyy") +
                                    " To " + dtToDate.Value.ToString("dd-MMM-yyyy");

                objGrid.ExcelFileName = "Vendor Ledger Report.xls";
                objGrid.WorkSheetName = "Vendor Ledger Report";
                objGrid.ReportHeader = strReportHeader;
                objGrid.ExportToExcel(grdReportDetails, "");

                commonLib.showUIMessage("Report saved sucessfully !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }

}

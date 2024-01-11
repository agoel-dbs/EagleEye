using EagleEye.DBLayer;
using EagleEye.Lib;
using System;
using System.Windows.Forms;

namespace EagleEye.Dashboard
{
    public partial class frmPartyLedger : Form
    {
        public frmPartyLedger()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Party Ledger");
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

                objDB.BuyerRk = commonLib.fnCheckNull(commonLib.GetComboSelectedValue(cmbBuyer).ToString());
                objDB.FromDate = commonLib.ReportingDateStringHHMMSS(dtFromDate);
                objDB.ToDate = commonLib.ReportingDateStringHHMMSS(dtToDate);

                if (chkIncludeSale.Checked == false)
                { objDB.IncludeSaleforSelectedPeriod = "N"; }
                else { objDB.IncludeSaleforSelectedPeriod = "Y"; }

                string[] AggregateColumn = { "LedgerBalance"};

                string[] AggregateColumn1 = { "Qty", "Loading", "Tax", "Cheque","Cash"};

                // Outstanding Balance

                GridFunc.PopulateDataGrid(grdReportAgg, commonLib.AddSummaryColumnDataTable(AggregateColumn, objDB.GetCustomerOutstandingBalance()));

                // outstanding balance Date Range

                GridFunc.PopulateDataGrid(grdReportAggtillDate, commonLib.AddSummaryColumnDataTable(AggregateColumn, objDB.GetCustomerOutstandingBalanceDateRange()));

                // LedgerHistory
                //GridFunc.PopulateDataGrid(grdReportDetails, objDB.GetCustomerLedgerHistoryNew());

                GridFunc.PopulateDataGrid(grdReportDetails, commonLib.AddSummaryColumnDataTable(AggregateColumn1, objDB.GetCustomerLedgerHistoryNew()));

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

        private void FrmPartyLedger_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
        }

        private void LoadDropDownData()
        {
            try
            {

                commonLib.PopulateBuyerCombo(cmbBuyer, "N", "", "Y");
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

        private void CmbBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateReportData();
        }

        private void BtnExcelExport_Click(object sender, EventArgs e)
        {
            try
            {

                string strReportHeader;
                string strPartyName;
                GridFunc objGrid = new GridFunc();

                strPartyName = commonLib.fnCheckNull1(commonLib.GetComboSelectedText(cmbBuyer).ToString());
                strReportHeader = "Party Ledger Report for - " +
                                   strPartyName +
                                   " From " + dtFromDate.Value.ToString("dd-MMM-yyyy") +
                                    " To " + dtToDate.Value.ToString("dd-MMM-yyyy");

                objGrid.ExcelFileName = strPartyName  + " Ledger.xls";
                objGrid.WorkSheetName = "Party Report";
                objGrid.ReportHeader = strReportHeader;
                objGrid.ExportToExcel(grdReportDetails, "");
                commonLib.showUIMessage("Report saved sucessfully !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnExportSummary_Click(object sender, EventArgs e)
        {
            try
            {

                string strReportHeader;
                string strPartyName;
                GridFunc objGrid = new GridFunc();
                strPartyName = commonLib.fnCheckNull1(commonLib.GetComboSelectedText(cmbBuyer).ToString());
                strReportHeader = commonLib.fnCheckNull1(commonLib.GetComboSelectedText(cmbBuyer).ToString()) +
                                " - Account Status as-on Date " + DateTime.Now.ToString("dd-MMM-yyyy");
                objGrid.ExcelFileName = strPartyName + " Status.xls";
                objGrid.WorkSheetName = "Party Account Status";
                objGrid.ReportHeader = strReportHeader;
                objGrid.ExportToExcel(grdReportAgg, "");

            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnUpdatePartyLedger_Click(object sender, EventArgs e)
        {
            try
            {
                string strResult;
                DashboardRep objDB = new DashboardRep();
                strResult = objDB.ComputePartyLedger();
                commonLib.showUIMessage(strResult, MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

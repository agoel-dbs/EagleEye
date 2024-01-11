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
    public partial class frmStockStatusReport : Form
    {
        public frmStockStatusReport()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Stock Status Report");

        }

        private void FrmStockStatusReport_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
        }

        private void LoadDropDownData()
        {
            try
            {

                commonLib.PopulateSaleItemCombo(cmbStock, "N", "", "Y");
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void PopulateData()
        {

            try
            {
                //Dashboard objDashBoard = new Dashboard();
                DashboardRep objDB = new DashboardRep();
                objDB.ItemRk = commonLib.fnCheckNull(commonLib.GetComboSelectedValue(cmbStock).ToString());
                objDB.FromDate = commonLib.ReportingDateStringHHMMSS(dtFromDate);
                objDB.ToDate = commonLib.ReportingDateStringHHMMSS(dtToDate);
                string[] AggregateColumn = { "Quantity", "Amount" };
                GridFunc.PopulateDataGrid(grdReportDetails, commonLib.AddSummaryColumnDataTable(AggregateColumn, objDB.StockStatus()));

                // Stock in Hand
                string[] AggregateColumn1 = { "PurchaseQty", "PurchaseAmount", "StockInHand", "StockValuation" };
                GridFunc.PopulateDataGrid(grdAggDetails, commonLib.AddSummaryColumnDataTable(AggregateColumn1, objDB.StockInHand())); 

                //Monthly Purchase Avarage of selected period
                GridFunc.PopulateDataGrid(grdMonthlyAverage, objDB.AveragePurchase());

                //Monthly Sale Avarage of selected period   
                GridFunc.PopulateDataGrid(grdMonthlySaleAvg, objDB.AverageSale());

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

        private void BtnExcelExport_Click(object sender, EventArgs e)
        {
            try
            {

                string strReportHeader;

                strReportHeader = " Report for - " +
                                   commonLib.fnCheckNull1(commonLib.GetComboSelectedText(cmbStock).ToString()) +
                                   " From " + dtFromDate.Value.ToString("dd-MMM-yyyy") +
                                    " To " + dtToDate.Value.ToString("dd-MMM-yyyy");

                GridFunc objGrid = new GridFunc();
                objGrid.ExcelFileName = "Stock Status Report.xls";
                objGrid.WorkSheetName = "Stock Report";
                objGrid.ReportHeader = strReportHeader;
                objGrid.ExportToExcel(grdReportDetails, "");
                commonLib.showUIMessage("Report saved sucessfully !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnComputeStock_Click(object sender, EventArgs e)
        {
            try
            {
                string strResult;
                //Dashboard objDashBoard = new Dashboard();
                DashboardRep objDB = new DashboardRep();
                strResult = objDB.ComputeStock();
                commonLib.showUIMessage(strResult, MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Stock in Hand
                PopulateData();

            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

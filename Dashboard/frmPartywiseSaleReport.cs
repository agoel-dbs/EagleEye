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
    public partial class frmPartywiseSaleReport : Form
    {
        public frmPartywiseSaleReport()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Sale Report");
        }

        private void FrmPartywiseSaleReport_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
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
                objDB.BuyerRk = commonLib.fnCheckNull(commonLib.GetComboSelectedValue(cmbBuyer).ToString());
                objDB.SaleType= commonLib.GetComboSelectedValue(cmbSaleType).ToString();
                objDB.InvoiceType= commonLib.GetComboSelectedValue(cmbInvoiceType).ToString();
                objDB.FromDate = commonLib.ReportingDateStringHHMMSS(dtFromDate);
                objDB.ToDate = commonLib.ReportingDateStringHHMMSS(dtToDate);

                if (chkShortReport.Checked == true)
                {
                    string[] AggregateColumn = { "Qty", "Tax", "TaxInvoiceAmount","LoadingCharges", "TotalPayableAmount", "ChequeAmount", "CashAmount"};
                    GridFunc.PopulateDataGrid(grdReportDetails, commonLib.AddSummaryColumnDataTable(AggregateColumn, objDB.GetPartyWiseSaleReportShort()));
                }
                else
                {
                    string[] AggregateColumn = { "ActualQty", "CGSTAmount", "SGSTAmount", "IGSTAmount", "TaxAmount", "LoadingCharges", "TotalPayableAmount", "AmountReceived", "Commission", "TaxInvoiceAmount" };
                    GridFunc.PopulateDataGrid(grdReportDetails, commonLib.AddSummaryColumnDataTable(AggregateColumn, objDB.GetPartyWiseSaleReport()));
                }
                string[] AggregateColumn1 = { "Tax", "SaleQty", "SaleAmount", "Collection", "SaleCount","Commission","LoadingCharges"};
                GridFunc.PopulateDataGrid(grdAggDetails, commonLib.AddSummaryColumnDataTable(AggregateColumn1, objDB.GetAggregatedSaleReport()));




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

        private void LoadDropDownData()
        {
            try
            {
                
                commonLib.PopulateBuyerCombo(cmbBuyer, "N", "", "Y",true);
                commonLib.PopulateParamMasterCombo(cmbSaleType, "N", " para_group = 'SALE_TYPE' ","Y",true);
                commonLib.PopulateParamMasterCombo(cmbInvoiceType, "N", " para_group = 'INVOICE_TYPE' ", "Y", true);


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

                strReportHeader = commonLib.GetComboSelectedText(cmbSaleType).ToString() + " Report for - " +
                                   commonLib.fnCheckNull1(commonLib.GetComboSelectedText(cmbBuyer).ToString() )+
                                   " From " + dtFromDate.Value.ToString("dd-MMM-yyyy") +
                                    " To " + dtToDate.Value.ToString("dd-MMM-yyyy");

                GridFunc objGrid = new GridFunc();
                objGrid.ExcelFileName = "Party-wise Sale Report.xls";
                objGrid.WorkSheetName = "Sale Report";
                objGrid.ReportHeader = strReportHeader;
                objGrid.ExportToExcel(grdReportDetails, "BillTo");
                commonLib.showUIMessage("Report saved sucessfully !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

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
    public partial class frmVendorwiseExpenseReport : Form
    {
        public frmVendorwiseExpenseReport()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Purchase Report");
        }

        private void FrmVendorwiseExpenseReport_Load(object sender, EventArgs e)
        {
            LoadDropDownData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Dashboard objDashBoard = new Dashboard();
            DashboardRep objDB = new DashboardRep();
            objDB.VendorRk = commonLib.fnCheckNull(commonLib.GetComboSelectedValue(cmbVendor).ToString());
            objDB.FromDate = commonLib.ReportingDateStringHHMMSS(dtFromDate);
            objDB.ToDate = commonLib.ReportingDateStringHHMMSS(dtToDate);
            string[] AggregateColumn = { "TotalAmount" };
            GridFunc.PopulateDataGrid(grdReportDetails, commonLib.AddSummaryColumnDataTable(AggregateColumn, objDB.GetSupplierBillHistory(),1));
        }

        private void BtnExcelExport_Click(object sender, EventArgs e)
        {
            try
            {

                string strReportHeader;

                strReportHeader = "Purchase / Expense Report for - " +
                                   commonLib.fnCheckNull1(commonLib.GetComboSelectedText(cmbVendor).ToString()) +
                                   " From " + dtFromDate.Value.ToString("dd-MMM-yyyy") +
                                    " To " + dtToDate.Value.ToString("dd-MMM-yyyy");

                GridFunc objGrid = new GridFunc();
                objGrid.ExcelFileName = "Vendor-wise Purchase Report.xls";
                objGrid.WorkSheetName = "Purchase Report";
                objGrid.ReportHeader = strReportHeader;
                objGrid.ExportToExcel(grdReportDetails,"");
                commonLib.showUIMessage("Report saved sucessfully !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

                commonLib.PopulateVendorCombo(cmbVendor, "N", "", "Y");
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

    }
}

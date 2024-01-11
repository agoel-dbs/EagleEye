using EagleEye.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace EagleEye.Lib
{
    class GridFunc
    {

        public string ExcelFileName { get; set; } = "Report.xls";
        public string WorkSheetName { get; set; } = "Report";

        public string ReportHeader{ get; set; } = "";

        

        static public  void GridAutosize(DataGridView pGrd)
        {
            int i;

            for (i = 0; i < pGrd.Columns.Count; i++)
            {
                pGrd.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }            

        }

        static public void PopulateDataGrid(DataGridView pdg, DataTable pSource)
        {
            try
            {
                var source = new BindingSource(pSource, null);
                pdg.DataSource = source;
                SetGridProperties(pdg);
            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        static public void SetGridProperties(DataGridView pdg)
        {
            try
            {
                GridAutosize(pdg);
                pdg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                //if (pEditable == false)
                //{
                //    pdg.EditMode = DataGridViewEditMode.EditProgrammatically;
                //}
            }
            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        static public void PopulateDataGrid(DataGridView pdg, List<RavanaaData> pSource, Boolean pEditable)
        {
            try
            {
                var source = new BindingSource(pSource, null);
                pdg.DataSource = source;
                SetGridProperties(pdg);
            }

            catch (Exception ex)
            {
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        static public void HideGridColumn(string pFormName, DataGridView pdg)
        {
            try
            {
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();
                DataTable DT = new DataTable();
                objCommonDBFunc.InterfaceName = pFormName;
                objCommonDBFunc.GridName = pdg.Name;
                DT = objCommonDBFunc.GetGridHiddenColumn();
                
                foreach (DataRow row in DT.Rows)
                {
                    pdg.Columns[row["column_name"].ToString()].Visible = false;
                }
            }
            catch (Exception e)
            {

            }
        }


        static public void SetGridProperties(string pFormName, DataGridView pdg)
        {
            try
            {
                DataTable DT = new DataTable();
                CommonDBFunc objCommonDBFunc = new CommonDBFunc();

                objCommonDBFunc.InterfaceName = pFormName;
                objCommonDBFunc.GridName = pdg.Name;
                DT = objCommonDBFunc.GetGridProperties();
               
                string ColName;
                foreach (DataRow row in DT.Rows)
                {
                    // make column visible  = false
                    ColName = row["column_name"].ToString();
                    if (row["is_visible"].ToString() == "0")
                    {
                        pdg.Columns[ColName].Visible = false;
                    }
                    // make editable
                    if (row["is_editable"].ToString() == "1")
                    {
                        pdg.Columns[ColName].ReadOnly= false;
                        // change row color
                        pdg.Columns[ColName].DefaultCellStyle.BackColor = Color.LimeGreen;
                        pdg.EnableHeadersVisualStyles = false;
                        pdg.Columns[ColName].HeaderCell.Style.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        pdg.Columns[ColName].ReadOnly = true;
                    }
                }
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }



        static public int FindGridRowIndex(DataGridView pdg, int pColIndex, string pSearchVal)
        {
            try
            {
                int i;
                string strValue;
                
                for  (i = 0; i< pdg.Rows.Count; i++)
                {
                    strValue = pdg.Rows[i].Cells[pColIndex].Value.ToString();

                    if (strValue == pSearchVal)
                    {
                        return i;
                    }

                }

                return -1;
            }
            catch (Exception ex)
            {
                return -99;
            }
        }


        static public int FindGridColumnIndex(DataGridView pdg, string pSearchVal)
        {
            try
            {
                int i =0;

                foreach (DataGridViewColumn column in pdg.Columns)
                {
                    if (commonLib.fnCheckNull1(column.HeaderText.ToUpper()) == commonLib.fnCheckNull1(pSearchVal.ToUpper()) )
                    {
                        return i;
                    }
                    i++;
                }

                return -1;
            }
            catch (Exception ex)
            {
                return -99;
            }


        }

        public void ExportToExcel(DataGridView objDGV , string strHiddenColList)
        {
            try
            {
                string strdateColumnIndex = "";
                string strsep = "~*~";
                
                if (objDGV == null || objDGV.Rows.Count == 0)
                {
                    commonLib.showUIMessage("Nothing to export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = ExcelFileName;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // creating Excel Application                 
                    Excel.Application xlexcel = new Excel.Application();
                    object misValue = System.Reflection.Missing.Value;
                    // creating new WorkBook within Excel application                  
                    xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                    Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    // creating new Excelsheet in workbook  
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = null;
                    // see the excel sheet behind the program                 
                    // get the reference of first sheet. By default its name is Sheet1.  
                    // store its reference to worksheet  
                    xlWorkSheet = xlWorkBook.Sheets["Sheet1"];
                    xlWorkSheet = xlWorkBook.ActiveSheet;
                    // changing the name of active sheet  
                    xlWorkSheet.Name = WorkSheetName;
                    xlWorkSheet.Cells[1,1]= ReportHeader;
                    Excel.Range range = xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, objDGV.Columns.Count]];
                    range.Merge();
                    // storing header part in Excel  
                    for (int i = 1; i < objDGV.Columns.Count + 1; i++)
                    {
                        xlWorkSheet.Cells[2, i] = objDGV.Columns[i - 1].HeaderText;
                        if (objDGV.Columns[i - 1].HeaderText.ToString().ToUpper().Contains("DATE") ==true)
                        {
                            strdateColumnIndex = strdateColumnIndex + strsep + (i-1).ToString() + strsep;
                        }

                    }
                    // storing Each row and column value to excel sheet  
                    for (int i = 0; i <= objDGV.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < objDGV.Columns.Count; j++)
                        {
                            if (strdateColumnIndex.Contains(strsep + (j).ToString() + strsep) == true )
                            {
                                xlWorkSheet.Cells[i + 3, j + 1] = "'" + objDGV.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                  xlWorkSheet.Cells[i + 3, j + 1] =  objDGV.Rows[i].Cells[j].Value.ToString();
                            }

                        }
                    }
                    xlWorkSheet.Cells.Select();
                    xlWorkSheet.Cells.EntireColumn.AutoFit();

                    xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlexcel.DisplayAlerts = true;
                    xlWorkBook.Close(true, misValue, misValue);
                    xlexcel.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlexcel);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                //MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            finally
            {
                GC.Collect();
            }
        }


        public static void ChangeCellGreenRed(DataGridViewCellFormattingEventArgs e , int pColIndex  , int pCheckValue  )
        {

            if (e.ColumnIndex == pColIndex)
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                if ((commonLib.fnCheckDecimal(e.Value.ToString()) > pCheckValue))
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;

                }
                else if ((commonLib.fnCheckNull(e.Value.ToString()) < pCheckValue))
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }

            }

        }








    }
}

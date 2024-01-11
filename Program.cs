using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EagleEye
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {
                // populate global variables
                commonLib.PopulateGlobalParameter();

                //Create Directoroes if missing
                DirectoryInfo di_source = Directory.CreateDirectory(commonLib.GetRavanvaFileSourcePath());
                DirectoryInfo di_process = Directory.CreateDirectory(commonLib.GetInvoiceFilePath());
                DirectoryInfo di_cancel = Directory.CreateDirectory(commonLib.GetCancelledInvoiceFilePath());
                DirectoryInfo di_duplicate = Directory.CreateDirectory(commonLib.GetDuplicateInvoiceFilePath());


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new frmLoadRavanna());
                //Application.Run(new frmMain());
                Application.Run(new frmlogin());
            }
            catch (Exception e)
            {
                commonLib.showUIMessage(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }
    }
}

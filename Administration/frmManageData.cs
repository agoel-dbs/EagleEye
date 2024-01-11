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

namespace EagleEye.Administration
{
    public partial class frmManageData : Form
    {

        public frmManageData()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Manage Data");

        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageData_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGenerateBackup_Click(object sender, EventArgs e)
        {
            try {

                Cursor.Current = Cursors.WaitCursor;
                commonLib.DataBackup();
                Cursor.Current = Cursors.Default;
                commonLib.showUIMessage("Backup created sucessfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                commonLib.showUIMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }
        }
    }
}

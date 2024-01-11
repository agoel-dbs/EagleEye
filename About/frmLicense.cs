using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EagleEye.DBLayer;
using EagleEye.Lib;

namespace EagleEye.About
{
    public partial class frmLicense : Form
    {

        Boolean bFormLoad = false;
        string strUserID = "";
        public frmLicense()
        {
            InitializeComponent();
            commonLib.ManageFormLayout(pnlMain, lblFormHeader, "Software License");

        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicense_Load(object sender, EventArgs e)
        {
            fnLicenceDetailsLoad();
        }

        private void fnLicenceDetailsLoad()
        {
            rtbLicence.Text = "Software license is issued to: \n\nM/S " + Global.gSellerName + "\n" + Global.gSellerAdd1 + " ,\n" + Global.gSellerAdd2 +
                " ,\n" + Global.gSellerAdd3 + "\nGSTIN: " + Global.gSellerGSTIN + "\n\n" + "Software licnse key is :" +
                commonLib.fnCheckNull1(ConfigurationManager.AppSettings.Get("LICESSE_KEY")) + "\n" +
                "Current License is valid untill: " + commonLib.GetDecryptedPassword(ConfigurationManager.AppSettings.Get("LICESSE_VALIDITY")) +
                "\n\nFor any other information , " + Global.gContactUs;



        }

    }
}

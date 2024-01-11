namespace EagleEye.Administration
{
    partial class frmManageData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageData));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbDatabaseBackup = new System.Windows.Forms.TabPage();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.btnGenerateBackup = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbDatabaseBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.lblFormHeader);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Location = new System.Drawing.Point(87, 30);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(625, 377);
            this.pnlMain.TabIndex = 42;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbDatabaseBackup);
            this.tabMain.Location = new System.Drawing.Point(29, 64);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(563, 270);
            this.tabMain.TabIndex = 90;
            // 
            // tbDatabaseBackup
            // 
            this.tbDatabaseBackup.BackColor = System.Drawing.Color.SandyBrown;
            this.tbDatabaseBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDatabaseBackup.Controls.Add(this.btnGenerateBackup);
            this.tbDatabaseBackup.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbDatabaseBackup.Location = new System.Drawing.Point(4, 22);
            this.tbDatabaseBackup.Margin = new System.Windows.Forms.Padding(2);
            this.tbDatabaseBackup.Name = "tbDatabaseBackup";
            this.tbDatabaseBackup.Padding = new System.Windows.Forms.Padding(2);
            this.tbDatabaseBackup.Size = new System.Drawing.Size(555, 244);
            this.tbDatabaseBackup.TabIndex = 0;
            this.tbDatabaseBackup.Text = "DataBase Backup";
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFormHeader.Location = new System.Drawing.Point(189, 0);
            this.lblFormHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(67, 15);
            this.lblFormHeader.TabIndex = 89;
            this.lblFormHeader.Text = "Header";
            this.lblFormHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerateBackup
            // 
            this.btnGenerateBackup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerateBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateBackup.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGenerateBackup.Image = global::EagleEye.Properties.Resources.img_load;
            this.btnGenerateBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateBackup.Location = new System.Drawing.Point(190, 85);
            this.btnGenerateBackup.Name = "btnGenerateBackup";
            this.btnGenerateBackup.Size = new System.Drawing.Size(186, 30);
            this.btnGenerateBackup.TabIndex = 4;
            this.btnGenerateBackup.Text = "    &Generate Backup";
            this.btnGenerateBackup.UseVisualStyleBackColor = false;
            this.btnGenerateBackup.Click += new System.EventHandler(this.btnGenerateBackup_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Image = global::EagleEye.Properties.Resources.img_exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(268, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "   &Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmManageData
            // 
            this.AcceptButton = this.btnGenerateBackup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(833, 445);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageData";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManageData_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tbDatabaseBackup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Button btnGenerateBackup;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbDatabaseBackup;
    }
}
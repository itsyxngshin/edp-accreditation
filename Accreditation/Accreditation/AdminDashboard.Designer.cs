namespace Accreditation
{
    partial class AdminDashboard
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
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            addOrganizationToolStripMenuItem = new ToolStripMenuItem();
            searchUserToolStripMenuItem = new ToolStripMenuItem();
            searchStudentsToolStripMenuItem = new ToolStripMenuItem();
            accreditationStatusToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            studentOrganizationReportToolStripMenuItem = new ToolStripMenuItem();
            collegeTurnoutReportToolStripMenuItem = new ToolStripMenuItem();
            accreditationStatusToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, toolsToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            mainMenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            mainMenuToolStripMenuItem.Size = new Size(117, 29);
            mainMenuToolStripMenuItem.Text = "Main Menu";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(171, 34);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addOrganizationToolStripMenuItem, searchUserToolStripMenuItem, searchStudentsToolStripMenuItem, accreditationStatusToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(105, 29);
            toolsToolStripMenuItem.Text = "Processes";
            toolsToolStripMenuItem.Click += toolsToolStripMenuItem_Click;
            // 
            // addOrganizationToolStripMenuItem
            // 
            addOrganizationToolStripMenuItem.Name = "addOrganizationToolStripMenuItem";
            addOrganizationToolStripMenuItem.Size = new Size(271, 34);
            addOrganizationToolStripMenuItem.Text = "Add Organization";
            addOrganizationToolStripMenuItem.Click += addOrganizationToolStripMenuItem_Click;
            // 
            // searchUserToolStripMenuItem
            // 
            searchUserToolStripMenuItem.Name = "searchUserToolStripMenuItem";
            searchUserToolStripMenuItem.Size = new Size(271, 34);
            searchUserToolStripMenuItem.Text = "See Users";
            searchUserToolStripMenuItem.Click += searchUserToolStripMenuItem_Click;
            // 
            // searchStudentsToolStripMenuItem
            // 
            searchStudentsToolStripMenuItem.Name = "searchStudentsToolStripMenuItem";
            searchStudentsToolStripMenuItem.Size = new Size(271, 34);
            searchStudentsToolStripMenuItem.Text = "Search Students";
            // 
            // accreditationStatusToolStripMenuItem
            // 
            accreditationStatusToolStripMenuItem.Name = "accreditationStatusToolStripMenuItem";
            accreditationStatusToolStripMenuItem.Size = new Size(271, 34);
            accreditationStatusToolStripMenuItem.Text = "Accreditation Status";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentOrganizationReportToolStripMenuItem, collegeTurnoutReportToolStripMenuItem, accreditationStatusToolStripMenuItem1 });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(89, 29);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // studentOrganizationReportToolStripMenuItem
            // 
            studentOrganizationReportToolStripMenuItem.Name = "studentOrganizationReportToolStripMenuItem";
            studentOrganizationReportToolStripMenuItem.Size = new Size(340, 34);
            studentOrganizationReportToolStripMenuItem.Text = "Student Organization Report";
            studentOrganizationReportToolStripMenuItem.Click += studentOrganizationReportToolStripMenuItem_Click;
            // 
            // collegeTurnoutReportToolStripMenuItem
            // 
            collegeTurnoutReportToolStripMenuItem.Name = "collegeTurnoutReportToolStripMenuItem";
            collegeTurnoutReportToolStripMenuItem.Size = new Size(340, 34);
            collegeTurnoutReportToolStripMenuItem.Text = "College Turnout Report";
            // 
            // accreditationStatusToolStripMenuItem1
            // 
            accreditationStatusToolStripMenuItem1.Name = "accreditationStatusToolStripMenuItem1";
            accreditationStatusToolStripMenuItem1.Size = new Size(340, 34);
            accreditationStatusToolStripMenuItem1.Text = "Accreditation Status";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminDashboard";
            Text = "LIYAB: Admin Control Dashboard";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem addOrganizationToolStripMenuItem;
        private ToolStripMenuItem searchUserToolStripMenuItem;
        private ToolStripMenuItem searchStudentsToolStripMenuItem;
        private ToolStripMenuItem accreditationStatusToolStripMenuItem;
        private ToolStripMenuItem studentOrganizationReportToolStripMenuItem;
        private ToolStripMenuItem collegeTurnoutReportToolStripMenuItem;
        private ToolStripMenuItem accreditationStatusToolStripMenuItem1;
    }
}
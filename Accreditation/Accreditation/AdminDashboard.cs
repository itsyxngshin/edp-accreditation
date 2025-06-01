using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accreditation
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void searchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserOperations userAccess = new UserOperations();
            userAccess.Show();
        }

        private void addOrganizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrganizationAdd orgNew = new OrganizationAdd();
            orgNew.Show();
        }

        private void studentOrganizationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentOrgs studOrgs = new StudentOrgs();
            studOrgs.Show();
        }
    }
}

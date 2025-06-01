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
    public partial class StudentOrgs : Form
    {
        public StudentOrgs()
        {
            InitializeComponent();
        }

        private void StudentOrgs_Load(object sender, EventArgs e)
        {
            LoadCollegeOrganizationCounts();
        }

        // You likely already have this method too:
        private void LoadCollegeOrganizationCounts()
        {
            try
            {
                DataManager dm = new DataManager();
                studentOrgGrid.DataSource = dm.GetCollegeOrgCounts(); // <- You might need to implement GetCollegeOrgCounts in DataManager
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void studentOrgGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

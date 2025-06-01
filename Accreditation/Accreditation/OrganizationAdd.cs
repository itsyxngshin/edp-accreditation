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

    public partial class OrganizationAdd : Form
    {

        public OrganizationAdd()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DataManager dm = new DataManager();
                var collegeList = dm.LoadCollegeNames();

                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(collegeList.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading colleges: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class AccRegistry : Form
    {
        public AccRegistry()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccLogin form1 = new AccLogin(); // Create instance of Form2
            form1.Show();              // Show Form2
            this.Hide();
        }
    }
}

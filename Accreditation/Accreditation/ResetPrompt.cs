using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Accreditation
{
    public partial class ResetPrompt : Form
    {
        public ResetPrompt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            DataManager db = new DataManager();

            if (!db.DoesEmailExist(email))
            {
                MessageBox.Show("No account found with this email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string code = Guid.NewGuid().ToString().Substring(0, 6); // short code
            db.SaveResetCode(email, code);

            // For real app: send via SMTP
            MessageBox.Show($"Use this code to reset your password: {code}", "Password Reset Code");

            PasswordReset resetForm = new PasswordReset(email);
            resetForm.Show();
            this.Close();
        }

        private void ResetPrompt_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class PasswordReset : Form
    {
        private string _email;
        public PasswordReset(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private void resetButt_Click(object sender, EventArgs e)
        {
            string inputCode = resetCode.Text.Trim();
            string newPass = newPassword.Text;

            DataManager db = new DataManager();

            if (!db.VerifyResetCode(_email, inputCode))
            {
                MessageBox.Show("Invalid code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.UpdatePasswordByEmail(_email, newPass);
            MessageBox.Show("Password updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void PasswordReset_Load(object sender, EventArgs e)
        {

        }
    }
}

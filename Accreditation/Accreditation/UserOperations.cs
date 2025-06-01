using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Accreditation
{
    public partial class UserOperations : Form
    {
        public UserOperations()
        {
            InitializeComponent();
        }

        private void txtEmailSearch_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email)) return;

            var dataManager = new DataManager();
            var user = dataManager.GetUserByEmail(email);

            if (user != null)
            {
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtEmail.Text = user.Email;

                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtPassword.Enabled = true;
                txtEmail.Enabled = false;
            }
            else
            {
                MessageBox.Show("User not found.");
                ClearForm();
            }
        }
        private void ClearForm()
        {
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPassword.Clear();

            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtEmail.Enabled = true;
            txtPassword.Enabled = false;
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = emailText.Text.Trim();
            DataManager db = new DataManager();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email address.");
                return;
            }

            if (db.EmailExists(email))
            {
                var result = MessageBox.Show("User found. Do you want to delete this account?",
                                             "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    db.DeleteUserByEmail(email);
                    MessageBox.Show("User deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No user found with that email.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameAdd.Text;
                string email = emailAdd.Text;
                string firstName = fnameAdd.Text;
                string lastName = lnameAdd.Text;
                string phoneNum = phoneAdd.Text;
                string password = passwordAdd.Text;
                int role = 2;  // for student access
                int status = 1; // default as active

                DataManager dm = new DataManager();  // or use dependency injection if applicable
                dm.InsertUser(username, email, firstName, lastName, phoneNum, password, role, status);

                MessageBox.Show("User added successfully!");

                AdminDashboard adash = new AdminDashboard();
                adash.Show();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string username = txtUsername.Text.Trim();
            string phoneNum = txtPhoneNum.Text.Trim(); 

            var dataManager = new DataManager();
            bool success = dataManager.UpdateUserByEmail(email, firstName, lastName, password, username, phoneNum);

            if (success)
            {
                MessageBox.Show("User updated successfully.");
            }
            else
            {
                MessageBox.Show("Update failed or user not found.");
            }
        }
        public class User
        {
            public int UserId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Username { get; set; }
            public string PhoneNum { get; set; }
            public string password { get; set; }
            public string Email { get; set; }
        }
    }
}

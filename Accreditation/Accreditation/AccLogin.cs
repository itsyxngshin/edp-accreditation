namespace Accreditation
{
    public partial class AccLogin : Form
    {
        public AccLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbManager = new DataManager();
            bool isAuthenticated = dbManager.AuthenticateUser(emailBox.Text, passBox.Text);

            if (isAuthenticated)
            {
                MessageBox.Show("Login Successful", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminDashboard dashboard = new AdminDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed. Please check your username and password.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccRegistry form3 = new AccRegistry(); // Create instance of Form3
            form3.Show();              // Show Form3
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPrompt reset = new ResetPrompt(); // Create instance of Form3
            reset.Show();              // Show Form3
        }
    }
}

namespace Accreditation
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Create instance of Form2
            form1.Show();              // Show Form2
            this.Hide();
        }
    }
}

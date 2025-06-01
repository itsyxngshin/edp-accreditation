namespace Accreditation
{
    partial class AccLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            entryEmail = new Label();
            emailBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            passBox = new TextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // entryEmail
            // 
            entryEmail.AutoSize = true;
            entryEmail.Location = new Point(45, 59);
            entryEmail.Name = "entryEmail";
            entryEmail.Size = new Size(54, 25);
            entryEmail.TabIndex = 0;
            entryEmail.Text = "Email";
            entryEmail.Click += label1_Click;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(45, 87);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "Enter your email address";
            emailBox.Size = new Size(352, 31);
            emailBox.TabIndex = 1;
            emailBox.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(164, 236);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 141);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 3;
            label1.Text = "Password";
            label1.Click += label1_Click_1;
            // 
            // passBox
            // 
            passBox.Location = new Point(50, 186);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.PlaceholderText = "*********";
            passBox.Size = new Size(347, 31);
            passBox.TabIndex = 4;
            passBox.TextChanged += textBox2_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(146, 291);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(148, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AccLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 339);
            Controls.Add(linkLabel1);
            Controls.Add(passBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(emailBox);
            Controls.Add(entryEmail);
            HelpButton = true;
            Name = "AccLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LIYAB: BU Student Organization Accreditation";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label entryEmail;
        private TextBox emailBox;
        private Button button1;
        private Label label1;
        private TextBox passBox;
        private LinkLabel linkLabel1;
    }
}

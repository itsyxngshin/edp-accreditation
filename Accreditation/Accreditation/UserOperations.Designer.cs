namespace Accreditation
{
    partial class UserOperations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userData = new TabControl();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            label9 = new Label();
            usernameAdd = new TextBox();
            phoneAdd = new TextBox();
            label7 = new Label();
            lnameAdd = new TextBox();
            fnameAdd = new TextBox();
            label6 = new Label();
            button1 = new Button();
            label5 = new Label();
            passwordAdd = new TextBox();
            emailAdd = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            emailText = new TextBox();
            label8 = new Label();
            button2 = new Button();
            tabPage3 = new TabPage();
            panel3 = new Panel();
            label14 = new Label();
            txtUsername = new TextBox();
            txtPhoneNum = new TextBox();
            label15 = new Label();
            button3 = new Button();
            label13 = new Label();
            txtLastName = new TextBox();
            label12 = new Label();
            txtFirstName = new TextBox();
            txtPassword = new TextBox();
            label11 = new Label();
            txtEmail = new TextBox();
            label10 = new Label();
            userData.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // userData
            // 
            userData.Controls.Add(tabPage2);
            userData.Controls.Add(tabPage1);
            userData.Controls.Add(tabPage3);
            userData.Location = new Point(12, 12);
            userData.Name = "userData";
            userData.SelectedIndex = 0;
            userData.Size = new Size(551, 489);
            userData.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(543, 451);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Users";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(usernameAdd);
            panel1.Controls.Add(phoneAdd);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lnameAdd);
            panel1.Controls.Add(fnameAdd);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(passwordAdd);
            panel1.Controls.Add(emailAdd);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 445);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 258);
            label9.Name = "label9";
            label9.Size = new Size(91, 25);
            label9.TabIndex = 12;
            label9.Text = "Username";
            // 
            // usernameAdd
            // 
            usernameAdd.Location = new Point(40, 286);
            usernameAdd.Name = "usernameAdd";
            usernameAdd.Size = new Size(188, 31);
            usernameAdd.TabIndex = 11;
            // 
            // phoneAdd
            // 
            phoneAdd.Location = new Point(265, 286);
            phoneAdd.Name = "phoneAdd";
            phoneAdd.Size = new Size(189, 31);
            phoneAdd.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(265, 258);
            label7.Name = "label7";
            label7.Size = new Size(132, 25);
            label7.TabIndex = 9;
            label7.Text = "Phone Number";
            // 
            // lnameAdd
            // 
            lnameAdd.Location = new Point(265, 201);
            lnameAdd.Name = "lnameAdd";
            lnameAdd.Size = new Size(189, 31);
            lnameAdd.TabIndex = 8;
            // 
            // fnameAdd
            // 
            fnameAdd.Location = new Point(42, 201);
            fnameAdd.Name = "fnameAdd";
            fnameAdd.Size = new Size(190, 31);
            fnameAdd.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(265, 173);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 6;
            label6.Text = "Last Name";
            // 
            // button1
            // 
            button1.Location = new Point(202, 392);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 173);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 4;
            label5.Text = "First Name";
            // 
            // passwordAdd
            // 
            passwordAdd.Location = new Point(42, 115);
            passwordAdd.Name = "passwordAdd";
            passwordAdd.PasswordChar = '*';
            passwordAdd.Size = new Size(412, 31);
            passwordAdd.TabIndex = 3;
            // 
            // emailAdd
            // 
            emailAdd.Location = new Point(42, 42);
            emailAdd.Name = "emailAdd";
            emailAdd.Size = new Size(412, 31);
            emailAdd.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 87);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 1;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 14);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 102);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 17);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(543, 451);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Delete Users";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(emailText);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(537, 445);
            panel2.TabIndex = 0;
            // 
            // emailText
            // 
            emailText.Location = new Point(28, 54);
            emailText.Name = "emailText";
            emailText.Size = new Size(416, 31);
            emailText.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 26);
            label8.Name = "label8";
            label8.Size = new Size(124, 25);
            label8.TabIndex = 1;
            label8.Text = "Email Address";
            // 
            // button2
            // 
            button2.Location = new Point(190, 113);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 0;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel3);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(543, 451);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Update User";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(txtPhoneNum);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(txtLastName);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtFirstName);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(-4, -2);
            panel3.Name = "panel3";
            panel3.Size = new Size(551, 457);
            panel3.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(44, 286);
            label14.Name = "label14";
            label14.Size = new Size(91, 25);
            label14.TabIndex = 17;
            label14.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(42, 314);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(188, 31);
            txtUsername.TabIndex = 16;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(283, 314);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(189, 31);
            txtPhoneNum.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(283, 286);
            label15.Name = "label15";
            label15.Size = new Size(132, 25);
            label15.TabIndex = 14;
            label15.Text = "Phone Number";
            // 
            // button3
            // 
            button3.Location = new Point(201, 383);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 13;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(283, 213);
            label13.Name = "label13";
            label13.Size = new Size(95, 25);
            label13.TabIndex = 7;
            label13.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(283, 241);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(192, 31);
            txtLastName.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(44, 213);
            label12.Name = "label12";
            label12.Size = new Size(97, 25);
            label12.TabIndex = 5;
            label12.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(44, 241);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(192, 31);
            txtFirstName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(42, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(402, 31);
            txtPassword.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 110);
            label11.Name = "label11";
            label11.Size = new Size(87, 25);
            label11.TabIndex = 2;
            label11.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(42, 54);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(402, 31);
            txtEmail.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 26);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 0;
            label10.Text = "Email";
            // 
            // UserOperations
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 551);
            Controls.Add(userData);
            Name = "UserOperations";
            Text = "UserOperations";
            userData.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl userData;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private TextBox lnameAdd;
        private TextBox fnameAdd;
        private Label label6;
        private Button button1;
        private Label label5;
        private TextBox passwordAdd;
        private TextBox emailAdd;
        private Label label4;
        private Label label7;
        private Panel panel2;
        private Button button2;
        private TextBox emailText;
        private Label label8;
        private TextBox phoneAdd;
        private Label label9;
        private TextBox usernameAdd;
        private Panel panel3;
        private Label label14;
        private TextBox txtUsername;
        private TextBox txtPhoneNum;
        private Label label15;
        private Button button3;
        private Label label13;
        private TextBox txtLastName;
        private Label label12;
        private TextBox txtFirstName;
        private TextBox txtPassword;
        private Label label11;
        private TextBox txtEmail;
        private Label label10;
    }
}
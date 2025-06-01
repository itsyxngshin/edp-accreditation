namespace Accreditation
{
    partial class AccRegistry
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
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 34);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 4;
            label2.Text = "Organization Name:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 31);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(473, 34);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 6;
            label1.Text = "Classification";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(650, 385);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(24, 385);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(24, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(356, 31);
            textBox2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 130);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 10;
            label3.Text = "Description";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "<type of organization>", "University-Based Organization", "College-Based Organization", "Department-Based Organization", "College Student Council" });
            comboBox1.Location = new Point(473, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(289, 33);
            comboBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 130);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 12;
            label4.Text = "College";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "<college or institute>", "College of Science", "College of Engineering", "College of Nursing", "College of Arts and Letters", "Institute of Design and Architecture", "BU Polangui" });
            comboBox2.Location = new Point(473, 158);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(289, 33);
            comboBox2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 221);
            label5.Name = "label5";
            label5.Size = new Size(174, 25);
            label5.TabIndex = 14;
            label5.Text = "Organizational Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 221);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 15;
            label6.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(24, 249);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(356, 31);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(473, 249);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(289, 31);
            textBox4.TabIndex = 17;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "Form3";
            Text = "LIYAB: Student Organization Registry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
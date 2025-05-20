namespace Accreditation
{
    partial class Form2
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 46);
            label1.Name = "label1";
            label1.Size = new Size(339, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Organization Accreditation Portal";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(662, 393);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(35, 303);
            button2.Name = "button2";
            button2.Size = new Size(259, 34);
            button2.TabIndex = 2;
            button2.Text = "List of Members";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 89);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 3;
            label2.Text = "Organization Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 114);
            label3.Name = "label3";
            label3.Size = new Size(526, 25);
            label3.TabIndex = 4;
            label3.Text = "BICOL UNIVERSITY - UNIVERSITY BASED CLUB FOR UNESCO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 162);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 5;
            label4.Text = "Category:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 187);
            label5.Name = "label5";
            label5.Size = new Size(325, 25);
            label5.TabIndex = 6;
            label5.Text = "UNIVERSITY BASED ORGANIZATION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(479, 162);
            label6.Name = "label6";
            label6.Size = new Size(126, 25);
            label6.TabIndex = 7;
            label6.Text = "Academic Year";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(479, 187);
            label7.Name = "label7";
            label7.Size = new Size(109, 25);
            label7.TabIndex = 8;
            label7.Text = "2024 - 2025";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 227);
            label8.Name = "label8";
            label8.Size = new Size(60, 25);
            label8.TabIndex = 9;
            label8.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(35, 252);
            label9.Name = "label9";
            label9.Size = new Size(121, 25);
            label9.TabIndex = 10;
            label9.Text = "ACCREDITED";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(479, 227);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 11;
            label10.Text = "Head";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(484, 252);
            label11.Name = "label11";
            label11.Size = new Size(227, 25);
            label11.TabIndex = 12;
            label11.Text = "CABALBAG, Adornado Jr.";
            // 
            // button3
            // 
            button3.Location = new Point(452, 303);
            button3.Name = "button3";
            button3.Size = new Size(259, 34);
            button3.TabIndex = 13;
            button3.Text = "Submissions";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "LIYAB BU";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button3;
    }
}
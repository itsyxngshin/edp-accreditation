﻿namespace Accreditation
{
    partial class OrganizationAdd
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
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 37);
            label1.Name = "label1";
            label1.Size = new Size(329, 25);
            label1.TabIndex = 0;
            label1.Text = "STUDENT ORGANIZATION REGISTRY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 71);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 1;
            label2.Text = "Name of Organization";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 31);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 71);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 3;
            label3.Text = "Abbreviation";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(422, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 31);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 156);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 5;
            label4.Text = "Description";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(51, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 31);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(422, 156);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 7;
            label5.Text = "Category";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CBO", "UBO", "CSC" });
            comboBox1.Location = new Point(422, 182);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(306, 33);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 245);
            label6.Name = "label6";
            label6.Size = new Size(138, 25);
            label6.TabIndex = 9;
            label6.Text = "Year Established";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(51, 273);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "YYYY";
            textBox4.Size = new Size(295, 31);
            textBox4.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(324, 384);
            button1.Name = "button1";
            button1.Size = new Size(182, 34);
            button1.TabIndex = 11;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            // 
            // OrganizationAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrganizationAdd";
            Text = "OrganizationAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox4;
        private Button button1;
    }
}
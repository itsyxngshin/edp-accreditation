namespace Accreditation
{
    partial class Form5
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
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            listView1 = new ListView();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(653, 391);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 96);
            label3.Name = "label3";
            label3.Size = new Size(526, 25);
            label3.TabIndex = 7;
            label3.Text = "BICOL UNIVERSITY - UNIVERSITY BASED CLUB FOR UNESCO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 71);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 6;
            label2.Text = "Organization Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 23);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 5;
            label1.Text = "Members List";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(60, 391);
            button2.Name = "button2";
            button2.Size = new Size(242, 34);
            button2.TabIndex = 8;
            button2.Text = "Generate Report";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(693, 228);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(60, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(705, 244);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form5";
            Text = "LIYAB - Members List";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private ListView listView1;
        private GroupBox groupBox1;
    }
}
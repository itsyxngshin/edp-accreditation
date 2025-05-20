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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Danielle", "Rubis", "Female", "College of Science" }, -1);
            ListViewItem listViewItem2 = new ListViewItem("Adornado");
            listView1 = new ListView();
            first_name = new ColumnHeader();
            last_name = new ColumnHeader();
            gender = new ColumnHeader();
            college = new ColumnHeader();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { first_name, last_name, gender, college });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HideSelection = true;
            listViewItem1.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(60, 132);
            listView1.Name = "listView1";
            listView1.Size = new Size(685, 238);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // first_name
            // 
            first_name.Text = "First Name";
            first_name.Width = 100;
            // 
            // last_name
            // 
            last_name.Text = "Last Name";
            last_name.Width = 100;
            // 
            // gender
            // 
            gender.Text = "Gender";
            gender.Width = 100;
            // 
            // college
            // 
            college.Text = "College";
            college.Width = 200;
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
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Form5";
            Text = "LIYAB - Members List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader first_name;
        private ColumnHeader last_name;
        private ColumnHeader gender;
        private ColumnHeader college;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
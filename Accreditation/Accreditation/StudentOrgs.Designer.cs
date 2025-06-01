namespace Accreditation
{
    partial class StudentOrgs
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
            studentOrgGrid = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)studentOrgGrid).BeginInit();
            SuspendLayout();
            // 
            // studentOrgGrid
            // 
            studentOrgGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentOrgGrid.Location = new Point(51, 43);
            studentOrgGrid.Name = "studentOrgGrid";
            studentOrgGrid.RowHeadersWidth = 62;
            studentOrgGrid.Size = new Size(690, 320);
            studentOrgGrid.TabIndex = 0;
            studentOrgGrid.CellContentClick += studentOrgGrid_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(293, 391);
            button1.Name = "button1";
            button1.Size = new Size(213, 34);
            button1.TabIndex = 1;
            button1.Text = "Generate Report";
            button1.UseVisualStyleBackColor = true;
            // 
            // StudentOrgs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(studentOrgGrid);
            Name = "StudentOrgs";
            Text = "StudentOrgs";
            ((System.ComponentModel.ISupportInitialize)studentOrgGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView studentOrgGrid;
        private Button button1;
    }
}
namespace Accreditation
{
    partial class ResetPrompt
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
            txtEmail = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 38);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter your email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 66);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(455, 31);
            txtEmail.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(161, 128);
            button1.Name = "button1";
            button1.Size = new Size(211, 47);
            button1.TabIndex = 2;
            button1.Text = "Send Recovery Code";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ResetPrompt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 237);
            Controls.Add(button1);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "ResetPrompt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPrompt";
            Load += ResetPrompt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button button1;
    }
}
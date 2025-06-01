namespace Accreditation
{
    partial class PasswordReset
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
            resetButt = new Button();
            label2 = new Label();
            resetCode = new TextBox();
            newPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 34);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter the code:";
            // 
            // resetButt
            // 
            resetButt.Location = new Point(166, 222);
            resetButt.Name = "resetButt";
            resetButt.Size = new Size(112, 34);
            resetButt.TabIndex = 1;
            resetButt.Text = "Reset";
            resetButt.UseVisualStyleBackColor = true;
            resetButt.Click += resetButt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 104);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 2;
            label2.Text = "Enter new password";
            // 
            // resetCode
            // 
            resetCode.Location = new Point(46, 62);
            resetCode.Name = "resetCode";
            resetCode.Size = new Size(294, 31);
            resetCode.TabIndex = 3;
            // 
            // newPassword
            // 
            newPassword.Location = new Point(46, 132);
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(294, 31);
            newPassword.TabIndex = 4;
            // 
            // PasswordReset
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 268);
            Controls.Add(newPassword);
            Controls.Add(resetCode);
            Controls.Add(label2);
            Controls.Add(resetButt);
            Controls.Add(label1);
            Name = "PasswordReset";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PasswordReset";
            Load += PasswordReset_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button resetButt;
        private Label label2;
        private TextBox resetCode;
        private TextBox newPassword;
    }
}
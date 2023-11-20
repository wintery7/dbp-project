namespace deepcheesebacon
{
    partial class LoginForm
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
            buttonLogin = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBoxEmail = new System.Windows.Forms.TextBox();
            textBoxPassword = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new System.Drawing.Point(713, 218);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new System.Drawing.Size(100, 102);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(312, 235);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(312, 285);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(25, 15);
            label2.TabIndex = 2;
            label2.Text = "PW";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new System.Drawing.Point(357, 232);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new System.Drawing.Size(323, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new System.Drawing.Point(357, 282);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new System.Drawing.Size(323, 23);
            textBoxPassword.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1084, 661);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}
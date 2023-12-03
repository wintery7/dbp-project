﻿using deepcheesebacon.Customizing;

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
            buttonLogin = new CustomButtonStyle();
            textBoxEmail = new CustomTextBox();
            textBoxPassword = new CustomTextBox();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(4, 96, 217);
            buttonLogin.BackgroundColor = Color.FromArgb(4, 96, 217);
            buttonLogin.BorderColor = Color.FromArgb(50, 122, 217);
            buttonLogin.BorderRadius = 20;
            buttonLogin.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(828, 251);
            buttonLogin.Margin = new Padding(4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(129, 136);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.TextColor = Color.White;
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = SystemColors.Window;
            textBoxEmail.BorderColor = Color.RoyalBlue;
            textBoxEmail.BorderFocusColor = Color.MidnightBlue;
            textBoxEmail.BorderRadius = 10;
            textBoxEmail.BorderSize = 2;
            textBoxEmail.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.ForeColor = Color.DimGray;
            textBoxEmail.Location = new Point(362, 273);
            textBoxEmail.Multiline = false;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Padding = new Padding(10, 7, 10, 7);
            textBoxEmail.PasswordChar = false;
            textBoxEmail.PlaceholderColor = Color.DarkGray;
            textBoxEmail.PlaceholderText = "Email을 입력해주세요.";
            textBoxEmail.Size = new Size(438, 36);
            textBoxEmail.TabIndex = 5;
            textBoxEmail.Texts = "";
            textBoxEmail.UnderlinedStyle = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.Window;
            textBoxPassword.BorderColor = Color.RoyalBlue;
            textBoxPassword.BorderFocusColor = Color.MidnightBlue;
            textBoxPassword.BorderRadius = 10;
            textBoxPassword.BorderSize = 2;
            textBoxPassword.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.DimGray;
            textBoxPassword.Location = new Point(362, 340);
            textBoxPassword.Multiline = false;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Padding = new Padding(10, 7, 10, 7);
            textBoxPassword.PasswordChar = false;
            textBoxPassword.PlaceholderColor = Color.DarkGray;
            textBoxPassword.PlaceholderText = "비밀번호를 입력해주세요.";
            textBoxPassword.Size = new Size(438, 36);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.Texts = "";
            textBoxPassword.UnderlinedStyle = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 663);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonLogin);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
        }

        #endregion
        private CustomButtonStyle buttonLogin;
        private CustomTextBox textBoxEmail;
        private CustomTextBox textBoxPassword;
    }
}
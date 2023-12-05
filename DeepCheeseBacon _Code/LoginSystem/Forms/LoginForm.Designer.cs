using deepcheesebacon.Customizing;

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
            label1 = new Label();
            label2 = new Label();
            checkBoxAutoLogin = new CheckBox();
            customButtonStyle1 = new CustomButtonStyle();
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
            buttonLogin.Location = new Point(506, 129);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(100, 102);
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
            textBoxEmail.Location = new Point(144, 146);
            textBoxEmail.Margin = new Padding(2);
            textBoxEmail.Multiline = false;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Padding = new Padding(8, 5, 8, 5);
            textBoxEmail.PasswordChar = false;
            textBoxEmail.PlaceholderColor = Color.DarkGray;
            textBoxEmail.PlaceholderText = "Email을 입력해주세요.";
            textBoxEmail.Size = new Size(341, 28);
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
            textBoxPassword.Location = new Point(144, 196);
            textBoxPassword.Margin = new Padding(2);
            textBoxPassword.Multiline = false;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Padding = new Padding(8, 5, 8, 5);
            textBoxPassword.PasswordChar = true;
            textBoxPassword.PlaceholderColor = Color.DarkGray;
            textBoxPassword.PlaceholderText = "비밀번호를 입력해주세요.";
            textBoxPassword.Size = new Size(341, 28);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.Texts = "";
            textBoxPassword.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // checkBoxAutoLogin
            // 
            checkBoxAutoLogin.AutoSize = true;
            checkBoxAutoLogin.Location = new Point(398, 241);
            checkBoxAutoLogin.Margin = new Padding(2);
            checkBoxAutoLogin.Name = "checkBoxAutoLogin";
            checkBoxAutoLogin.Size = new Size(90, 19);
            checkBoxAutoLogin.TabIndex = 5;
            checkBoxAutoLogin.Text = "자동 로그인";
            checkBoxAutoLogin.UseVisualStyleBackColor = true;
            checkBoxAutoLogin.CheckedChanged += checkBoxAutoLogin_CheckedChanged;
            // 
            // customButtonStyle1
            // 
            customButtonStyle1.BackColor = Color.FromArgb(4, 96, 217);
            customButtonStyle1.BackgroundColor = Color.FromArgb(4, 96, 217);
            customButtonStyle1.BorderColor = Color.FromArgb(50, 122, 217);
            customButtonStyle1.BorderRadius = 20;
            customButtonStyle1.BorderSize = 0;
            customButtonStyle1.FlatStyle = FlatStyle.Flat;
            customButtonStyle1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButtonStyle1.ForeColor = Color.White;
            customButtonStyle1.Location = new Point(683, 323);
            customButtonStyle1.Name = "customButtonStyle1";
            customButtonStyle1.Size = new Size(53, 38);
            customButtonStyle1.TabIndex = 7;
            customButtonStyle1.Text = "exit";
            customButtonStyle1.TextColor = Color.White;
            customButtonStyle1.UseVisualStyleBackColor = false;
            customButtonStyle1.Click += customButtonStyle1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 373);
            Controls.Add(customButtonStyle1);
            Controls.Add(checkBoxAutoLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomButtonStyle buttonLogin;
        private CustomTextBox textBoxEmail;
        private CustomTextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private CheckBox checkBoxAutoLogin;
        private CustomButtonStyle customButtonStyle1;
    }
}
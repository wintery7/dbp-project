namespace deepcheesebacon.SourceCode.MessageSystem.Forms
{
    partial class MessageInBoxForm
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
            listBoxMessage = new ListBox();
            buttonSearchByContent = new Customizing.CustomButtonStyle();
            textBoxEmail = new Customizing.CustomTextBox();
            textBoxContent = new Customizing.CustomTextBox();
            SuspendLayout();
            // 
            // listBoxMessage
            // 
            listBoxMessage.FormattingEnabled = true;
            listBoxMessage.ItemHeight = 20;
            listBoxMessage.Location = new Point(15, 76);
            listBoxMessage.Margin = new Padding(4);
            listBoxMessage.Name = "listBoxMessage";
            listBoxMessage.Size = new Size(618, 444);
            listBoxMessage.TabIndex = 0;
            // 
            // buttonSearchByContent
            // 
            buttonSearchByContent.BackColor = Color.FromArgb(50, 122, 217);
            buttonSearchByContent.BackgroundColor = Color.FromArgb(50, 122, 217);
            buttonSearchByContent.BorderColor = Color.FromArgb(4, 96, 217);
            buttonSearchByContent.BorderRadius = 20;
            buttonSearchByContent.BorderSize = 0;
            buttonSearchByContent.FlatStyle = FlatStyle.Flat;
            buttonSearchByContent.ForeColor = Color.White;
            buttonSearchByContent.Location = new Point(546, 22);
            buttonSearchByContent.Margin = new Padding(4);
            buttonSearchByContent.Name = "buttonSearchByContent";
            buttonSearchByContent.Size = new Size(87, 37);
            buttonSearchByContent.TabIndex = 8;
            buttonSearchByContent.Text = "검색";
            buttonSearchByContent.TextColor = Color.White;
            buttonSearchByContent.UseVisualStyleBackColor = false;
            buttonSearchByContent.Click += buttonSearchByContent_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = SystemColors.Window;
            textBoxEmail.BorderColor = Color.FromArgb(50, 122, 217);
            textBoxEmail.BorderFocusColor = Color.FromArgb(4, 96, 217);
            textBoxEmail.BorderRadius = 0;
            textBoxEmail.BorderSize = 2;
            textBoxEmail.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.ForeColor = Color.DimGray;
            textBoxEmail.Location = new Point(15, 22);
            textBoxEmail.Multiline = false;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Padding = new Padding(10, 7, 10, 7);
            textBoxEmail.PasswordChar = false;
            textBoxEmail.PlaceholderColor = Color.DarkGray;
            textBoxEmail.PlaceholderText = "보낸사람의 이메일을 입력하세요.";
            textBoxEmail.Size = new Size(271, 36);
            textBoxEmail.TabIndex = 9;
            textBoxEmail.Texts = "";
            textBoxEmail.UnderlinedStyle = true;
            // 
            // textBoxContent
            // 
            textBoxContent.BackColor = SystemColors.Window;
            textBoxContent.BorderColor = Color.FromArgb(50, 122, 217);
            textBoxContent.BorderFocusColor = Color.FromArgb(4, 96, 217);
            textBoxContent.BorderRadius = 0;
            textBoxContent.BorderSize = 2;
            textBoxContent.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContent.ForeColor = Color.DimGray;
            textBoxContent.Location = new Point(292, 22);
            textBoxContent.Multiline = false;
            textBoxContent.Name = "textBoxContent";
            textBoxContent.Padding = new Padding(10, 7, 10, 7);
            textBoxContent.PasswordChar = false;
            textBoxContent.PlaceholderColor = Color.DarkGray;
            textBoxContent.PlaceholderText = "내용을 입력하세요.";
            textBoxContent.Size = new Size(247, 36);
            textBoxContent.TabIndex = 10;
            textBoxContent.Texts = "";
            textBoxContent.UnderlinedStyle = true;
            // 
            // MessageInBoxForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 533);
            Controls.Add(textBoxContent);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonSearchByContent);
            Controls.Add(listBoxMessage);
            Margin = new Padding(4);
            Name = "MessageInBoxForm";
            Text = "MessageInBoxForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxMessage;
        private Customizing.CustomButtonStyle buttonSearchByContent;
        private Customizing.CustomTextBox textBoxEmail;
        private Customizing.CustomTextBox textBoxContent;
    }
}
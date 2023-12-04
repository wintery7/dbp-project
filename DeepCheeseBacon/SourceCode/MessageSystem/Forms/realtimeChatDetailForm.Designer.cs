using deepcheesebacon.Customizing;

namespace deepcheesebacon.SourceCode.MessageSystem.Forms
{
    partial class realtimeChatDetailForm
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
            listBoxChatBox = new ListBox();
            buttonSendMessage = new CustomButtonStyle();
            customGroupBox1 = new CustomGroupBox();
            textBoxInputMessage = new CustomTextBox();
            customGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxChatBox
            // 
            listBoxChatBox.FormattingEnabled = true;
            listBoxChatBox.ItemHeight = 20;
            listBoxChatBox.Location = new Point(11, 52);
            listBoxChatBox.Margin = new Padding(4);
            listBoxChatBox.Name = "listBoxChatBox";
            listBoxChatBox.Size = new Size(934, 484);
            listBoxChatBox.TabIndex = 6;
            // 
            // buttonSendMessage
            // 
            buttonSendMessage.BackColor = SystemColors.Window;
            buttonSendMessage.BackgroundColor = SystemColors.Window;
            buttonSendMessage.BorderColor = Color.FromArgb(4, 96, 217);
            buttonSendMessage.BorderRadius = 10;
            buttonSendMessage.BorderSize = 2;
            buttonSendMessage.FlatStyle = FlatStyle.Flat;
            buttonSendMessage.ForeColor = Color.DarkBlue;
            buttonSendMessage.Location = new Point(843, 500);
            buttonSendMessage.Margin = new Padding(4);
            buttonSendMessage.Name = "buttonSendMessage";
            buttonSendMessage.Size = new Size(102, 36);
            buttonSendMessage.TabIndex = 8;
            buttonSendMessage.Text = "전송";
            buttonSendMessage.TextColor = Color.DarkBlue;
            buttonSendMessage.UseVisualStyleBackColor = false;
            buttonSendMessage.Click += buttonSendMessage_Click;
            // 
            // customGroupBox1
            // 
            customGroupBox1.BackColor = Color.Transparent;
            customGroupBox1.Controls.Add(buttonSendMessage);
            customGroupBox1.Controls.Add(textBoxInputMessage);
            customGroupBox1.Controls.Add(listBoxChatBox);
            customGroupBox1.Location = new Point(40, 26);
            customGroupBox1.Margin = new Padding(4);
            customGroupBox1.Name = "customGroupBox1";
            customGroupBox1.Padding = new Padding(4);
            customGroupBox1.Radious = 25;
            customGroupBox1.Size = new Size(953, 546);
            customGroupBox1.TabIndex = 27;
            customGroupBox1.TabStop = false;
            customGroupBox1.Text = "실시간 채팅";
            customGroupBox1.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox1.TitleFont = new Font("맑은 고딕", 17F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox1.TitleForeColor = Color.White;
            customGroupBox1.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // textBoxInputMessage
            // 
            textBoxInputMessage.BackColor = SystemColors.Window;
            textBoxInputMessage.BorderColor = Color.FromArgb(224, 224, 224);
            textBoxInputMessage.BorderFocusColor = Color.FromArgb(4, 96, 217);
            textBoxInputMessage.BorderRadius = 0;
            textBoxInputMessage.BorderSize = 1;
            textBoxInputMessage.Font = new Font("맑은 고딕", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxInputMessage.ForeColor = Color.DimGray;
            textBoxInputMessage.Location = new Point(12, 500);
            textBoxInputMessage.Multiline = false;
            textBoxInputMessage.Name = "textBoxInputMessage";
            textBoxInputMessage.Padding = new Padding(10, 7, 10, 7);
            textBoxInputMessage.PasswordChar = false;
            textBoxInputMessage.PlaceholderColor = Color.DarkGray;
            textBoxInputMessage.PlaceholderText = "채팅을 입력해주세요!";
            textBoxInputMessage.Size = new Size(934, 36);
            textBoxInputMessage.TabIndex = 28;
            textBoxInputMessage.Texts = "";
            textBoxInputMessage.UnderlinedStyle = false;
            // 
            // realtimeChatDetailForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 600);
            Controls.Add(customGroupBox1);
            Margin = new Padding(4);
            Name = "realtimeChatDetailForm";
            Text = "realtimeChatDetailForm";
            FormClosing += realtimeChatDetailForm_FormClosing;
            Leave += realtimeChatDetailForm_Leave;
            customGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxChatBox;
        private CustomTextBox textBoxInputMessage;
        private CustomButtonStyle buttonSendMessage;
        private CustomGroupBox customGroupBox1;
    }
}
using deepcheesebacon.Customizing;

namespace deepcheesebacon
{
    partial class MessageDetailForm
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
            textBoxInputMessage = new TextBox();
            buttonSendMessage = new CustomButtonStyle();
            label1 = new Label();
            label2 = new Label();
            buttonRefresh = new CustomButtonStyle();
            SuspendLayout();
            // 
            // listBoxChatBox
            // 
            listBoxChatBox.ForeColor = Color.Black;
            listBoxChatBox.FormattingEnabled = true;
            listBoxChatBox.ItemHeight = 20;
            listBoxChatBox.Location = new Point(149, 36);
            listBoxChatBox.Margin = new Padding(4);
            listBoxChatBox.Name = "listBoxChatBox";
            listBoxChatBox.Size = new Size(336, 444);
            listBoxChatBox.TabIndex = 0;
            // 
            // textBoxInputMessage
            // 
            textBoxInputMessage.Location = new Point(149, 516);
            textBoxInputMessage.Margin = new Padding(4);
            textBoxInputMessage.Name = "textBoxInputMessage";
            textBoxInputMessage.Size = new Size(336, 27);
            textBoxInputMessage.TabIndex = 1;
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
            buttonSendMessage.Location = new Point(522, 515);
            buttonSendMessage.Margin = new Padding(4);
            buttonSendMessage.Name = "buttonSendMessage";
            buttonSendMessage.Size = new Size(96, 31);
            buttonSendMessage.TabIndex = 2;
            buttonSendMessage.Text = "전송";
            buttonSendMessage.TextColor = Color.DarkBlue;
            buttonSendMessage.UseVisualStyleBackColor = false;
            buttonSendMessage.Click += buttonSendMessage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 520);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 3;
            label1.Text = "메시지 입력";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 12);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "대화창";
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = SystemColors.Window;
            buttonRefresh.BackgroundColor = SystemColors.Window;
            buttonRefresh.BorderColor = Color.FromArgb(4, 96, 217);
            buttonRefresh.BorderRadius = 10;
            buttonRefresh.BorderSize = 2;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.ForeColor = Color.DarkBlue;
            buttonRefresh.Location = new Point(522, 425);
            buttonRefresh.Margin = new Padding(4);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(96, 56);
            buttonRefresh.TabIndex = 5;
            buttonRefresh.Text = "새로고침";
            buttonRefresh.TextColor = Color.DarkBlue;
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // MessageDetailForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 881);
            Controls.Add(buttonRefresh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSendMessage);
            Controls.Add(textBoxInputMessage);
            Controls.Add(listBoxChatBox);
            Margin = new Padding(4);
            Name = "MessageDetailForm";
            Text = "]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxChatBox;
        private TextBox textBoxInputMessage;
        private Label label1;
        private Label label2;
        private CustomButtonStyle buttonSendMessage;
        private CustomButtonStyle buttonRefresh;
    }
}
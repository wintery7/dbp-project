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
            textBoxInputMessage = new TextBox();
            buttonSendMessage = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBoxChatBox
            // 
            listBoxChatBox.FormattingEnabled = true;
            listBoxChatBox.ItemHeight = 15;
            listBoxChatBox.Location = new Point(126, 33);
            listBoxChatBox.Name = "listBoxChatBox";
            listBoxChatBox.Size = new Size(262, 334);
            listBoxChatBox.TabIndex = 6;
            // 
            // textBoxInputMessage
            // 
            textBoxInputMessage.Location = new Point(126, 393);
            textBoxInputMessage.Name = "textBoxInputMessage";
            textBoxInputMessage.Size = new Size(262, 23);
            textBoxInputMessage.TabIndex = 7;
            // 
            // buttonSendMessage
            // 
            buttonSendMessage.Location = new Point(416, 392);
            buttonSendMessage.Name = "buttonSendMessage";
            buttonSendMessage.Size = new Size(75, 23);
            buttonSendMessage.TabIndex = 8;
            buttonSendMessage.Text = "전송";
            buttonSendMessage.UseVisualStyleBackColor = true;
            buttonSendMessage.Click += buttonSendMessage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 396);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 9;
            label1.Text = "메시지 입력";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 15);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "대화창";
            // 
            // realtimeChatDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSendMessage);
            Controls.Add(textBoxInputMessage);
            Controls.Add(listBoxChatBox);
            Name = "realtimeChatDetailForm";
            Text = "realtimeChatDetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxChatBox;
        private TextBox textBoxInputMessage;
        private Button buttonSendMessage;
        private Label label1;
        private Label label2;
    }
}
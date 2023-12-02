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
            listBoxChatBox = new System.Windows.Forms.ListBox();
            textBoxInputMessage = new System.Windows.Forms.TextBox();
            buttonSendMessage = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            buttonRefresh = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBoxChatBox
            // 
            listBoxChatBox.FormattingEnabled = true;
            listBoxChatBox.ItemHeight = 15;
            listBoxChatBox.Location = new System.Drawing.Point(116, 27);
            listBoxChatBox.Name = "listBoxChatBox";
            listBoxChatBox.Size = new System.Drawing.Size(262, 334);
            listBoxChatBox.TabIndex = 0;
            // 
            // textBoxInputMessage
            // 
            textBoxInputMessage.Location = new System.Drawing.Point(116, 387);
            textBoxInputMessage.Name = "textBoxInputMessage";
            textBoxInputMessage.Size = new System.Drawing.Size(262, 23);
            textBoxInputMessage.TabIndex = 1;
            // 
            // buttonSendMessage
            // 
            buttonSendMessage.Location = new System.Drawing.Point(406, 386);
            buttonSendMessage.Name = "buttonSendMessage";
            buttonSendMessage.Size = new System.Drawing.Size(75, 23);
            buttonSendMessage.TabIndex = 2;
            buttonSendMessage.Text = "전송";
            buttonSendMessage.UseVisualStyleBackColor = true;
            buttonSendMessage.Click += buttonSendMessage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(39, 390);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 15);
            label1.TabIndex = 3;
            label1.Text = "메시지 입력";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(116, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "대화창";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new System.Drawing.Point(406, 319);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(75, 42);
            buttonRefresh.TabIndex = 5;
            buttonRefresh.Text = "새로고침";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // MessageDetailForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1084, 661);
            Controls.Add(buttonRefresh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSendMessage);
            Controls.Add(textBoxInputMessage);
            Controls.Add(listBoxChatBox);
            Name = "MessageDetailForm";
            Text = "]";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxChatBox;
        private System.Windows.Forms.TextBox textBoxInputMessage;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
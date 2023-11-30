using System;

namespace deepcheesebacon
{
    partial class MessageLobbyForm
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
            listBoxMessageList = new ListBox();
            label1 = new Label();
            buttonRealTimeChat = new Button();
            label2 = new Label();
            buttonRefresh = new Button();
            SuspendLayout();
            // 
            // listBoxMessageList
            // 
            listBoxMessageList.FormattingEnabled = true;
            listBoxMessageList.ItemHeight = 15;
            listBoxMessageList.Location = new Point(32, 54);
            listBoxMessageList.Name = "listBoxMessageList";
            listBoxMessageList.Size = new Size(513, 499);
            listBoxMessageList.TabIndex = 0;
            listBoxMessageList.Click += listBoxMessageList_Click;
            listBoxMessageList.SelectedIndexChanged += listBoxMessageList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "대화상대목록";
            // 
            // buttonRealTimeChat
            // 
            buttonRealTimeChat.Location = new Point(561, 434);
            buttonRealTimeChat.Name = "buttonRealTimeChat";
            buttonRealTimeChat.Size = new Size(135, 119);
            buttonRealTimeChat.TabIndex = 2;
            buttonRealTimeChat.Text = "실시간 채팅방 입장";
            buttonRealTimeChat.UseVisualStyleBackColor = true;
            buttonRealTimeChat.Click += buttonRealTimeChat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 24);
            label2.Name = "label2";
            label2.Size = new Size(235, 15);
            label2.TabIndex = 3;
            label2.Text = "쪽지 리스트 더블 클릭시 해당 쪽지로 이동";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(561, 54);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(155, 35);
            buttonRefresh.TabIndex = 4;
            buttonRefresh.Text = "쪽지 목록 새로고침";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // MessageLobbyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 763);
            Controls.Add(buttonRefresh);
            Controls.Add(label2);
            Controls.Add(buttonRealTimeChat);
            Controls.Add(label1);
            Controls.Add(listBoxMessageList);
            Name = "MessageLobbyForm";
            Text = "MessageLobbyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListBox listBoxMessageList;
        private Label label1;
        private Button buttonRealTimeChat;
        private Label label2;
        private Button buttonRefresh;
    }
}
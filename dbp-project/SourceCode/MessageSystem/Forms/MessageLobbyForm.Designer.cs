using System;

namespace DeepCheeseBacon.SourceCode.MessageSystem
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
            listBoxMessageList = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            buttonRealTimeChat = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            buttonRefresh = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBoxMessageList
            // 
            listBoxMessageList.FormattingEnabled = true;
            listBoxMessageList.ItemHeight = 15;
            listBoxMessageList.Location = new System.Drawing.Point(271, 75);
            listBoxMessageList.Name = "listBoxMessageList";
            listBoxMessageList.Size = new System.Drawing.Size(513, 499);
            listBoxMessageList.TabIndex = 0;
            listBoxMessageList.Click += listBoxMessageList_Click;
            listBoxMessageList.SelectedIndexChanged += listBoxMessageList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(271, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "쪽지 목록";
            // 
            // buttonRealTimeChat
            // 
            buttonRealTimeChat.Location = new System.Drawing.Point(869, 455);
            buttonRealTimeChat.Name = "buttonRealTimeChat";
            buttonRealTimeChat.Size = new System.Drawing.Size(135, 119);
            buttonRealTimeChat.TabIndex = 2;
            buttonRealTimeChat.Text = "실시간 채팅방 입장";
            buttonRealTimeChat.UseVisualStyleBackColor = true;
            buttonRealTimeChat.Click += buttonRealTimeChat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(549, 45);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(235, 15);
            label2.TabIndex = 3;
            label2.Text = "쪽지 리스트 더블 클릭시 해당 쪽지로 이동";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new System.Drawing.Point(800, 75);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(155, 35);
            buttonRefresh.TabIndex = 4;
            buttonRefresh.Text = "쪽지 목록 새로고침";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // MessageLobbyForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1084, 661);
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

        private System.Windows.Forms.ListBox listBoxMessageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRealTimeChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
using deepcheesebacon.Work;
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

            buttonRealTimeChat = new CustomButtonStyle();
            customGroupBox2 = new CustomGroupBox();
            refreshButton = new deepcheesebacon.ImageButton();
            customGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxMessageList
            // 
            listBoxMessageList.FormattingEnabled = true;

            listBoxMessageList.ItemHeight = 20;
            listBoxMessageList.Location = new Point(20, 54);
            listBoxMessageList.Margin = new Padding(4);
            listBoxMessageList.Name = "listBoxMessageList";
            listBoxMessageList.Size = new Size(829, 444);
            listBoxMessageList.TabIndex = 0;
            listBoxMessageList.Click += listBoxMessageList_Click;
            // 
            // buttonRealTimeChat
            // 
            buttonRealTimeChat.BackColor = Color.FromArgb(94, 159, 242);
            buttonRealTimeChat.BackgroundColor = Color.FromArgb(94, 159, 242);
            buttonRealTimeChat.BorderColor = Color.PaleVioletRed;
            buttonRealTimeChat.BorderRadius = 20;
            buttonRealTimeChat.BorderSize = 0;
            buttonRealTimeChat.FlatStyle = FlatStyle.Flat;
            buttonRealTimeChat.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRealTimeChat.ForeColor = Color.White;
            buttonRealTimeChat.Location = new Point(675, 506);
            buttonRealTimeChat.Margin = new Padding(4);
            buttonRealTimeChat.Name = "buttonRealTimeChat";
            buttonRealTimeChat.Size = new Size(174, 35);
            buttonRealTimeChat.TabIndex = 2;
            buttonRealTimeChat.Text = "실시간 채팅방 입장";
            buttonRealTimeChat.TextColor = Color.White;
            buttonRealTimeChat.UseVisualStyleBackColor = false;
            buttonRealTimeChat.Click += buttonRealTimeChat_Click;
            // 
            // customGroupBox2
            // 

            customGroupBox2.BackColor = Color.Transparent;
            customGroupBox2.Controls.Add(refreshButton);
            customGroupBox2.Controls.Add(listBoxMessageList);
            customGroupBox2.Controls.Add(buttonRealTimeChat);
            customGroupBox2.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customGroupBox2.Location = new Point(41, 36);
            customGroupBox2.Margin = new Padding(4);
            customGroupBox2.Name = "customGroupBox2";
            customGroupBox2.Padding = new Padding(4);
            customGroupBox2.Radious = 25;
            customGroupBox2.Size = new Size(871, 549);
            customGroupBox2.TabIndex = 29;
            customGroupBox2.TabStop = false;
            customGroupBox2.Text = "Message";
            customGroupBox2.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox2.TitleFont = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox2.TitleForeColor = Color.White;
            customGroupBox2.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // refreshButton
            // 

            refreshButton.BackgroundImage = deepcheesebacon.Properties.Resources.refresh;
            refreshButton.BackgroundImageLayout = ImageLayout.Zoom;
            refreshButton.Image_01 = deepcheesebacon.Properties.Resources.refresh;
            refreshButton.Image_02 = deepcheesebacon.Properties.Resources.refreshoption;
            refreshButton.Location = new Point(840, 5);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(23, 26);
            refreshButton.TabIndex = 5;
            refreshButton.Click += refreshbutton_click;
            // 
            // MessageLobbyForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 616);
            Controls.Add(customGroupBox2);
            Margin = new Padding(4);
            Name = "MessageLobbyForm";
            Text = "MessageLobbyForm";
            customGroupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListBox listBoxMessageList;

        private CustomGroupBox customGroupBox2;
        private deepcheesebacon.ImageButton refreshButton;
        private CustomButtonStyle buttonRealTimeChat;
    }
}
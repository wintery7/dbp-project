using deepcheesebacon.Customizing;
using deepcheesebacon.work;
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
            buttonRealNameChat = new CustomButtonStyle();
            customButtonStyle1 = new CustomButtonStyle();
            refreshButton = new ImageButton();
            customGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxMessageList
            // 
            listBoxMessageList.FormattingEnabled = true;
            listBoxMessageList.ItemHeight = 20;
            listBoxMessageList.Location = new Point(21, 53);
            listBoxMessageList.Margin = new Padding(4, 4, 4, 4);
            listBoxMessageList.Name = "listBoxMessageList";
            listBoxMessageList.Size = new Size(850, 464);
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
            buttonRealTimeChat.Location = new Point(662, 538);
            buttonRealTimeChat.Margin = new Padding(4, 4, 4, 4);
            buttonRealTimeChat.Name = "buttonRealTimeChat";
            buttonRealTimeChat.Size = new Size(209, 35);
            buttonRealTimeChat.TabIndex = 2;
            buttonRealTimeChat.Text = "실시간 익명 채팅방 입장";
            buttonRealTimeChat.TextColor = Color.White;
            buttonRealTimeChat.UseVisualStyleBackColor = false;
            buttonRealTimeChat.Click += buttonRealTimeChat_Click;
            // 
            // customGroupBox2
            // 
            customGroupBox2.BackColor = Color.Transparent;
            customGroupBox2.Controls.Add(buttonRealNameChat);
            customGroupBox2.Controls.Add(customButtonStyle1);
            customGroupBox2.Controls.Add(refreshButton);
            customGroupBox2.Controls.Add(listBoxMessageList);
            customGroupBox2.Controls.Add(buttonRealTimeChat);
            customGroupBox2.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customGroupBox2.Location = new Point(41, 36);
            customGroupBox2.Margin = new Padding(4, 4, 4, 4);
            customGroupBox2.Name = "customGroupBox2";
            customGroupBox2.Padding = new Padding(4, 4, 4, 4);
            customGroupBox2.Radious = 25;
            customGroupBox2.Size = new Size(892, 591);
            customGroupBox2.TabIndex = 29;
            customGroupBox2.TabStop = false;
            customGroupBox2.Text = "Message";
            customGroupBox2.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox2.TitleFont = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox2.TitleForeColor = Color.White;
            customGroupBox2.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // buttonRealNameChat
            // 
            buttonRealNameChat.BackColor = Color.FromArgb(94, 159, 242);
            buttonRealNameChat.BackgroundColor = Color.FromArgb(94, 159, 242);
            buttonRealNameChat.BorderColor = Color.PaleVioletRed;
            buttonRealNameChat.BorderRadius = 20;
            buttonRealNameChat.BorderSize = 0;
            buttonRealNameChat.FlatStyle = FlatStyle.Flat;
            buttonRealNameChat.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRealNameChat.ForeColor = Color.White;
            buttonRealNameChat.Location = new Point(354, 538);
            buttonRealNameChat.Margin = new Padding(4, 4, 4, 4);
            buttonRealNameChat.Name = "buttonRealNameChat";
            buttonRealNameChat.Size = new Size(209, 35);
            buttonRealNameChat.TabIndex = 7;
            buttonRealNameChat.Text = "실시간 채팅방 입장";
            buttonRealNameChat.TextColor = Color.White;
            buttonRealNameChat.UseVisualStyleBackColor = false;
            buttonRealNameChat.Click += buttonRealNameChat_Click;
            // 
            // customButtonStyle1
            // 
            customButtonStyle1.BackColor = Color.FromArgb(94, 159, 242);
            customButtonStyle1.BackgroundColor = Color.FromArgb(94, 159, 242);
            customButtonStyle1.BorderColor = Color.PaleVioletRed;
            customButtonStyle1.BorderRadius = 20;
            customButtonStyle1.BorderSize = 0;
            customButtonStyle1.FlatStyle = FlatStyle.Flat;
            customButtonStyle1.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            customButtonStyle1.ForeColor = Color.White;
            customButtonStyle1.Location = new Point(20, 538);
            customButtonStyle1.Margin = new Padding(4, 4, 4, 4);
            customButtonStyle1.Name = "customButtonStyle1";
            customButtonStyle1.Size = new Size(209, 35);
            customButtonStyle1.TabIndex = 6;
            customButtonStyle1.Text = "받은 쪽지 모아보기";
            customButtonStyle1.TextColor = Color.White;
            customButtonStyle1.UseVisualStyleBackColor = false;
            customButtonStyle1.Click += customButtonStyle1_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackgroundImage = Properties.Resources.refresh;
            refreshButton.BackgroundImageLayout = ImageLayout.Zoom;
            refreshButton.Image_01 = Properties.Resources.refresh;
            refreshButton.Image_02 = Properties.Resources.refreshoption;
            refreshButton.Location = new Point(858, 5);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(23, 27);
            refreshButton.TabIndex = 5;
            refreshButton.Click += refreshbutton_click;
            // 
            // MessageLobbyForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 659);
            Controls.Add(customGroupBox2);
            Margin = new Padding(4, 4, 4, 4);
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
        private ImageButton refreshButton;
        private CustomButtonStyle buttonRealTimeChat;
        private CustomButtonStyle customButtonStyle1;
        private CustomButtonStyle buttonRealNameChat;
    }
}
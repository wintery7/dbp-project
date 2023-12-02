namespace deepcheesebacon
{
    partial class realtimeChatRobby
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
            customGroupBox2 = new Work.CustomGroupBox();
            label1 = new Label();
            textBoxRoomName = new TextBox();
            buttonCreateChatRoom = new Work.CustomButtonStyle();
            listBoxMessageList = new ListBox();
            label2 = new Label();
            textBoxNickName = new TextBox();
            customGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // customGroupBox2
            // 
            customGroupBox2.BackColor = Color.Transparent;
            customGroupBox2.Controls.Add(textBoxNickName);
            customGroupBox2.Controls.Add(label2);
            customGroupBox2.Controls.Add(label1);
            customGroupBox2.Controls.Add(textBoxRoomName);
            customGroupBox2.Controls.Add(buttonCreateChatRoom);
            customGroupBox2.Controls.Add(listBoxMessageList);
            customGroupBox2.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            customGroupBox2.Location = new Point(62, 19);
            customGroupBox2.Name = "customGroupBox2";
            customGroupBox2.Radious = 25;
            customGroupBox2.Size = new Size(677, 412);
            customGroupBox2.TabIndex = 30;
            customGroupBox2.TabStop = false;
            customGroupBox2.Text = "실시간 채팅방";
            customGroupBox2.TitleBackColor = Color.FromArgb(94, 159, 242);
            customGroupBox2.TitleFont = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customGroupBox2.TitleForeColor = Color.White;
            customGroupBox2.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 383);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 5;
            label1.Text = "생성할 채팅방 이름";
            // 
            // textBoxRoomName
            // 
            textBoxRoomName.Location = new Point(349, 380);
            textBoxRoomName.Name = "textBoxRoomName";
            textBoxRoomName.Size = new Size(203, 23);
            textBoxRoomName.TabIndex = 4;
            // 
            // buttonCreateChatRoom
            // 
            buttonCreateChatRoom.BackColor = Color.FromArgb(94, 159, 242);
            buttonCreateChatRoom.BackgroundColor = Color.FromArgb(94, 159, 242);
            buttonCreateChatRoom.BorderColor = Color.PaleVioletRed;
            buttonCreateChatRoom.BorderRadius = 20;
            buttonCreateChatRoom.BorderSize = 0;
            buttonCreateChatRoom.FlatStyle = FlatStyle.Flat;
            buttonCreateChatRoom.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreateChatRoom.ForeColor = Color.White;
            buttonCreateChatRoom.Location = new Point(558, 380);
            buttonCreateChatRoom.Name = "buttonCreateChatRoom";
            buttonCreateChatRoom.Size = new Size(104, 26);
            buttonCreateChatRoom.TabIndex = 3;
            buttonCreateChatRoom.Text = "채팅방 생성";
            buttonCreateChatRoom.TextColor = Color.White;
            buttonCreateChatRoom.UseVisualStyleBackColor = false;
            buttonCreateChatRoom.Click += buttonCreateChatRoom_Click;
            // 
            // listBoxMessageList
            // 
            listBoxMessageList.FormattingEnabled = true;
            listBoxMessageList.ItemHeight = 15;
            listBoxMessageList.Location = new Point(16, 40);
            listBoxMessageList.Name = "listBoxMessageList";
            listBoxMessageList.Size = new Size(646, 334);
            listBoxMessageList.TabIndex = 0;
            listBoxMessageList.SelectedIndexChanged += listBoxMessageList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 383);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 6;
            label2.Text = "사용할 별명";
            // 
            // textBoxNickName
            // 
            textBoxNickName.Location = new Point(83, 380);
            textBoxNickName.Name = "textBoxNickName";
            textBoxNickName.Size = new Size(143, 23);
            textBoxNickName.TabIndex = 7;
            // 
            // realtimeChatRobby
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customGroupBox2);
            Name = "realtimeChatRobby";
            Text = "realtimeChatRobby";
            customGroupBox2.ResumeLayout(false);
            customGroupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Work.CustomGroupBox customGroupBox2;
        private ListBox listBoxMessageList;
        private Work.CustomButtonStyle buttonCreateChatRoom;
        private Label label1;
        private TextBox textBoxRoomName;
        private Label label2;
        private TextBox textBoxNickName;
    }
}
using DeepCheeseBacon.SourceCode.ApprovalSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeepCheeseBacon.SourceCode.MessageSystem.Forms
{
    public partial class MessageDetailForm : Form
    {
        DBManager dbManager;
        MyInfo myinfo;
        string opponentUserEmail;
        int opponentUserId;

        public MessageDetailForm()
        {
            InitializeComponent();
            dbManager = DBManager.GetDBManager();
            myinfo = MyInfo.GetMyInfo();
            LoadMessage();
        }

        public MessageDetailForm(string opponentUserEmail)
        {
            InitializeComponent();
            dbManager = DBManager.GetDBManager();
            myinfo = MyInfo.GetMyInfo();
            this.opponentUserEmail = opponentUserEmail;
            opponentUserId = ((User)dbManager.GetUserByEmail(opponentUserEmail)).UserId;
            LoadMessage();
        }

        private void LoadMessage()
        {
            opponentUserId = 3; // 테스트용
            List<Message> messageList = dbManager.GetMessagesById(myinfo.userId, opponentUserId);

            listBoxChatBox.Items.Clear();

            foreach (Message message in messageList)
            {
                string displayMessage;

                if (message.senderId == myinfo.userId)
                {
                    displayMessage = $"{message.content}";
                    int spacesCount = Math.Max(0, 50 - displayMessage.Length); // 길이가 음수가 되지 않도록 Math.Max 사용
                    listBoxChatBox.Items.Add(new String(' ', spacesCount) + displayMessage);
                }
                else
                {
                    displayMessage = $"상대: {message.content}";
                    listBoxChatBox.Items.Add(displayMessage);
                }

            }

            textBoxInputMessage.Clear();
            listBoxChatBox.SelectedIndex = listBoxChatBox.Items.Count - 1;

        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            dbManager.SaveMessage(new Message
            {
                senderId = myinfo.userId,
                receiverId = 3, //  테스트용으로 3을 넣었음 원래는 receiverId = opponentUserId, 가 들어가야 됨
                content = textBoxInputMessage.Text,
            });
            LoadMessage();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadMessage();
        }
    }
}

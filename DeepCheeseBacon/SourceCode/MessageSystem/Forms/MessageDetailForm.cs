using deepcheesebacon;
using deepcheesebacon.SourceCode.ApprovalSystem.Models;
using deepcheesebacon.SourceCode.MessageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Message = deepcheesebacon.SourceCode.MessageSystem.Models.Message;

namespace deepcheesebacon
{
    public partial class MessageDetailForm : Form
    {
        DBManager dbManager;
        LoginedUserInfo myinfo;
        string opponentUserEmail;
        int opponentUserId;

        public MessageDetailForm(string opponentUserEmail)
        {
            InitializeComponent();
            dbManager = DBManager.GetInstance();
            myinfo = LoginedUserInfo.GetMyInfo();
            this.opponentUserEmail = opponentUserEmail;
            opponentUserId = ((User)dbManager.GetUserByEmail(opponentUserEmail)).UserId;
            Console.WriteLine("otherUserId and email: " + opponentUserId + opponentUserEmail);
            LoadMessage();
        }

        private void LoadMessage()
        {

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
                receiverId = opponentUserId,
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

using DeepCheeseBacon.SourceCode.ApprovalSystem;
using DeepCheeseBacon.SourceCode.MessageSystem.BusinessLogic;
using DeepCheeseBacon.SourceCode.MessageSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeepCheeseBacon.SourceCode.MessageSystem
{
    public partial class MessageLobbyForm : Form
    {
        MessageService messageService;
        DBManager dBManager;
        Dictionary<int, User> userDitionary;
        public MessageLobbyForm()
        {
            InitializeComponent();

            messageService = new MessageService();

            LoadChattingList();
        }

        private void LoadChattingList()
        {
            List<string> chattingList = messageService.GetChattingList();

            listBoxMessageList.Items.Clear();

            foreach (string email in chattingList)
            {
                listBoxMessageList.Items.Add(email);
            }
        }

        private void listBoxMessageList_Click(object sender, EventArgs e)
        {
            if (listBoxMessageList.SelectedIndex > -1) // 대화목록에서 선택된 값이 있다면
            {
                MessageDetailForm messageDetailForm = new MessageDetailForm(listBoxMessageList.SelectedItem.ToString());
                messageDetailForm.ShowDialog();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadChattingList();
        }

        private void buttonRealTimeChat_Click(object sender, EventArgs e)
        {
            // 실시간 채팅으로 넘어가는 코드 추가
        }

        private void listBoxMessageList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

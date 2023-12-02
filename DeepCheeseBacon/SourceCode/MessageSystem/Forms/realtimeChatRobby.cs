using deepcheesebacon.SourceCode.MessageSystem.Forms;
using deepcheesebacon.SourceCode.MessageSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deepcheesebacon
{
    public partial class realtimeChatRobby : Form
    {
        List<ChatRoom> chatRooms;

        public realtimeChatRobby()
        {
            InitializeComponent();
            LoadChatList();
        }

        async Task LoadChatList()
        {
            await Task.Delay(1000); // 3초 지연

            // ChatRooms를 비동기적으로 받아옴
            chatRooms = await ApiManager.GetChatRoomsAsync();

            listBoxMessageList.Items.Clear();

            // 받아온 채팅방들에 대한 처리
            if (chatRooms != null)
            {
                foreach (var chatRoom in chatRooms)
                {
                    Console.WriteLine($"Chat room retrieved with ID: {chatRoom.RoomId} name: {chatRoom.Name}");

                    listBoxMessageList.Items.Add(chatRoom);
                }
            }
            else
            {
                Console.WriteLine("Failed to retrieve chat rooms.");
            }
        }

        private void listBoxMessageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMessageList.SelectedIndex != -1)
            {
                if (textBoxNickName.Text == null || textBoxNickName.Text.Equals(""))
                {
                    MessageBox.Show("사용할 별명을 입력해주세요");
                    return;
                }

                realtimeChatDetailForm form = new realtimeChatDetailForm(((ChatRoom)listBoxMessageList.SelectedItem).RoomId, textBoxNickName.Text);
                form.ShowDialog();
            }
        }

        private void buttonCreateChatRoom_Click(object sender, EventArgs e)
        {
            

            if (textBoxRoomName.Text != null && !textBoxRoomName.Text.Equals(""))
            {
                ApiManager.CreateChatRoomAsync(textBoxRoomName.Text);
                LoadChatList();
                textBoxRoomName.Clear();
                MessageBox.Show("채팅방 생성 완료");
            }
            else
            {
                MessageBox.Show("생성할 채팅방 이름을 입력해주세요.");
            }
        }
    }
}

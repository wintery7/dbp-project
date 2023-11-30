using deepcheesebacon.SourceCode.MessageSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using deepcheesebacon.SourceCode.ApprovalSystem.DataAccess;

namespace deepcheesebacon
{
    internal class ApiManager
    {
        public static async Task CreateChatRoomAsync(int userId, int opponentUserId)
        {
            string roomName = "roomName";
            DBManager db = DBManager.GetDBManager();

            using (HttpClient client = new HttpClient())
            {
                // 생성할 채팅방 객체 생성
                ChatRoom chatRoom = new ChatRoom { Name = roomName };

                // ChatRoom 객체를 JSON 문자열로 변환
                string jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(chatRoom);

                Console.WriteLine("api 실행");
                // 서버의 ChatController에 POST 요청을 보냄
                HttpResponseMessage response = await client.PostAsync("http://34.64.78.183:9090/chat",
                    new StringContent(jsonContent, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    // 응답으로 받은 데이터를 문자열로 변환
                    string responseData = await response.Content.ReadAsStringAsync();

                    // 문자열을 ChatRoom 객체로 변환 (이 부분은 서버에서 어떤 형식으로 응답하는지에 따라 수정 필요)
                    // 예제로 ChatRoom 클래스가 있다고 가정
                    ChatRoom createdChatRoom = Newtonsoft.Json.JsonConvert.DeserializeObject<ChatRoom>(responseData);

                    // 생성된 채팅방 정보를 사용하여 UI를 구성하거나 필요한 작업 수행
                    Console.WriteLine($"Room created with ID: {createdChatRoom.RoomId}");
                    db.SaveRealChatRoomId(createdChatRoom.RoomId, userId, opponentUserId);

                }
                else
                {
                    Console.WriteLine($"Failed to create chat room. Status code: {response.StatusCode}");
                }
            }
        }
    }
}

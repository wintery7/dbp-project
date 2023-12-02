using MySqlX.XDevAPI;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deepcheesebacon.SourceCode.MessageSystem.Models
{
    public class ChatRoom
    {
        public string RoomId { get; set; }
        public string Name { get; set; }


        public override String ToString()
        {
            string jsonString = Name;

            // JSON 문자열을 JObject로 파싱
            JObject jsonObject = JObject.Parse(jsonString);

            // "Name" 속성 값 얻기
            string nameValue = (string)jsonObject["Name"];

            Console.WriteLine("ToString 실행" + nameValue); // 출력: qq        }

            return nameValue;
        }
    }
}

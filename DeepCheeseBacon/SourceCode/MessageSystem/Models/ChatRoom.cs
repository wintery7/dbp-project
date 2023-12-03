using MySqlX.XDevAPI;
using Newtonsoft.Json;
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

            if(Name != null)
            {
                try
                {
                    JObject jsonObject = JObject.Parse(jsonString);

                    // "Name" 속성 값 얻기
                    string nameValue = (string)jsonObject["Name"];

                    return nameValue;
                }
                catch (JsonReaderException)
                {
                    string modifiedString = jsonString.Replace("\"", "");
                    Console.WriteLine(modifiedString);


                    // JSON 파싱 중 에러가 발생하면 그냥 입력된 문자열 그대로 반환
                    return modifiedString;
                }
            }
            Console.WriteLine("빈 문자열 반환");
            return "";
        }
    }
}

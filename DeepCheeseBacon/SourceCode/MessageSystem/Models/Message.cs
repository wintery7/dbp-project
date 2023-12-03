using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace deepcheesebacon
{
    public class Message
    {
        public int senderId { get; set; }
        public int receiverId { get; set; }
        public string content { get; set; }
        public DateTime sentAt { get; set; }

        public override string ToString()
        {
            DBManager db = DBManager.GetInstance();

            string senderEmail = db.GetEmailByUserId(senderId);
            if(senderEmail == null) 
            {
                return "보낸 사람을 찾을 수 없는 메시지입니다.";
            }

            return $"보낸사람: {senderEmail} || 내용: {content}";
        }
    }

    
}

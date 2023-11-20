using System;
using System.Collections.Generic;
using System.Text;

namespace deepcheesebacon.SourceCode.MessageSystem.Models
{
    public class Message
    {
        public int senderId { get; set; }
        public int receiverId { get; set; }
        public string content { get; set; }
        public DateTime sentAt { get; set; }

    }
}

using System;
using WebSocketSharp;

namespace DeepCheeseBacon.SourceCode.RealTimeChatSystem
{
   

    public class RealTimeChatClient
    {
        private WebSocket webSocket;
        private string serverUrl = "ws://localhost:8080/ws"; // WebSocket 서버 주소

        public RealTimeChatClient()
        {
            StartConnection();
        }

        public void StartConnection()
        {
            webSocket = new WebSocketSharp.WebSocket(serverUrl);

            webSocket.OnOpen += (sender, e) =>
            {
                Console.WriteLine("Connected to the server.");
            };

            webSocket.OnMessage += (sender, e) =>
            {
                if (e.IsText)
                {
                    Console.WriteLine("Received: " + e.Data);
                }
            };

            webSocket.OnClose += (sender, e) =>
            {
                Console.WriteLine("Connection closed.");
            };

            webSocket.Connect();
        }

        public void SendMessage(string message)
        {
            if (webSocket.ReadyState == WebSocketState.Open)
            {
                webSocket.Send(message);
            }
        }
    }

    
}

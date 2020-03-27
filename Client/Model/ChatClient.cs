using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    public class ChatClient : IChatClient
    {
        public Messaging messaging;
        string fullMessage;

        //Set Messages
        public void SendMessageInternal(string fullMessage)
        {
            this.fullMessage = fullMessage;
            ClientSendMessageToServer();
        }
        public string ClientSendMessageToServer()
        {
            return fullMessage;
        }

        //Get Messages
        public void ReceiveMessageFromServer(string fullMessage)
        {
            this.fullMessage = fullMessage;
            messaging.PrintMessageInChatRoom();
        }

        public string ReceiveMessageIntern()
        {
            return fullMessage;
        }

        public void GetClientNumber(int clientNumber)
        {
            messaging.SaveClientNumber(clientNumber);
        }
    }
}

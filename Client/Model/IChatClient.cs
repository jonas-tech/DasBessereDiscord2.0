using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    public interface IChatClient
    {
        void GetClientNumber(int ClientNumber);
        //Set Messages
        string ClientSendMessageToServer();
        //Get Messages
        void ReceiveMessageFromServer(string fullMessage);
    }
}

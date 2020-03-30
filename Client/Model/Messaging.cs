using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Client.Proxy;

namespace ChatClient

{
    public class Messaging
    {

        
        string userMessage;
        string fullMessage;
        public Server server;
        public ChatClient client;
        public ViewModelMessageing viewModelMessageing;
        InstanceContext context;
        
        public Messaging()
        {
            client = new ChatClient() { messaging = this };
            server = new Server() { messaging = this };
            context = new InstanceContext(new Server());
        }
        #region LogIn
        string userName;
        int clientNumber;
        public void LogInAndSaveUserName(string userName)
        {
            
            this.userName = userName;
            server.ClientLogIntoServer(true);
        }
        public void SaveClientNumber(int clientNumber)
        {
            this.clientNumber = clientNumber;
        }
        #endregion
        #region SenduserMessage
        public void GetUserMessage(string userMessage)
        {
            this.userMessage = userMessage;
            CreateFullMessage();
        }

        public void CreateFullMessage()
        {
            string dateTime = DateTime.Now.ToString();
            this.fullMessage = dateTime + " von " + userName + " : " + userMessage;
            SendFullMessageToInterfaces();
        }

        public void SendFullMessageToInterfaces()
        {
            client.SendMessageInternal(fullMessage);
            server.ServerGetMessageFromClient(fullMessage);
        }
        #endregion
        #region ReceiveMessageFromServer
        public string serverMessage;
        public void ReceiveMEssagesFromInterfaces()
        {
            serverMessage =  server.ServerSendMessageToClient();
            PrintMessageInChatRoom();
        }
        public void PrintMessageInChatRoom()
        {
            this.serverMessage = client.ReceiveMessageIntern();
            viewModelMessageing.PrintServerMessageInChatroom();
        }
        #endregion
        #region LogOut
        public void LogOutFromServer()
        {
            server.ClientLogOutOfServer(false,clientNumber);
            this.userName = null;
        }
        #endregion LogOutCo
    }
}

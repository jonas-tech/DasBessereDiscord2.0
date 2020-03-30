using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Client.ViewModel;

namespace Client.Model
{
    public class Messaging
    {
        
        InstanceContext context = new InstanceContext(new ChatClient());
        Proxy.ServiceClient server = new Proxy.ServiceClient(context);
        
        string userMessage;
        string fullMessage;
        public ChatClient client;
        public ViewModelMessageing viewModelMessageing;
        
        #region LogIn
        string userName;
        public void LogInAndSaveUserName(string userName)
        {
            
            this.userName = userName;
            //server.ClientLogIntoServer(userName);
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
            //server.ServerGetMessageFromClient(fullMessage);
        }
        #endregion
        #region ReceiveMessageFromServer
        public string serverMessage;

        public void PrintMessageInChatRoom(string serverMessage)
        {
            this.serverMessage = serverMessage;
            viewModelMessageing.PrintServerMessageInChatroom();
        }
        #endregion
        #region LogOut
        public void LogOutFromServer()
        {
            //server.ClientLogOutOfServer(false,clientNumber);
            this.userName = null;
        }
        #endregion LogOutCo
    }
}

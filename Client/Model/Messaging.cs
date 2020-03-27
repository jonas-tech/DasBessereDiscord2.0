﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient

{
    class Messaging
    {

        
        string userMessage;
        string fullMessage;
        Server server;
        public ChatClient client;
        public ViewModelMessageing viewModelMessageing;
        public Messaging()
        {
            client = new ChatClient() { messaging = this };
            server = new Server() { messaging = this };
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
            this.fullMessage = DateTime.Now.ToString() + " von " + userName + " : " + userMessage;
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
            viewModelMessageing.PrintServerMessageInChatroom(serverMessage);
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

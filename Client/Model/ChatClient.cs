﻿using Client.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class ChatClient : Proxy.IServiceCallback
    {
        public Messaging messaging;


        void IServiceCallback.ServerSendMessageToClient(string serverMessage)
        {
            messaging.PrintMessageInChatRoom(serverMessage);
        }
    }
}

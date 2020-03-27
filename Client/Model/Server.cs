using Client.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    class Server : IService
    {
        public Messaging messaging;

        public void ClientLogIntoServer(bool ClientisLoggedin)
        {
            throw new NotImplementedException();
        }

        public Task ClientLogIntoServerAsync(bool ClientisLoggedin)
        {
            throw new NotImplementedException();
        }

        public void ClientLogOutOfServer(bool ClientisLoggedin, int clientNumber)
        {
            throw new NotImplementedException();
        }

        public Task ClientLogOutOfServerAsync(bool ClientisLoggedin, int clientNumber)
        {
            throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetDataAsync(int value)
        {
            throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }

        public Task<CompositeType> GetDataUsingDataContractAsync(CompositeType composite)
        {
            throw new NotImplementedException();
        }

        public void ServerGetMessageFromClient(string clientMessage)
        {
            throw new NotImplementedException();
        }

        public Task ServerGetMessageFromClientAsync(string clientMessage)
        {
            throw new NotImplementedException();
        }

        public string ServerSendMessageToClient()
        {
            throw new NotImplementedException();
        }

        public Task<string> ServerSendMessageToClientAsync()
        {
            throw new NotImplementedException();
        }
    }
}

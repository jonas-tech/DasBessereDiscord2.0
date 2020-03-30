using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
public class Service : IService
{
    Dictionary<IServiceClient, string> clientUsernames = new Dictionary<IServiceClient, string>();

    string clientMessagecontent = "";

    public void ClientLogIntoServer(string userName)
    {

    }

    public string ServerSendMessageToClient()
    {
        return clientMessagecontent;
    }

    public void ServerGetMessageFromClient(string clientMessage)
    {
        clientMessagecontent = clientMessage;

        IsClientMessageNull(clientMessage);
    }

    public void ClientLogOutOfServer(string userName)
    {
    }

    private void IsClientMessageNull(string clientMessage)
    {
        if (clientMessage == null)
        {
            return;
        }
        else
        {
            ServerSendMessageToClient();
        }
    }
}

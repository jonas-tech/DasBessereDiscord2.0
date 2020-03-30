using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
    private List<Socket> clientSockets = new List<Socket>();

    Socket chatSocket;

    Socket clientSocket;

    IPHostEntry chatIPhost;

    IPAddress clientIPadress;

    IPEndPoint clientIPendPoint;

    int amountOfclients;

    string clientMessagecontent = "";

    public void ClientLogIntoServer(bool ClientisLoggedin)
    {
        if (ClientisLoggedin == true)
        {
            chatIPhost = Dns.GetHostEntry("");

            clientIPadress = chatIPhost.AddressList[0];

            clientIPendPoint = new IPEndPoint(clientIPadress, 53225);

            chatSocket.Bind(clientIPendPoint);

            chatSocket.Listen(2);

            clientSocket.Connect(clientIPendPoint);

            clientSockets.Add(clientSocket);

            amountOfclients++;
        }
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

    public void ClientLogOutOfServer(bool ClientisLoggedin, int clientNumber)
    {
        if (ClientisLoggedin == false)
        {
            clientSockets[clientNumber].Close();

            clientSockets.Remove(clientSockets[clientNumber]);

            amountOfclients--;
        }
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

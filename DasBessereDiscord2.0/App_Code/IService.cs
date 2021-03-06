﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IServiceClient
{
	[OperationContract(IsOneWay = true)]
	void ServerSendMessageToClient(string serverMessage);
}
[ServiceContract(CallbackContract = typeof(IServiceClient))]


public interface IService
{
	// TODO: Add your service operations here
	[OperationContract(IsOneWay =true)]
	void ClientLogIntoServer(string username);


	[OperationContract(IsOneWay =true)]
	void ServerGetMessageFromClient(string clientMessage);

	[OperationContract(IsOneWay =true)]
	void ClientLogOutOfServer(string username);
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cassandra;

/// <summary>
/// Summary description for simpleClient
/// </summary>
public class simpleClient
{
    //public Cluster Cluster { get; private set; }
    Cluster cluster;
    public ISession  Connect()  {

         cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
        ISession session = cluster.Connect("payment");
        return session;
    }

    public simpleClient()
	{
		//
		// TODO: Add constructor logic here
		//
       
	}

    public void Close()
    {
        cluster.Shutdown();
    }
}
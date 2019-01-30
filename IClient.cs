using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    interface IClient
    {
        string GetData();
    }

    /// <summary>
    /// the real subject class
    /// </summary>
    /// <seealso cref="DesignPatterns.IClient" />
    public class RealClient : IClient
    {
        string data;
        public RealClient()
        {
            Console.WriteLine("Real Client: Initialized");
            data = "Dot Net";
        }

        public string GetData()
        {
            return data;
        }
    }

    public class ProxyClient : IClient
    {
        RealClient client = new RealClient();
        public ProxyClient()
        {
            Console.WriteLine("ProxyClient: Initialized");
        }

        public string GetData()
        {
            return client.GetData();
        }
    }
}

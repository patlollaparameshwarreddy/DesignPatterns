//-----------------------------------------------------------------------
// <copyright file="IClient.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// the proxy interface
    /// </summary>
    public interface IClient
    {
        /// <summary>
        /// the abstract method
        /// </summary>
        /// <returns> returns the client data</returns>
        string GetData();
    }

    /// <summary>
    /// the real subject class
    /// </summary>
    /// <seealso cref="DesignPatterns.IClient" />
    public class RealClient : IClient
    {
        /// <summary>
        /// The data
        /// </summary>
       private string data;

        /// <summary>
        /// Initializes a new instance of the <see cref="RealClient"/> class.
        /// </summary>
        public RealClient()
        {
            Console.WriteLine("Real Client: Initialized");
            this.Data = "Dot Net";
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public string Data { get => this.data; set => this.data = value; }

        /// <summary>
        /// the abstract method
        /// </summary>
        /// <returns>returns the data </returns>
        public string GetData()
        {
            return this.Data;
        }
    }

    /// <summary>
    /// this class is the proxy class
    /// </summary>
    /// <seealso cref="DesignPatterns.IClient" />
    public class ProxyClient : IClient
    {
        /// <summary>
        /// The client
        /// </summary>
        private RealClient client = new RealClient();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyClient"/> class.
        /// </summary>
        public ProxyClient()
        {
            Console.WriteLine("ProxyClient: Initialized");
        }

        /// <summary>
        /// the abstract method
        /// </summary>
        /// <returns> returns the client data</returns>
        public string GetData()
        {
            return this.client.GetData();
        }
    }
}

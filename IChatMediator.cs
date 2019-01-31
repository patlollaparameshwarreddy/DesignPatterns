//-----------------------------------------------------------------------
// <copyright file="IChatMediator.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// mediator interface
    /// </summary>
    public interface IChatMediator
    {
        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        void AddUser(IUser user);

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="sender">The sender.</param>
        void SendMessage(string message, IUser sender);
    }

    /// <summary>
    /// Concrete mediator
    /// </summary>
    /// <seealso cref="DesignPatterns.IChatMediator" />
    public class ChatMediator : IChatMediator
    {
        /// <summary>
        /// The users
        /// </summary>
        private List<IUser> users;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMediator"/> class.
        /// </summary>
        public ChatMediator()
        {
            this.Users = new List<IUser>(); 
        }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        public List<IUser> Users { get => this.users; set => this.users = value; }

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void AddUser(IUser user)
        {
            this.Users.Add(user);
        }

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="sender">The sender.</param>
        public void SendMessage(string message, IUser sender)
        {
            foreach (IUser user in this.Users)
            {
                // Sender will not receive the message
                if (user != sender)
                {
                    user.ReceiveMessage(message);
                }                  
            }
        }
    }

    /// <summary>
    /// colleague interface
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        void SendMessage(string message);

        /// <summary>
        /// Receives the message.
        /// </summary>
        /// <param name="message">The message.</param>
        void ReceiveMessage(string message);
    }

    /// <summary>
    /// Concrete Colleague 1
    /// </summary>
    /// <seealso cref="DesignPatterns.IUser" />
    public class BasicUser : IUser
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The chat mediator
        /// </summary>
        private IChatMediator chatMediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicUser"/> class.
        /// </summary>
        /// <param name="chatMediator">The chat mediator.</param>
        /// <param name="name">The name.</param>
        public BasicUser(IChatMediator chatMediator, string name)
        {
            this.Name = name;
            this.ChatMediator = chatMediator;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// Gets or sets the chat mediator.
        /// </summary>
        /// <value>
        /// The chat mediator.
        /// </value>
        public IChatMediator ChatMediator { get => this.chatMediator; set => this.chatMediator = value; }
       
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void SendMessage(string message)
        {
            this.ChatMediator.SendMessage(message, this);
        }

        /// <summary>
        /// Receives the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void ReceiveMessage(string message)
        {
            Console.WriteLine("User Type: Basic -- " + this.Name + "; received message: " + message);
        }
    }

    /// <summary>
    /// Concrete Colleague 2
    /// </summary>
    /// <seealso cref="DesignPatterns.IUser" />
    public class PremiumUser : IUser
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The chat mediator
        /// </summary>
        private IChatMediator chatMediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="PremiumUser"/> class.
        /// </summary>
        /// <param name="chatMediator">The chat mediator.</param>
        /// <param name="name">The name.</param>
        public PremiumUser(IChatMediator chatMediator, string name)
        {
            this.Name = name;
            this.ChatMediator = chatMediator;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// Gets or sets the chat mediator.
        /// </summary>
        /// <value>
        /// The chat mediator.
        /// </value>
        public IChatMediator ChatMediator { get => this.chatMediator; set => this.chatMediator = value; }
       
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void SendMessage(string message)
        {
            this.ChatMediator.SendMessage(message, this);
        }

        /// <summary>
        /// Receives the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void ReceiveMessage(string message)
        {
            Console.WriteLine("User Type: Preminum -- " + this.Name + "; received message: " + message);
        }
    }
}

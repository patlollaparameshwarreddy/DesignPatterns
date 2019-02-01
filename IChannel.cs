//-----------------------------------------------------------------------
// <copyright file="IChannel.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// this interface is used for channel details
    /// </summary>
    public interface IChannel
    {
        /// <summary>
        /// Subscribes the specified viewer.
        /// </summary>
        /// <param name="viewer">The viewer.</param>
        void Subscribe(Viewer viewer);

        /// <summary>
        /// the subscribe.
        /// </summary>
        /// <param name="viewer">The viewer.</param>
        void UnSubscribe(Viewer viewer);

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        void Notify();
    }

    /// <summary>
    /// this interface is used for viewers updates
    /// </summary>
    public interface IViewer
    {
        /// <summary>
        /// Ups the date.
        /// </summary>
        /// <param name="channel">The channel.</param>
        void UpDate(Channel channel);
    }

    /// <summary>
    /// this is the implementation class of channel interface
    /// </summary>
    /// <seealso cref="DesignPatterns.IChannel" />
    public class Channel : IChannel
    {
        /// <summary>
        /// The viewers
        /// </summary>
        private List<Viewer> viewers = new List<Viewer>();

        /// <summary>
        /// The channel name
        /// </summary>
        private string channelName;

        /// <summary>
        /// The new update
        /// </summary>
       private string newUpdate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Channel"/> class.
        /// </summary>
        /// <param name="channelName">Name of the channel.</param>
        public Channel(string channelName)
        {
            this.channelName = channelName;
        }

        /// <summary>
        /// Gets or sets the name of the channel.
        /// </summary>
        /// <value>
        /// The name of the channel.
        /// </value>
        public string ChannelName { get => this.channelName; set => this.channelName = value; }

        /// <summary>
        /// Gets or sets the viewers.
        /// </summary>
        /// <value>
        /// The viewers.
        /// </value>
        public List<Viewer> Viewers { get => this.viewers; set => this.viewers = value; }

        /// <summary>
        /// Gets or sets the notify update.
        /// </summary>
        /// <value>
        /// The notify update.
        /// </value>
        public string NotifyUpdate
        {
            get
            {
                return this.newUpdate;
            }

            set
            {
                this.newUpdate = value;
                ////this condition is used for checking whether the update is null or not
                if (this.newUpdate != null)
                {
                    this.Notify();
                }
            }
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            ////this for loop is used for sending the notifications for the subscribed users
            foreach (Viewer observer in this.viewers)
            {
                observer.UpDate(this);
            }
        }

        /// <summary>
        /// Subscribes the specified viewer.
        /// </summary>
        /// <param name="viewer">The viewer.</param>
        public void Subscribe(Viewer viewer)
        {
            this.Viewers.Add(viewer);
        }

        /// <summary>
        /// the subscribe.
        /// </summary>
        /// <param name="viewer">The viewer.</param>
        public void UnSubscribe(Viewer viewer)
        {
            this.Viewers.Remove(viewer);
        }
    }

    /// <summary>
    /// this class is used for implementing the viewer interface
    /// </summary>
    /// <seealso cref="DesignPatterns.IViewer" />
    public class Viewer : IViewer
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Viewer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Viewer(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// Ups the date.
        /// </summary>
        /// <param name="channel">The channel.</param>
        public void UpDate(Channel channel)
        {
            Console.WriteLine(" {0} : {1} added new video on {2} ", this.Name, channel.ChannelName, channel.NotifyUpdate);
        }
    }
}

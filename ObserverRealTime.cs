//-----------------------------------------------------------------------
// <copyright file="ObserverRealTime.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// this class is used for creating objects of observer class
    /// </summary>
    public class ObserverRealTime
    {
        /// <summary>
        /// Observers the real time example.
        /// </summary>
        public void ObserverRealTimeExample()
        {
            ////creating the object of channel class
            Channel channel = new Channel(".NET Developers");
            ////creating the object of viewer class
            Viewer karan = new Viewer("karan");
            ////adding the viewer to the subscribe
            channel.Subscribe(karan);
            ////creating the object of viewer class
            Viewer manju = new Viewer("manju");
            ////adding the viewer to the subscribe
            channel.Subscribe(manju);
            ////adding new message
            channel.NotifyUpdate = "solid principles part 1";
            Console.WriteLine("=======================================");
            ////UnSubscribe the viewer
            channel.UnSubscribe(manju);
            ////creating new viewer object
            Viewer manoj = new Viewer("manoj");
            ////new user subscribe
            channel.Subscribe(manoj);
            ////adding new message
            channel.NotifyUpdate = "solid principles part 2";
        }
    }
}

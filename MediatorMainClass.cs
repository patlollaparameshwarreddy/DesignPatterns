//-----------------------------------------------------------------------
// <copyright file="MediatorMainClass.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// the main class for the mediator object creation
    /// </summary>
    public class MediatorMainClass
    {
        /// <summary>
        /// Mediators this instance.
        /// </summary>
        public void Mediator()
        {
            ////creating the object of ChatMediator class
            IChatMediator chatMediator = new ChatMediator();
            ////create users and add them to chat mediator's user list
            IUser paramesh = new BasicUser(chatMediator, "paramesh");
            IUser manju = new PremiumUser(chatMediator, "manju");
            IUser karan = new PremiumUser(chatMediator, "karan");
            chatMediator.AddUser(paramesh);
            chatMediator.AddUser(manju);
            chatMediator.AddUser(karan);
            //// send message
            karan.SendMessage("Hello Everyone!");
            Console.WriteLine("===============================================");
            paramesh.SendMessage("hiii");
            Console.ReadLine();
        }
    }
}

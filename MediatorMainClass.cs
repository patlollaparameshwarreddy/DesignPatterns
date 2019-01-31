using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class MediatorMainClass
    {
        public void Mediator()
        {
            IChatMediator chatMediator = new ChatMediator();
            // create users and add them to chat mediator's user list
            IUser paramesh = new BasicUser(chatMediator, "paramesh");
            IUser manju = new PremiumUser(chatMediator, "manju");
            IUser karan = new PremiumUser(chatMediator, "karan");
            chatMediator.AddUser(paramesh);
            chatMediator.AddUser(manju);
            chatMediator.AddUser(karan);
            // send message
            karan.SendMessage("Hello Everyone!");
            Console.WriteLine("===============================================");
            paramesh.SendMessage("hiii");
            Console.ReadLine();
        }
    }
}

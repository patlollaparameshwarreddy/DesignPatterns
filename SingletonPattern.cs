using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class SingletonPattern
    {
        static int numberOfInstances = 0;
        private static SingletonPattern instance = null;
        private SingletonPattern()
        {
            numberOfInstances++;
            Console.WriteLine("number of instances created is " + numberOfInstances);
        }

        public static SingletonPattern GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonPattern();
                }

                return instance;
            }                   
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }

    }
}

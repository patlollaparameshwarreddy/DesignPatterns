using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
           SingletonPattern reference1 = SingletonPattern.GetInstance;
            reference1.Message("hi how are you");
            SingletonPattern reference2 = SingletonPattern.GetInstance;
            reference2.Message("manju");
            Console.ReadLine();

        }
    }
}

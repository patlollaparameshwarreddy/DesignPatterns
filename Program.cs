using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string doCondition = null;
            int switchCases = 0;
            do
            {
                Console.WriteLine("enter 1 for singleton pattern");
                Console.WriteLine("enter 2 for factory design patten");
                Console.WriteLine("enter 3 for adaptor design pattern");
                switchCases = Convert.ToInt32(Console.ReadLine());
                switch (switchCases)
                {
                    case 1:
                        SingletonPattern reference1 = SingletonPattern.GetInstance;
                        reference1.Message("hi how are you");
                        SingletonPattern reference2 = SingletonPattern.GetInstance;
                        reference2.Message("manju");
                        Console.ReadLine();
                        break;
                    case 2:
                        EmployeeFactory EmployeeFactory = new ConcreteEmployeeFactory();
                        IFactory permanentEmployee = EmployeeFactory.Factory("PermanentEmployee");
                        permanentEmployee.Details();
                        IFactory TemporaryEmployee = EmployeeFactory.Factory("TemporaryEmployee");
                        TemporaryEmployee.Details();
                        Console.ReadLine();
                        break;
                    case 3:
                        ITarget Itarget = new EmployeeAdapator();
                        ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
                        client.ShowEmployeeList();
                        break;
                }

                Console.WriteLine("enter y to go to main method");
                doCondition = Console.ReadLine();
            }
            while (doCondition.Equals("y"));
        }
    }
}

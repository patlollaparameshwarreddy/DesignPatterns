using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string doCondition = null;
                int switchCases = 0;
                do
                {
                    Console.WriteLine("enter 1 for singleton pattern");
                    Console.WriteLine("enter 2 for factory design patten");
                    Console.WriteLine("enter 3 for adaptor design pattern");
                    Console.WriteLine("enter 4 for proxy design pattern");
                    Console.WriteLine("enter 5 for facade design pattern");
                    Console.WriteLine("enter 6 for mediator design pattern");
                    Console.WriteLine("enter 7 for observer 1 designer pattern");
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
                        case 4:
                            ProxyClient proxyClient = new ProxyClient();
                            Console.WriteLine("Data from Proxy Client = {0}", proxyClient.GetData());
                            break;
                        case 5:
                            HomeFacade homeFacade = new HomeFacade();
                            homeFacade.LeaveHome();
                            homeFacade.ArriveHome();
                            break;
                        case 6:
                            MediatorMainClass mediator = new MediatorMainClass();
                            mediator.Mediator();
                            break;
                        case 7:
                            ObserverClass observerClass = new ObserverClass();
                            observerClass.Observer();
                            break;
                    }

                    Console.WriteLine("enter y to go to main method");
                    doCondition = Console.ReadLine();
                }
                while (doCondition.Equals("y"));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

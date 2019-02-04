//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// this class is used for creating the object of all the classes
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <exception cref="Exception">system exception </exception>
        public static void Main(string[] args)
        {
            try
            {
                ////this variable is used for do condtion
                string doCondition = null;
                ////this variable is used for switch case
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
                    Console.WriteLine("enter 8 for observer 2 designer pattern");
                    Console.WriteLine("enter 9 for visitor design pattern");
                    Console.WriteLine("enter 10 for adaptor2 design patten");
                    Console.WriteLine("enter 11 for Reflection");
                    Console.WriteLine("enter 12 for Annotation program");
                    try
                    {
                        switchCases = Convert.ToInt32(Console.ReadLine());
                    }
                   catch (Exception)
                    {
                        Console.WriteLine("enter valid number only");
                    }

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
                            EmployeeFactory employeeFactory = new ConcreteEmployeeFactory();
                            IFactory permanentEmployee = employeeFactory.Factory("PermanentEmployee");
                            permanentEmployee.Details();
                            IFactory temporaryEmployee = employeeFactory.Factory("TemporaryEmployee");
                            temporaryEmployee.Details();
                            Console.ReadLine();
                            break;
                        case 3:
                            ITarget itarget = new EmployeeAdapator();
                            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(itarget);
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
                        case 8:
                            ObserverRealTime realTime = new ObserverRealTime();
                            realTime.ObserverRealTimeExample();
                            break;
                        case 9:
                            VisitorRunner visitorRunner = new VisitorRunner();
                            visitorRunner.Runner();
                            break;
                        case 10:
                            VendorAdapter vendorAdapter = new VendorAdapter();
                            vendorAdapter.SellingItems();
                            break;
                        case 11:
                            ExampleOfReflection exampleOfReflection = new ExampleOfReflection();
                            exampleOfReflection.ReflectionImplementation();
                            break;
                        case 12:
                            AnnotationPrograms annotationPrograms = new AnnotationPrograms();
                            annotationPrograms.ValidationOfAnnotation();
                            break;
                    }

                    Console.WriteLine("enter y to go to main method or enter any key to stop execution");
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

//-----------------------------------------------------------------------
// <copyright file="ObserverClass.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// the main class for observer
    /// </summary>
    public class ObserverClass
    {
        /// <summary>
        /// the method for observer
        /// </summary>
        public void Observer()
        {
            Product laptop = new Product("DELL", 30000);
            Console.WriteLine("Customer 1 and Customer 2 is subscribed to the Laptop Product");
            //// attach or subscribe customer 1
            Customer customer1 = new Customer("customer 1");
            laptop.Subscribe(customer1);
            //// attach or subscribe customer 2
            Customer customer2 = new Customer("customer 2");
            laptop.Subscribe(customer2);
            laptop.Price = 25000;
        }
    }
}

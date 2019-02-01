//-----------------------------------------------------------------------
// <copyright file="SingletonPattern.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// this class is used for SingletonPattern
    /// </summary>
    public class SingletonPattern
    {
        /// <summary>
        /// The number of instances
        /// </summary>
        private static int numberOfInstances = 0;

        /// <summary>
        /// The instance
        /// </summary>
        private static SingletonPattern instance = null;

        /// <summary>
        /// Prevents a default instance of the <see cref="SingletonPattern"/> class from being created.
        /// </summary>
        private SingletonPattern()
        {
            numberOfInstances++;
            Console.WriteLine("number of instances created is " + numberOfInstances);
        }

        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static SingletonPattern GetInstance
        {
            get
            {
                ////this condition is used to check whether the instance is null or not
                if (instance == null)
                {
                    instance = new SingletonPattern();
                }

                return instance;
            }                   
        }

        /// <summary>
        /// Messages the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}

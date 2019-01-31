//-----------------------------------------------------------------------
// <copyright file="IFactory.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Factory interface
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// abstract method
        /// </summary>
        void Details();
    }

    /// <summary>
    /// this class is used for storing the PermanentEmployee
    /// </summary>
    public class PermanentEmployee : IFactory
    {
        /// <summary>
        /// abstract method
        /// </summary>
        public void Details()
        {
            Console.WriteLine("permanent employee type object");
        }
    }

    /// <summary>
    /// this class is used for storing the TemporaryEmployee
    /// </summary>
    public class TemporaryEmployee : IFactory
    {
        /// <summary>
        /// this method is used for giving details
        /// </summary>
        public void Details()
        {
            Console.WriteLine("temporary employee type object");
        }
    }

    /// <summary>
    /// the abstract class of factory
    /// </summary>
   public abstract class EmployeeFactory
    {
        /// <summary>
        /// Factories the specified employee type.
        /// </summary>
        /// <param name="employeeType">Type of the employee.</param>
        /// <returns> the employee details</returns>
        public abstract IFactory Factory(string employeeType);
    }

    /// <summary>
    /// this class is used for implementing the abstract class
    /// </summary>
    public class ConcreteEmployeeFactory : EmployeeFactory
    {
        /// <summary>
        /// Factories the specified employee type.
        /// </summary>
        /// <param name="employeeType">Type of the employee.</param>
        /// <returns>
        /// the employee details
        /// </returns>
       /// <exception cref="ApplicationException">This type of employee can not be created</exception>
       public override IFactory Factory(string employeeType)
        {
           switch (employeeType)
            {
                case "PermanentEmployee":
                    return new PermanentEmployee();
                case "TemporaryEmployee":
                    return new TemporaryEmployee();
                default:
                    throw new ApplicationException("This type of employee can not be created");
            }
        }
    }
}

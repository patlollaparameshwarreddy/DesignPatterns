using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    interface IFactory
    {
        void Details();
    }

    class PermanentEmployee : IFactory
    {
        public void Details()
        {
            Console.WriteLine("permanent employee type object");
        }
    }

    class TemporaryEmployee : IFactory
    {
        public void Details()
        {
            Console.WriteLine("temporary employee type object");
        }
    }

   abstract class EmployeeFactory
    {
        public abstract IFactory Factory(string employeeType);
    }

    class ConcreteEmployeeFactory : EmployeeFactory
    {
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

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class ThirdPartyBillingSystem
    {
        private ITarget employeeSource;

        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }

        public void ShowEmployeeList()
        {
            List<string> employee = employeeSource.GetEmployeeList();           
            Console.WriteLine(" Employee List");
            foreach (var item in employee)
            {
                Console.Write(item);
            }

        }
    }
}

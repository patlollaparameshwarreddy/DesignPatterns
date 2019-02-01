//-----------------------------------------------------------------------
// <copyright file="ThirdPartyBillingSystem.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// this class is used for getting data of employees
    /// </summary>
    public class ThirdPartyBillingSystem
    {
        /// <summary>
        /// The employee source
        /// </summary>
        private ITarget employeeSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyBillingSystem"/> class.
        /// </summary>
        /// <param name="employeeSource">The employee source.</param>
        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }

        /// <summary>
        /// Shows the employee list.
        /// </summary>
        public void ShowEmployeeList()
        {
            ////creating the new list for employee
            List<string> employee = this.employeeSource.GetEmployeeList();           
            Console.WriteLine(" Employee List");
            ////this loop is used for printing the employees
            foreach (var item in employee)
            {
                Console.Write(item);
            }
        }
    }
}

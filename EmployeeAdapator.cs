//-----------------------------------------------------------------------
// <copyright file="EmployeeAdapator.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// this class is used for implementing the ITarget
    /// </summary>
    /// <seealso cref="DesignPatterns.HrSystemAdaptee" />
    /// <seealso cref="DesignPatterns.ITarget" />
    public class EmployeeAdapator : HrSystemAdaptee, ITarget
    {
        /// <summary>
        /// Gets the employee list.
        /// </summary>
        /// <returns>the number employees</returns>
        /// <exception cref="Exception"> index out of bounds </exception>
        public List<string> GetEmployeeList()
        {
            try
            {
                ////creating new list
                List<string> employeeList = new List<string>();
                ////creating the new string array
                string[][] employees = GetEmployees();
                ////this loop is used for adding employees in to the list
                foreach (string[] employee in employees)
                {
                    ////adding employees to list
                    employeeList.Add(employee[0]);
                    employeeList.Add(",");
                    employeeList.Add(employee[1]);
                    employeeList.Add("\n");
                }

                return employeeList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

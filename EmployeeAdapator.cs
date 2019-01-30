using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class EmployeeAdapator : HrSystemAdaptee, ITarget
    {
        public List<String> GetEmployeeList()
        {
            try
            {
                List<string> employeeList = new List<string>();
                string[][] employees = GetEmployees();
                foreach (string[] employee in employees)
                {
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

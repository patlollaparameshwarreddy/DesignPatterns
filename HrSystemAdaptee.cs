using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class HrSystemAdaptee
    {
        public string[][] GetEmployees()
        {
            string[][] employees = new string[4][];
            employees[0] = new string[] { "manoj", "teamlead" };
            employees[1] = new string[] { "karan", "developer" };
            employees[2] = new string[] { "paramesh", "developer" };
            employees[3] = new string[] { "manju", "developer" };
            return employees;
        }
    }
}

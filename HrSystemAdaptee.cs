//-----------------------------------------------------------------------
// <copyright file="HrSystemAdaptee.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// this class is used for storing use full information
    /// </summary>
    public class HrSystemAdaptee
    {
        /// <summary>
        /// this method consists of specified data
        /// </summary>
        /// <returns> returns the employee string</returns>
        public string[][] GetEmployees()
        {
            ////declaring 2 d string array
            string[][] employees = new string[4][];
            employees[0] = new string[] { "manoj", "teamlead" };
            employees[1] = new string[] { "karan", "developer" };
            employees[2] = new string[] { "paramesh", "developer" };
            employees[3] = new string[] { "manju", "developer" };
            return employees;
        }
    }
}

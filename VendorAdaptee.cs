//-----------------------------------------------------------------------
// <copyright file="VendorAdaptee.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System.Collections.Generic;

    /// <summary>
    /// it consists of all the products 
    /// </summary>
    public class VendorAdaptee
    {
        /// <summary>
        /// Gets the list of products.
        /// </summary>
        /// <returns>list of string</returns>
        public List<string> GetListOfProducts()
        {
            List<string> products = new List<string>();
            products.Add("Television");
            products.Add("Gaming Kit");
            products.Add("Mobiles");
            products.Add("Hp Laptops");
            return products;
        }
    }
}

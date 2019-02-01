//-----------------------------------------------------------------------
// <copyright file="VendorAdapter.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///  Vendor adapter is extending and implementing class and interface respectively
    /// </summary>
    /// <seealso cref="DesignPatterns.VendorAdaptee" />
    /// <seealso cref="DesignPatterns.ITarget2" />
    public class VendorAdapter : VendorAdaptee, ITarget2
    {
        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns>List of string</returns>
        public List<string> GetProducts()
        {
            VendorAdaptee vendorAdaptee = new VendorAdaptee();
            return vendorAdaptee.GetListOfProducts();
        }

        /// <summary>
        /// Selling the items.
        /// </summary>
        public void SellingItems()
        {
            ITarget2 target2 = new VendorAdapter();
            foreach (string items in target2.GetProducts())
            {
                Console.WriteLine(items);
            }
        }
    }
}

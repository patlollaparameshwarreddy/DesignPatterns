//-----------------------------------------------------------------------
// <copyright file="PriceVisitor.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// price visitor is an implementation class of an interface
    /// </summary>
    /// <seealso cref="DesignPatterns.IVisitor" />
    public class PriceVisitor : IVisitor
    {
        /// <summary>
        /// The car discount
        /// </summary>
        private const int CARDISCOUNT = 5;

        /// <summary>
        /// The bike discount
        /// </summary>
        private const int BIKEDISCOUNT = 2;

        /// <summary>
        /// Accepts the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        public void Accept(Car car)
        {
            decimal carPriceAfterDicount = car.Price - ((car.Price / 100) * CARDISCOUNT);
            Console.WriteLine("Car {0} price: {1}", car.CarName, carPriceAfterDicount);
        }

        /// <summary>
        /// Accepts the specified bike.
        /// </summary>
        /// <param name="bike">The bike.</param>
        public void Accept(RaceBike bike)
        {
            decimal bikePriceAfterDicount = bike.Price - ((bike.Price / 100) * BIKEDISCOUNT);
            Console.WriteLine("Bike {0} price: {1}", bike.BikeName, bikePriceAfterDicount);
        }
    }
}

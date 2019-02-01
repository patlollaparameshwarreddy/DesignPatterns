//-----------------------------------------------------------------------
// <copyright file="WeightVisitor.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Weight visitor is an implementation class of an interface
    /// </summary>
    /// <seealso cref="DesignPatterns.IVisitor" />
    public class WeightVisitor : IVisitor
    {
        /// <summary>
        /// Accepts the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        public void Accept(Car car)
        {
            switch (car.CarType)
            {
                case "Mercedes":
                    Console.WriteLine("Car {0} weight: {1} KG", car.CarName, 1750);
                    break;
                case "Normal":
                    Console.WriteLine("Car {0} weight: {1} KG", car.CarName, 750);
                    break;
            }
        }

        /// <summary>
        /// Accepts the specified bike.
        /// </summary>
        /// <param name="bike">The bike.</param>
        public void Accept(RaceBike bike)
        {
            switch (bike.BikeType)
            {
                case "Bullet":
                    Console.WriteLine("Bike {0} weight: {1} KG", bike.BikeName, 300);
                    break;
                case "Normal":
                    Console.WriteLine("Bike {0} weight: {1} KG", bike.BikeName, 100);
                    break;
            }
        }
    }
}

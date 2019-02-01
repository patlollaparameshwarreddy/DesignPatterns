//-----------------------------------------------------------------------
// <copyright file="IVisitor.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// I visitor is an interface
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// Accepts the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        void Accept(Car car);

        /// <summary>
        /// Accepts the specified race bike.
        /// </summary>
        /// <param name="raceBike">The race bike.</param>
        void Accept(RaceBike raceBike);
    }
}

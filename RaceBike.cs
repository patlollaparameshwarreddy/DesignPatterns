//-----------------------------------------------------------------------
// <copyright file="RaceBike.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// Race bike is an implementation class of an interface store
    /// </summary>
    /// <seealso cref="DesignPatterns.IStore" />
    public class RaceBike : IStore
    {
        /// <summary>
        /// Gets or sets the name of the bike.
        /// </summary>
        /// <value>
        /// The name of the bike.
        /// </value>
        public string BikeName { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the type of the bike.
        /// </summary>
        /// <value>
        /// The type of the bike.
        /// </value>
        public string BikeType { get; set; }

        /// <summary>
        /// Visits the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor of interface type.</param>
        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}

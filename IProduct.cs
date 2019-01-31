//-----------------------------------------------------------------------
// <copyright file="IProduct.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// the observer interface
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Subscribes the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        void Subscribe(Customer customer);

        /// <summary>
        /// Unsubscribes the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        void Unsubscribe(Customer customer);

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        void Notify();
    }

    /// <summary>
    /// this class is used for product details
    /// </summary>
    /// <seealso cref="DesignPatterns.IProduct" />
    public class Product : IProduct
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The base price
        /// </summary>
        private float basePrice;

        /// <summary>
        /// The current price
        /// </summary>
       private float currentPrice;

        /// <summary>
        /// The customers
        /// </summary>
        private List<Customer> customers = new List<Customer>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="basePrice">The base price.</param>
        public Product(string name, float basePrice)
        {
            this.Name1 = name;
            this.BasePrice = basePrice;
            this.CurrentPrice1 = basePrice;
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public float Price
        {
            get
            {
                return this.CurrentPrice1;
            }

            set
            {
                //// if price of the laptop will be less than the base price then 
                //// notification will forwarded to the subscribers
                this.CurrentPrice1 = value;
                if (value <= this.BasePrice)
                {
                    this.Notify();
                }                   
            }
        }

        /// <summary>
        /// Subscribes the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public void Subscribe(Customer customer)
        {
            this.customers.Add(customer);
        }

        /// <summary>
        /// Unsubscribes the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public void Unsubscribe(Customer customer)
        {
            this.customers.Remove(customer);
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            foreach (Customer observer in this.customers)
            {
                observer.Update(this);
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return this.Name1; }
        }

        /// <summary>
        /// Gets the discount.
        /// </summary>
        /// <value>
        /// The discount.
        /// </value>
        public float Discount
        {
            get { return (this.BasePrice - this.CurrentPrice1) * 100 / this.BasePrice; }
        }

        /// <summary>
        /// Gets the current price.
        /// </summary>
        /// <value>
        /// The current price.
        /// </value>
        public float CurrentPrice
        {
            get { return this.CurrentPrice1; }
        }

        /// <summary>
        /// Gets or sets the name1.
        /// </summary>
        /// <value>
        /// The name1.
        /// </value>
        public string Name1 { get => this.name; set => this.name = value; }

        /// <summary>
        /// Gets or sets the base price.
        /// </summary>
        /// <value>
        /// The base price.
        /// </value>
        public float BasePrice { get => this.basePrice; set => this.basePrice = value; }

        /// <summary>
        /// Gets or sets the current price1.
        /// </summary>
        /// <value>
        /// The current price1.
        /// </value>
        public float CurrentPrice1 { get => this.currentPrice; set => this.currentPrice = value; }
    }

    /// <summary>
    /// the customer interface
    /// </summary>
    public interface ICustomer
    {
        /// <summary>
        /// Updates the specified product.
        /// </summary>
        /// <param name="product">The product.</param>
        void Update(Product product);
    }

    /// <summary>
    /// this class is used for implementing the ICustomer
    /// </summary>
    /// <seealso cref="DesignPatterns.ICustomer" />
    public class Customer : ICustomer
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Customer(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// Updates the specified product.
        /// </summary>
        /// <param name="product">The product.</param>
        public void Update(Product product)
        {
            Console.WriteLine("{0}: {1} Laptop is now available at {2}; Discount = {3}%", this.Name, product.Name, product.CurrentPrice, product.Discount);
        }
    }
}

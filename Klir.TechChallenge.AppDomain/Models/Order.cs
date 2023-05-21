using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.AppDomain
{
    /// <summary>
    /// Checkout Order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Id
        /// </summary>
        public long ProductId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Price
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Total
        /// </summary>
        public decimal Total { get; set; }
        /// <summary>
        /// Promotion Id
        /// </summary>
        public decimal? PromotionId { get; set; }
        /// <summary>
        /// Name of promotion
        /// </summary>
        public string Promotion { get; set; }
    }
}

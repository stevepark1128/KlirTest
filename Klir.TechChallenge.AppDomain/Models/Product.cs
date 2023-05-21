using System;

namespace Klir.TechChallenge.AppDomain
{
    public class Product
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Product Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Price
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Promotion Id
        /// </summary>
        public int? PromotionId { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        public int? Quantity { get; set; }
        /// <summary>
        /// Promotion Name
        /// </summary>
        public string? Promotion { get; set; }

    }
}

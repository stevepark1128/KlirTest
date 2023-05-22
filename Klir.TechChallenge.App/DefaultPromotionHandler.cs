using Klir.TechChallenge.AppDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.App
{
    internal class DefaultPromotionHandler : IPromotionHandler
    {
        /// <summary>
        /// Apply promotion to order 
        /// </summary>
        /// <param name="product"></param>
        /// <param name="promotion"></param>
        /// <returns>Chectout Order</returns>
        public Order ApplyPromotion(Product product, Promotion promotion)
        {
            return new Order()
            {
                ProductId = product.Id,
                Name = product.Name,
                PromotionId = null,
                Quantity = product.Quantity.Value,
                Price = product.Price,
                Total = product.Price * product.Quantity.Value,
                Promotion = string.Empty
            };
        }
    }
}

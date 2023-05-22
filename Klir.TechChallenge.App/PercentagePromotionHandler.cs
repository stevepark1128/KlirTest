using Klir.TechChallenge.AppDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.App
{
    public class PercentagePromotionHandler : IPromotionHandler
    {
        /// <summary>
        /// Apply promotion to order 
        /// </summary>
        /// <param name="product"></param>
        /// <param name="promotion"></param>
        /// <returns>Chectout Order</returns>
        public Order ApplyPromotion(Product product, Promotion promotion)
        {
            var remainder = product.Quantity.Value % promotion.Divider;
            var denominator = product.Quantity.Value / promotion.Divider;

            return new Order()
            {
                ProductId = product.Id,
                Name = product.Name,
                PromotionId = promotion.Id,
                Quantity = product.Quantity.Value,
                Price = product.Price,
                Total = (decimal)((denominator * promotion.Divider * product.Price * promotion.Percentage) + remainder * product.Price),
                Promotion = promotion.Name
            };
        }
    }
}

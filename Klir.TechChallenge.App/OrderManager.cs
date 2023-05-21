using Klir.TechChallenge.AppDomain;
using Klir.TechChallenge.Provider;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.App
{
    public class OrderManager : IOrderManager
    {
        private readonly IOrderProvider _orderProvider;

        public OrderManager(IOrderProvider orderProvider)
        {
            _orderProvider = orderProvider;
        }

        /// <summary>
        /// Apply promotions and return orders
        /// </summary>
        /// <param name="products"></param>
        /// <returns>Checkout Order List</returns>
        public async Task<List<Order>> CheckoutOrderList(IList<Product> products)
        {
            var orders = new List<Order>();
            foreach (var product in products)
            {
                // Get order after promotino applied.
                var promotion = product.PromotionId != null ? await _orderProvider.GetPromotionById(product.PromotionId.Value) : null;
                orders.Add(ApplyPromotion(product, promotion));
                
            }
            return orders;
        }

        /// <summary>
        /// Apply Promotion to order
        /// </summary>
        /// <param name="product"></param>
        /// <param name="promotion"></param>
        /// <returns></returns>
        private Order ApplyPromotion(Product product, Promotion promotion)
        {
            if (promotion != null)
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
                    Total = product.PromotionId == 1 ? 
                    (decimal)(denominator * product.Price + remainder * product.Price) : 
                    promotion.Amount * denominator + remainder * product.Price,
                    Promotion = promotion.Name
                };
            }
            else
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
}

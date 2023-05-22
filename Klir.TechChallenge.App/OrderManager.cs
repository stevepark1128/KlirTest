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
        private readonly IPromotionHandlerFactory _promotionHandlerFactory;
        public OrderManager(IOrderProvider orderProvider, IPromotionHandlerFactory promotionHandlerFactory)
        {
            _orderProvider = orderProvider;
            _promotionHandlerFactory = promotionHandlerFactory;
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
                var promotionHandler = this._promotionHandlerFactory.GetPromotionHandler(promotion);
                orders.Add(promotionHandler.ApplyPromotion(product, promotion));
                
            }
            return orders;
        }
    }
}

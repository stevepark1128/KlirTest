using Klir.TechChallenge.AppDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.App
{
    public interface IOrderManager
    {
        /// <summary>
        /// Apply promotions and return orders
        /// </summary>
        /// <param name="products"></param>
        /// <returns>Checkout Order List</returns>
        Task<List<Order>> CheckoutOrderList(IList<Product> products);
    }
}

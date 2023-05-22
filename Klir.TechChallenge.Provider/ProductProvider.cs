using Klir.TechChallenge.AppDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Provider
{
    public class ProductProvider : IProductProvider
    {
        /// <summary>
        /// Get Product List
        /// </summary>
        /// <returns>Product List</returns>
        public async Task<List<Product>> GetProductList()
        {
            var products = new List<Product>();

            products.Add(new Product() { Id = 1, Name = "ProductA", Price = 20, PromotionId = 1, Promotion = "Buy 1 Get 1 Free" });
            products.Add(new Product() { Id = 2, Name = "ProductB", Price = 4, PromotionId = 2, Promotion = "3 for 10 Euro" });
            products.Add(new Product() { Id = 3, Name = "ProductC", Price = 2, PromotionId = null });
            products.Add(new Product() { Id = 4, Name = "ProductD", Price = 4, PromotionId = 2 , Promotion = "3 for 10 Euro" });
            return await Task.Run(() => products);
        }
    }
}

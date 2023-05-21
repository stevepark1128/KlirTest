using Klir.TechChallenge.AppDomain;
using Klir.TechChallenge.Provider;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Klir.TechChallenge.App
{
    public class ProductManager : IProductManager
    {
        private readonly IProductProvider _productProvider;

        public ProductManager(IProductProvider productProvider)
        {
            _productProvider = productProvider;
        }

        /// <summary>
        /// Get prodduct list
        /// </summary>
        /// <returns>Product List</returns>
        public async Task<List<Product>> GetProductList()
        {
            return await _productProvider.GetProductList();
        }
    }
}

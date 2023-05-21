using Klir.TechChallenge.AppDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Provider
{
    public interface IProductProvider
    {
        /// <summary>
        /// Get Product List
        /// </summary>
        /// <returns>Product List</returns>
        Task<List<Product>> GetProductList();
    }
}

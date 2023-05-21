using Klir.TechChallenge.AppDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.App
{
    public interface IProductManager
    {
        /// <summary>
        /// Get prodduct list
        /// </summary>
        /// <returns>Product List</returns>
        Task<List<Product>> GetProductList();
    }
}

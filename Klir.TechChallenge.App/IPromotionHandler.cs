using Klir.TechChallenge.AppDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.App
{
    /// <summary>
    /// Interface for promotion handler
    /// </summary>
    public interface IPromotionHandler
    {
        /// <summary>
        /// Apply promotion to order 
        /// </summary>
        /// <param name="product"></param>
        /// <param name="promotion"></param>
        /// <returns>Chectout Order</returns>
        Order ApplyPromotion(Product product, Promotion promotion);
    }
}

using Klir.TechChallenge.AppDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.App
{
    /// <summary>
    /// Interface Factory for Promotion Handler
    /// </summary>
    public interface IPromotionHandlerFactory
    {
        /// <summary>
        /// Get Promotion handler based on promotion
        /// </summary>
        /// <param name="promotion"></param>
        /// <returns>Promotion Handler</returns>
        IPromotionHandler GetPromotionHandler(Promotion promotion);
    }
}

using Klir.TechChallenge.AppDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.App
{
    public class PromotionHandlerFactory: IPromotionHandlerFactory
    {
        /// <summary>
        /// Get Promotion handler based on promotion
        /// </summary>
        /// <param name="promotion"></param>
        /// <returns>Promotion Handler</returns>
        public IPromotionHandler GetPromotionHandler(Promotion promotion)
        {
            switch (promotion?.Id)
            {
                case 1:
                    return new PercentagePromotionHandler();
                case 2:
                    return new AmountPromotionHandler();
                default:
                    return new DefaultPromotionHandler();
            }
        }
    }
}

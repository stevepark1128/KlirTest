using Klir.TechChallenge.AppDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Provider
{
    public interface IOrderProvider
    {
        /// <summary>
        /// Get Promotion by Id
        /// </summary>
        /// <param name="promotionId"></param>
        /// <returns>Promotion</returns>
        Task<Promotion> GetPromotionById(int promotionId);
    }
}

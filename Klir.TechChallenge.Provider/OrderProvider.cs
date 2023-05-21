using Klir.TechChallenge.AppDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Provider
{
    public class OrderProvider : IOrderProvider
    {
        /// <summary>
        /// Get Promotion by Id
        /// </summary>
        /// <param name="promotionId"></param>
        /// <returns>Promotion</returns>
        public Task<Promotion> GetPromotionById(int promotionId)
        {
            var promotions = SeedPromotion();
            return Task.Run(() => promotions.Find(x => x.Id == promotionId));
        }

        /// <summary>
        /// Seed promotions
        /// </summary>
        /// <returns></returns>
        private List<Promotion> SeedPromotion()
        {
            var promotions = new List<Promotion>();
            promotions.Add(new Promotion() { Id = 1, Name = "Buy 1 Get 1 Free", Divider = 2, Percentage = 0.5M });
            promotions.Add(new Promotion() { Id = 2, Name = "3 for 10 Euro", Divider = 3, Amount = 10 });

            return promotions;
        }
    }
}

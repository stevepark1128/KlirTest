using Klir.TechChallenge.App;
using Klir.TechChallenge.AppDomain;
using Klir.TechChallenge.Provider;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Klir.TechChallenge.Tests.Managers
{
    public class OrderManagerUnitTest
    {
        private readonly IOrderManager _sut;
        public OrderManagerUnitTest()
        {
            _sut = new OrderManager(new OrderProvider());
        }

        [Fact]
        public async Task ReturnCheckoutOrderList()
        {
            //Arrange
            var products = new List<Product>();

            products.Add(new Product() { Id = 1, Name = "ProductA", Price = 20, PromotionId = 1, Quantity = 2 });
            products.Add(new Product() { Id = 2, Name = "ProductB", Price = 4, PromotionId = 2, Quantity = 3 });
            products.Add(new Product() { Id = 3, Name = "ProductC", Price = 2, PromotionId = null, Quantity = 5 });
            products.Add(new Product() { Id = 4, Name = "ProductD", Price = 4, PromotionId = 2, Quantity = 2 });

            //Act
            var result = await _sut.CheckoutOrderList(products);

            //Assert
            Assert.Equal(4, result.Count);
            Assert.Equal(10, result[1].Total);
        }
    }
}

using Klir.TechChallenge.Provider;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Klir.TechChallenge.Tests.Providers
{
    public class OrderProviderUnitTest
    {
        private readonly IOrderProvider _sut;
        public OrderProviderUnitTest()
        {
            _sut = new OrderProvider();
        }

        [Fact]
        public async Task ReturnGetPromotionById()
        {
            //Arrange

            //Act
            var result = await _sut.GetPromotionById(1);

            //Assert
            Assert.Equal("Buy 1 Get 1 Free", result.Name);
        }
    }
}

using Klir.TechChallenge.Provider;
using System;
using System.Threading.Tasks;
using Xunit;

namespace KlirTechChallenge.Tests.Providers
{
    public class ProductProviderUnitTest
    {
        private readonly IProductProvider _sut;
        public ProductProviderUnitTest()
        {
            _sut = new ProductProvider();
        }

        [Fact]
        public async Task ReturnGetProductList()
        {
            //Arrange

            //Act
            var result = await _sut.GetProductList();

            //Assert
            Assert.Equal(4, result.Count);
        }
    }
}

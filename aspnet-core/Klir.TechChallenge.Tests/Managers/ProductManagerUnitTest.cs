using Klir.TechChallenge.App;
using Klir.TechChallenge.Provider;
using System;
using System.Threading.Tasks;
using Xunit;

namespace KlirTechChallenge.Tests.Managers
{
    public class ProductManagerUnitTest
    {
        private readonly IProductManager _sut;
        public ProductManagerUnitTest()
        {
            _sut = new ProductManager(new ProductProvider());
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

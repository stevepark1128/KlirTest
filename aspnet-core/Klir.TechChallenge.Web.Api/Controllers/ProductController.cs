using Klir.TechChallenge.App;
using Klir.TechChallenge.AppDomain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _productManager;

        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }
        
        [HttpGet("ProductList")]
        public async Task<ActionResult<List<Product>>> GetProductListAsync()
        {
            try
            {
                var result = await _productManager.GetProductList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error occured");
            }
        }

    }
}

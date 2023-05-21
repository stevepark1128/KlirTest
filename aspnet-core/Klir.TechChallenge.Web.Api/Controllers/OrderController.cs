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
    public class OrderController : ControllerBase
    {
        private readonly IOrderManager _orderManager;

        public OrderController(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        [HttpGet("GetOrderCheckoutList")]
        public async Task<ActionResult<List<Order>>> GetOrderCheckoutListAsync()
        {
            try
            {
                var products = new List<Product>();

                products.Add(new Product() { Id = 1, Name = "ProductA", Price = 20, PromotionId = 1, Quantity = 2 });
                products.Add(new Product() { Id = 2, Name = "ProductB", Price = 4, PromotionId = 2, Quantity = 3 });
                products.Add(new Product() { Id = 3, Name = "ProductC", Price = 2, PromotionId = null, Quantity = 5 });
                products.Add(new Product() { Id = 4, Name = "ProductD", Price = 4, PromotionId = 2, Quantity = 2 });

                var result = await _orderManager.CheckoutOrderList(products);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error occured");
            }
        }

        [HttpPost("OrderCheckoutList")]
        public async Task<ActionResult<List<Order>>> GetOrderCheckoutListAsync(IList<Product> orders)
        {
            try
            {
                var result = await _orderManager.CheckoutOrderList(orders);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error occured");
            }
        }
    }
}

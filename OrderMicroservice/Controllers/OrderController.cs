
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderMicroservice.ApplicationCore.Contracts.Repositories;
using OrderMicroservice.ApplicationCore.Contracts.Services;
using OrderMicroservice.ApplicationCore.Model.Request;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private IOrderServiceAsync orderServiceAsync;

        public OrderController(IOrderServiceAsync orderServiceAsync)
        {
            this.orderServiceAsync = orderServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            return Ok(await orderServiceAsync.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SaveNewOrder(OrderRequestModel orderRequestModel)
        {
            return Ok(await orderServiceAsync.InsertOrder(orderRequestModel));
        }

        [HttpGet]
        public async Task<IActionResult> GetByCustomerId(int customerId)
        {
            return Ok(await orderServiceAsync.GetOrderByCustomerId(customerId));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            if(await orderServiceAsync.DeleteOrder(id) == 0)
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpPatch]
        public async Task<IActionResult> UpdateOrder(OrderRequestModel orderRequestModel, int id)
        {
            return Ok(orderServiceAsync.UpdateOrder(orderRequestModel, id));
        }
    }
}

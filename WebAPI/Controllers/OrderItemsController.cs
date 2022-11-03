using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class OrderItemsController : ControllerBase
    {
        IOrderItemService _orderItemService;

        public OrderItemsController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpGet("getallfororderıtem")]
        public IActionResult GetAll()
        {
            var result = _orderItemService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getfororderıtem")]
        public IActionResult Get(int id)
        {
            var result = _orderItemService.Get(id);
            if (!result.Success)
            {
                return BadRequest(result.Data);
            }
            return Ok(result.Data);
        }
        [HttpPost("addfororderıtem")]
        public IActionResult Add(OrderItem orderItem)
        {
            var result = _orderItemService.Add(orderItem);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpPost("updatefororderıtem")]
        public IActionResult Update(OrderItem orderItem)
        {
            var result = _orderItemService.Update(orderItem);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
        [HttpGet("deletefororderıtem")]
        public IActionResult Delete(int id)
        {
            var result = _orderItemService.Delete(id);
            if (!result.Success)
            {
                return BadRequest(result.Success);
            }
            return Ok(result.Success);
        }
    }
}
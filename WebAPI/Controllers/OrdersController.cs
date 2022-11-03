using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class OrdersController : ControllerBase
    {
        IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("getallfororder")]
        public IActionResult GetAll()
        {
            var result = _orderService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getfororder")]
        public IActionResult Get(int id)
        {
            var result = _orderService.Get(id);
            if (!result.Success)
            {
                return BadRequest(result.Data);
            }
            return Ok(result.Data);
        }
        [HttpPost("addfororder")]
        public IActionResult Add(Order order)
        {
            var result = _orderService.Add(order);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpPost("updatefororder")]
        public IActionResult Update(Order order)
        {
            var result = _orderService.Update(order);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
        [HttpGet("deletefororder")]
        public IActionResult Delete(int id)
        {
            var result = _orderService.Delete(id);
            if (!result.Success)
            {
                return BadRequest(result.Success);
            }
            return Ok(result.Success);
        }
    }
}
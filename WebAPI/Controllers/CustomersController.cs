using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _customerService.Get(id);
            if (!result.Success)
            {
                return BadRequest(result.Data);
            }
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
        [HttpGet("delete")]
        public IActionResult Delete(int id)
        {
            var result = _customerService.Delete(id);
            if (!result.Success)
            {
                return BadRequest(result.Success);
            }
            return Ok(result.Success);
        }
    }
}
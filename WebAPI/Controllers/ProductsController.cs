using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _productService.Get(id);
            if (!result.Success)
            {
                return BadRequest(result.Data);
            }
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
        [HttpGet("delete")]
        public IActionResult Delete(int id)
        {
            var result = _productService.Delete(id);
            if (!result.Success)
            {
                return BadRequest(result.Success);
            }
            return Ok(result.Success);
        }
    }
}
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _categoryService.Get(id);
            if (!result.Success)
            {
                return BadRequest(result.Data);
            }
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Category category)
        {
            var result = _categoryService.Update(category);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
        [HttpGet("delete")]
        public IActionResult Delete(int id)
        {
            var result = _categoryService.Delete(id);
            if (!result.Success)
            {
                return BadRequest(result.Success);
            }
            return Ok(result.Success);
        }
    }
}
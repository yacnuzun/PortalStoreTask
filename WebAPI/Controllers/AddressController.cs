using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class AddressController : ControllerBase
    {
        IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet("getallforaddress")]
        public IActionResult GetAll()
        {
            var result = _addressService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getforaddress")]
        public IActionResult Get(int id)
        {
            var result = _addressService.Get(id);
            if (!result.Success)
            {
                return BadRequest(result.Data);
            }
            return Ok(result.Data);
        }
        [HttpPost("addforaddress")]
        public IActionResult Add(Address address)
        {
            var result = _addressService.Add(address);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpPost("updateforaddress")]
        public IActionResult Update(Address address)
        {
            var result = _addressService.Update(address);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
        [HttpGet("deleteforaddress")]
        public IActionResult Delete(int id)
        {
            var result = _addressService.Delete(id);
            if (!result.Success)
            {
                return BadRequest(result.Success);
            }
            return Ok(result.Success);
        }
    }
}
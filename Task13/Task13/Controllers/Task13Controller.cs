using Microsoft.AspNetCore.Mvc;
using System;
using Task13.Requests_Responces;
using Task13.Services;

namespace Task13.Controllers
{
    [Route("api")]
    [ApiController]
    public class Task13Controller : Controller
    {
        private IDatabaseDbService _service;
        public Task13Controller(IDatabaseDbService service)
        {
            _service = service;
        }
        [HttpPost("orders")]
        public IActionResult GetOrders(NameRequest request)
        {
            var orders = _service.GetOrders(request);
            if (orders == null) 
            {
                return BadRequest("404 Bad Request!");
            }
            return Ok(orders);
        }
        [Route("clients/{id?}/orders")]
        [HttpPost]
        public IActionResult AddOrders(AddOrderRequest request)
        {
            int id = Convert.ToInt32(Request.Path.ToUriComponent().Split("/").GetValue(3));
            string result = _service.AddOrders(id,request);
            if (result == null)
            {
                return BadRequest("404 Bad Request!");
            }
            return Ok(result);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPIWithDapper.Models;
using WebAPIWithDapper.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIWithDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IDapper _dapper;
        public ProductController(IDapper dapper)
        {
            _dapper = dapper;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpGet("get")]
        public ActionResult<List<Product>> GetAllProducts()
        {
            var response = _dapper.GetAll();
            return response;
        }
        [HttpGet("GetProductById")]
        public ActionResult<Product> GetProductById(int id)
        {
            var response = _dapper.GetProductById(id);
            return response;
        }
    }
}

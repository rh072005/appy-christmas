using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return new Product[] {
             new Product(),
             new Product(),
             new Product()   
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return new Product {
              Name = "Unicorn",
              Type = "Toy",
              Description = "The Unicorn with the Horn",
              Manufacturer = "Deadpool Toys Ltd.",
              Model = "Pinkie",
              NetPrice = 0.12,
              GrossPrice = 39.99  
            };
        }
    }
}

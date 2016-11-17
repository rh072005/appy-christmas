namespace ProductApi.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using ProductApi.Models;

    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return getProducts();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return getProducts().ToArray()[id];
        }

        private IEnumerable<Product> getProducts()
        {
            return new Product[] {
                new Product {
                    Name = "Unicorn",
                    Type = "Toy",
                    Description = "The Unicorn with the Horn",
                    Manufacturer = "Deadpool Toys Ltd.",
                    Model = "Pinkie",
                    NetPrice = 0.12,
                    GrossPrice = 39.99 ,
                    ImageUrl = "images/unicorn.jpg"
                },
                new Product {
                    Name = "Soup",
                    Type = "Food",
                    Description = "String Soup",
                    Manufacturer = "Soup Dragon Foods.",
                    Model = "",
                    NetPrice = 1.00,
                    GrossPrice = 1.20 ,
                    ImageUrl = "images/soup.jpg"
                },
                new Product {
                    Name = "Light Sabre",
                    Type = "Food",
                    Description = "Laser Sword",
                    Manufacturer = "Jedi Manufacturing Ltd.",
                    Model = "Blue",
                    NetPrice = 100.00,
                    GrossPrice = 250.00 ,
                    ImageUrl = "images/lightsabre.jpg"
                }
            };
        }
    }
}

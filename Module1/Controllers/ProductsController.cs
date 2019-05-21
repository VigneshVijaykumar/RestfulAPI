using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    [Route("api/Products")]
    [Produces("application/json")]
    public class ProductsController : Controller
    {
        List<Product> _products = new List<Product>()
       {
           new Product{ProductID=0,ProductName="Laptop",ProductPrice="200"},
           new Product{ProductID=1,ProductName="Smartphone",ProductPrice="100"},
       };

        public IEnumerable<Product> Get()
        {
            return _products;
        }
    }
}
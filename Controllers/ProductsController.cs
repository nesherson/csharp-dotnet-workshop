using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContosoCrafts.Services;
using ContosoCrafts.Models;

namespace ContosoCrafts.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase {

        public ProductsController(JsonFileProductService productService) {
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get() {
            return ProductService.GetProducts();
        }
    
    }

}
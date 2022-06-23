using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopAPI.Models;
using ShopWebsite.Repository;

namespace ShopAPI.Controllers
{
    [Route("[controller]")]
    public class HelloWorldController : Controller
    {
        private readonly ILogger<HelloWorldController> _logger;
        private IRepository<Product> rptP;
        private IRepository<Category> rptC;

        public HelloWorldController(ILogger<HelloWorldController> logger, IRepository<Product> rptP, IRepository<Category> rptC)
        {
            _logger = logger;
            this.rptP = rptP;
            this.rptC = rptC;
        }

        [HttpPost("CreateCategory")]
        public async Task<ActionResult<Category>> CreateCategory(Category ctg)
        {
            rptC.Create(ctg);
            return Ok();
        }

        [HttpPost("CreateProduct")]
        public async Task<ActionResult<Product>> CreateProduct(Product pdt)
        {
            rptP.Create(pdt);
            return Ok();
        }

        [HttpGet("DetailProduct/{id}")]
        public async Task<ActionResult<Product>> DetailProduct(int id)
        {
            return rptP.Read(id);
        }

        [HttpPost("EditProduct")]
        public async Task<ActionResult<Product>> EditProduct(Product pdt)
        {
            rptP.Update(pdt);
            return Ok();
        }


    }
}
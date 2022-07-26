using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using animalWiki.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopWebsite.Repository;

namespace animalWiki.Controllers
{
    [Route("[controller]")]
    public class animalController : Controller
    {
        private readonly ILogger<animalController> _logger;
        private IRepository<Animal> rptAnimal;


        public animalController(ILogger<animalController> logger, IRepository<Animal> rptAnimal)
        {
            _logger = logger;
            this.rptAnimal = rptAnimal;
        }


        [HttpPost("CreateAnimal")]
        public async Task<ActionResult<Animal>> CreateAnimal(Animal animal)
        {
            rptAnimal.Create(animal);
            return Ok();
        }

        [HttpGet("DeleteAnimal/{id}")]
        public async Task<ActionResult<Animal>> DeleteAnimal(int id)
        {
            rptAnimal.Delete(rptAnimal.Read(id));
            return Ok();
        }

        [HttpGet("DetailAnimal/{id}")]
        public async Task<ActionResult<Animal>> DetailAnimal(int id)
        {
            return rptAnimal.Read(id);
        }

        [HttpGet("ListAnimal")]
        public async Task<ActionResult<List<Animal>>> ListAnimal()
        {
            return rptAnimal.Reads();
        }

        [HttpPost("EditAnimal")]
        public async Task<ActionResult<Animal>> EditAnimal(Animal animal)
        {
            rptAnimal.Update(animal);
            return Ok();
        }
    }
}
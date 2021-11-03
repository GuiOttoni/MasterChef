using MasterChef.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChef.Controllers
{
    [ApiController]
    [Route("Api/[controller]/[Action]")]
    public class RecipeController : ControllerBase
    {
       

        private readonly ILogger<RecipeController> _logger;

        public RecipeController(ILogger<RecipeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Recipe> Get()
        {
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new Recipe
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
            return new List<Recipe>();
        }
    }
}

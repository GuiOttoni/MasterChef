using MasterChef.API.ApiModels;
using MasterChef.Application.Interfaces;
using MasterChef.Domain.Models;
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
        private readonly IRecipeService _recipeService;


        public RecipeController(ILogger<RecipeController> logger, IRecipeService recipeService)
        {
            _logger = logger;
            _recipeService = recipeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recipe>>> List()
        {
            var recipes = new List<Recipe>();
            try
            {
                recipes = await _recipeService.List();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            return Ok(recipes);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseBase>> Create(Recipe recipe)
        {
            var response = new ResponseBase
            {
                Success = true,
                Message = "Receita salva com sucesso"
            };

            try
            {
                _recipeService.Create(recipe);
            }
            catch(Exception e)
            {
                response.Success = false;
                response.Message = "falha ao salvar receita";
                _logger.LogError(e.Message);
            }
            

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<ResponseBase>> Update(Recipe recipe)
        {
            var response = new ResponseBase
            {
                Success = true,
                Message = "Receita salva com sucesso"
            };

            try
            {
                _recipeService.Update(recipe);
            }
            catch (Exception e)
            {
                response.Success = false;
                response.Message = "falha ao salvar receita";
                _logger.LogError(e.Message);
            }


            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult<ResponseBase>> Delete(int id)
        {
            var response = new ResponseBase
            {
                Success = true,
                Message = "Receita salva com sucesso"
            };

            try
            {
                _recipeService.Delete(id);
            }
            catch (Exception e)
            {
                response.Success = false;
                response.Message = "falha ao salvar receita";
                _logger.LogError(e.Message);
            }


            return Ok(response);
        }
    }
}

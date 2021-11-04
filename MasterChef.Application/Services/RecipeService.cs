using MasterChef.Application.Interfaces;
using MasterChef.Domain;
using MasterChef.Domain.Models;
using MasterChef.Persistence.Repositories.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChef.Application.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;
        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public void Create(Recipe recipe)
        {
            _recipeRepository.Save(recipe);
        }

        public void Delete(int id)
        {
            _recipeRepository.Delete(id);
        }

        public void Update(Recipe recipe)
        {
            _recipeRepository.Update(recipe);
        }

        public Task<List<Recipe>> List()
        {
            return _recipeRepository.List();
        }

        public Task<List<Recipe>> List(int IdCategory)
        {
            throw new NotImplementedException();
        }

        public Task<List<Recipe>> List(string Chef)
        {
            throw new NotImplementedException();
        }

        public Task<Recipe> Get(int id)
        {
            return _recipeRepository.Get(id);
        }
    }
}

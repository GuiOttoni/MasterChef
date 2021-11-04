using MasterChef.Application.Interfaces;
using MasterChef.Domain;
using MasterChef.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChef.Application.Services
{
    public class RecipeService : IRecipeService
    {
        public void Create(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        Task<List<Recipe>> IRecipeService.List()
        {
            throw new NotImplementedException();
        }

        Task<List<Recipe>> IRecipeService.List(int IdCategory)
        {
            throw new NotImplementedException();
        }

        Task<List<Recipe>> IRecipeService.List(string Chef)
        {
            throw new NotImplementedException();
        }
    }
}

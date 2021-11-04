using MasterChef.Domain;
using MasterChef.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasterChef.Application.Interfaces
{
    public interface IRecipeService
    {
        Task<List<Recipe>> List();
        Task<Recipe> Get(int id);
        Task<List<Recipe>> List(int IdCategory);
        Task<List<Recipe>> List(string Chef);

        void Create(Recipe recipe);
        void Delete(int id);
        void Update(Recipe recipe);
    }
}

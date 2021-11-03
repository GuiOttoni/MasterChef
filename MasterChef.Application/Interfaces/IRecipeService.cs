using MasterChef.Domain;
using System.Collections.Generic;

namespace MasterChef.Application.Interfaces
{
    public interface IRecipeService
    {
        List<Recipe> List();
        List<Recipe> List(int IdCategory);
        List<Recipe> List(string Chef);

        void Create(Recipe recipe);
        void Delete(int id);
        void Update(Recipe recipe);
    }
}

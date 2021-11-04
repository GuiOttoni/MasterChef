using MasterChef.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChef.Persistence.Repositories.Intefaces
{
    public interface IRecipeRepository
    {
        public Task<List<Recipe>> List();
        public Task<Recipe> Get(int id);
        public Task Save(Recipe entity);
        public void Update(Recipe entity);
        public void Delete(int id);
       
    }
}

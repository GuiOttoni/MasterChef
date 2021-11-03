using MasterChef.Domain.Models;
using MasterChef.Persistence.Contexts;
using MasterChef.Persistence.Repositories.Intefaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChef.Persistence.Repositories
{
    public class RecipeRepository:IRecipeRepository
    {
        private readonly DataContext _context;

        public RecipeRepository(DataContext context)
        {
        }

        public void Delete(int id)
        {
            var entity = _context.Recipe.FirstOrDefaultAsync(x => x.Id == id);
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public Task Save(Recipe entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Recipe entity)
        {
            throw new NotImplementedException();
        }
    }
}

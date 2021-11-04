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
            _context = context;
        }

        public async Task<List<Recipe>> List()
        {
            return await _context.Recipe.ToListAsync();
        }

        public void Delete(int id)
        {
            var entity = _context.Recipe.FirstOrDefault(x => x.Id == id);
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public async Task Save(Recipe entity)
        {
            entity.CreationDate = DateTime.Now;
            _context.Recipe.Add(entity);
            await _context.SaveChangesAsync();
        }

        public void Update(Recipe entity)
        {
            var existentEntity = _context.Recipe.FirstOrDefault(x => x.Id == entity.Id);
            existentEntity.IdCategory = entity.IdCategory;
            existentEntity.Chef = entity.Chef;
            existentEntity.Title = entity.Title;
            existentEntity.Preparation = entity.Preparation;
            existentEntity.Ingredients = entity.Ingredients;
            existentEntity.UpdateDate = DateTime.Now;

            _context.Update(existentEntity);
            _context.SaveChanges();

        }

        public async Task<Recipe> Get(int id)
        {
            var entity = await _context.Recipe.FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }
    }
}

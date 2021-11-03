using MasterChef.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChef.Persistence.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var defaultCategories = new List<Category> {
                new Category
                {
                    Name="Doçes",
                    Description="Bolos e outros"
                },
                new Category
                {
                    Name="Salgados",
                    Description="Tortas e outros"
                },
                new Category
                {
                    Name="Saúdavel",
                    Description="Para os atletas de plantão"
                },
                new Category
                {
                    Name="Gordurosa",
                    Description="Frituras e tudo que você mais ama"
                }
            };

            modelBuilder.Entity<Category>().HasData(defaultCategories.ToArray());
        }

        public DbSet<Recipe> Recipe {get;set;}
        public DbSet<Category> Category {get;set;}

    }
}

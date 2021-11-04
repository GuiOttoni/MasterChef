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
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> opts) : base(opts)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                var connection = @"Server=(localdb)\mssqllocaldb;Database=MasterChef;Trusted_Connection=True;MultipleActiveResultSets=True";
                options.UseSqlServer(connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var defaultCategories = new List<Category> {
                new Category
                {
                    Id=1,
                    Name="Doçes",
                    Description="Bolos e outros"
                },
                new Category
                {
                    Id=2,
                    Name="Salgados",
                    Description="Tortas e outros"
                },
                new Category
                {
                    Id=3,
                    Name="Saúdavel",
                    Description="Para os atletas de plantão"
                },
                new Category
                {
                    Id=4,
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

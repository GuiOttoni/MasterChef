using System;

namespace MasterChef.Domain.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        public int IdCategory { get; set; }

        //public Categoria Categoria { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Chef { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public string Preparation { get; set; }
        public string Ingredients { get; set; }
        public byte[] Image { get; set; }
        //public bool Excluido { get; set; }

        public int DifficultyLevel { get; set; }
    }
}

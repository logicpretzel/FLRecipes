using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace FLRecipes.Models
{
    public class RecipeDb : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<UnitMeasure> Units { get; set; }



    }
}
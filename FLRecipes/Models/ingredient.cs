using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLRecipes.Models
{
    public class Ingredient
    {
        public int ID { get; set; }
        public int RecipeID { get; set; }
        public decimal Quantity { get; set; }
        public int UnitsID { get; set; }
        public string Description { get; set; }

    }
}

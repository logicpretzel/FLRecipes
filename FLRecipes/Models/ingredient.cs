using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLRecipes.Models
{
    /// <summary>
    /// Author: Dar Dunham
    /// Date: 2/15/16
    /// Model
    /// </summary>
    public class Ingredient
    {
        public int ID { get; set; }
        public int RecipeID { get; set; }
        public decimal Quantity { get; set; }
        public int UnitsID { get; set; }
        public string Description { get; set; }

    }
}

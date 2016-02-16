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
    public class GCartItem
    {
        public int ID { get; set; }
        public int GroceryCartID { get; set; }
        public string Description { get; set; }
        

    }
}

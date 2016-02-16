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
    public class GroceryCart
    {
        public int ID { get; set; }
        public int SubscriberID { get; set; }
        public  DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public ICollection<GCartItem> GCartItems { get; set; }

    }
}

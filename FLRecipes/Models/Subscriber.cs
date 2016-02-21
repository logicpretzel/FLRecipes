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
    public class Subscriber
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public int AccountCd { get; set; }
        public DateTime MemberSince { get; set; }
        public ICollection<GroceryCart> GroceryCarts { get; set; }
        public ICollection<MealPlan> MealPlans { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<Recipe> Recipes { get; set; }


    }
}

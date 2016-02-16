using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLRecipes.Models
{
    public class MealPlan
    {
        public int ID { get; set; }
        public int SubscriberID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public ICollection<MPlanItem> PlanItems { get; set; }
    }
}

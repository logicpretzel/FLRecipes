﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FLRecipes.Models
{
    public class Reviews
    {
        public enum eReviewStarRating {
            NONE = 0,
            One,
            Two,
            Three,
            Four,
            Five
        }

        public int ID { get; set; }
        public int RecipeID { get; set; }
        public string ReviewerDisplayName { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
        public bool TriedRecipe { get; set; }

        public bool IsUser { get; set; }
        public int UserID { get; set; }
        public bool IsValidated { get; set; }


    }
}
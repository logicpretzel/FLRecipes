﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FLRecipes.Models
{
    
    public class Recipe
    {
        public enum eCookingMethod {
            NONE = 0,
            STOVETOP,
            SIMMER,
            BAKE,
            BROIL,
            BOIL,
            ROAST,
            TOAST,
            GRILL,
            FRY,
            DEEPFRY,
            CHILL,
            FREEZE
        }

        public enum eReleasedFlag {
            NEW = 0,
            EDITED,
            REVIEWING,
            RELEASED,
            REJECTED
        }

        private eReleasedFlag _releasedFlag;


        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Ingredients { get; set; }
        public string Preparation { get; set; }
        public string CookingInstructions { get; set; }
        public eCookingMethod CookingMethod { get; set; }
        public string ServingInstructions { get; set; }
        public string NutritionInformation { get; set; }
        public int NumberOfReviews { get; set; }
        public decimal Rating { get; set; }

        private int _submittedBy;
        public int SubmittedBy
        {
            get { return _submittedBy; }
            set { _submittedBy = value; }
        }
        public string SubmittedInitials { get; set; }

        public eReleasedFlag  ReleasedFlag
        {
            get { return _releasedFlag; }
            set { _releasedFlag = value; }
        }
        public string PictureURL { get; set; }
        public string PictureCaption { get; set; }
        public int PicWidth { get; set; }
        public int PicHeight { get; set; }




    }
}
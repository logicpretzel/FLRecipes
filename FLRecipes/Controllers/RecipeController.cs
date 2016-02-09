using FLRecipes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FLRecipes.Controllers
{
    public class RecipeController : Controller
    {
        RecipeDb _db = new RecipeDb();
        // GET: Recipe
        public ActionResult Index()
        {
            var model = _db.Recipes.ToList();
            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
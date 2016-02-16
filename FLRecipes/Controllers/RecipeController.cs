
using FLRecipes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FLRecipes.Controllers
{
    /// <summary>
    /// Author: Dar Dunham
    /// Date: 2/15/16
    /// Controller for Recipe Section of site
    /// </summary>
    public class RecipeController : Controller
    {
        RecipeDb _db = new RecipeDb();
        // (localdb)\MsSqlLocalDb
        // GET: Recipe
        public ActionResult Index()
        {
            var model = _db.Recipes.ToList();
            ViewBag.TotalRecipes =  model.Count();
            return View(model);
        }
        public ActionResult List() {
            var model = _db.Recipes.ToList();
            ViewBag.TotalRecipes = model.Count();
            return View(model);
        }



        public ActionResult Details(int? ID) {

            if (ID == null)
            {
                //  return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return RedirectToAction("List");
            }
            Recipe recipe = _db.Recipes.Find(ID);
            if (recipe == null)
            {
                return RedirectToAction("List");
            }
            return View(recipe);
        }

        public ActionResult Edit(int? ID)
        {

            if (ID == null)
            {
                //  return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return RedirectToAction("List");
            }
            Recipe recipe = _db.Recipes.Find(ID);
            if (recipe == null)
            {
                return RedirectToAction("List");
            }
            return View(recipe);
        }

        //[HttpPost, ActionName("Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name, ShortDescription, IngredientString, Preparation, CookingInstructions, ServingInstructions, NutritionInformation")]Recipe newRecipe)
        {
            if (newRecipe == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            if (TryUpdateModel(newRecipe))
            {
                try
                {
                    _db.Entry(newRecipe).State = EntityState.Modified;
                    _db.SaveChanges();

                    return RedirectToAction("List");
                }
                catch (DataException /* dex */)
                {
                    //TODO: Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(newRecipe);
        }

        public ActionResult Create() {
          
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name, ShortDescription, IngredientString, Preparation, CookingInstructions, ServingInstructions, NutritionInformation")]Recipe newRecipe)
        {

            if (ModelState.IsValid)
            {
                _db.Recipes.Add(newRecipe);
                _db.SaveChanges();
               

                return RedirectToAction("List");
            }
            else
            {
                return View(newRecipe);
            }
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
/* To Do:
//https://www.youtube.com/watch?v=QJJSnUVX6PA
*/
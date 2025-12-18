using Microsoft.AspNetCore.Mvc;
using ChristmasRecipes.Models;
using ChristmasRecipes.Models.ViewModels;
using ChristmasMVC.Data;

namespace ChristmasRecipes.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Index(string? search)
        {
            var recipes = RecipeData.SearchByName(search);
            return View(recipes);
        }
        

        public IActionResult Details(int id)
        {
            var recipes = RecipeData.GetRecipes();
            var recipe = recipes.FirstOrDefault(r => r.Id == id);

            if (recipe == null)
                return NotFound();

            var viewModel = new RecipeDetailsViewModel
            {
                Recipe = recipe,
                RelatedRecipes = recipes
                    .Where(r => r.CategoryId == recipe.CategoryId && r.Id != recipe.Id)
                    .Take(3)
                    .ToList()
            };

            return View(viewModel);
        }

        public IActionResult Category(int id)
        {
            var recipes = RecipeData.GetRecipes()
                .Where(r => r.CategoryId == id)
                .ToList();

            var category = RecipeData.GetCategories()
                .FirstOrDefault(c => c.Id == id);

            ViewBag.CategoryName = category?.Name ?? "Recipes";
            ViewBag.CategoryIcon = category?.Icon ?? "🎄";

            return View(recipes);
        }
    }
}
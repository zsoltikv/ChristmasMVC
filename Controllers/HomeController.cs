using Microsoft.AspNetCore.Mvc;
using ChristmasRecipes.Models;
using ChristmasRecipes.Models.ViewModels;
using ChristmasMVC.Data;

namespace ChristmasRecipes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var recipes = RecipeData.GetRecipes();
            var categories = RecipeData.GetCategories();

            var viewModel = new HomeViewModel
            {
                FeaturedRecipes = recipes.Take(3).ToList(),
                Categories = categories,
                LatestRecipes = recipes.OrderByDescending(r => r.CreatedDate).Take(6).ToList(),
                TotalRecipes = recipes.Count
            };

            return View(viewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data;
using RecommenderSystem.Models;
using System.Diagnostics;

namespace RecommenderSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly RecipeDataContext context;
        public HomeController(RecipeDataContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var recipes = this.context.Recipes.Include("Ingredients").ToList();
            return View(recipes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Data;
using RecommenderSystem.Models;
using RecommenderSystem.Models.ViewModel;
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
            var recipes = this.context.Recipes.Include(m => m.ingredient).Select(m => new RecipeViewModel
            {
                name = m.name,
                minutes = m.minutes,
                contributor_id = m.contributor_id,
                submitted= m.submitted,
                n_steps= m.n_steps,
                description= m.description, 
                n_ingredients = m.n_ingredients,
                ingredient = string.Join(',', m.ingredient.Select(a => a.name))

            });
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
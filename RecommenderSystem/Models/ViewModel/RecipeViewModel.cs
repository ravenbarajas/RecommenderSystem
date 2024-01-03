using System.ComponentModel.DataAnnotations;

namespace RecommenderSystem.Models.ViewModel
{
    public class RecipeViewModel
    {
        public string name { get; set; }

        public int minutes { get; set; }

        public int contributor_id { get; set; }

        public string submitted { get; set; }

        public string n_steps { get; set; }

        public string description { get; set; }

        public string n_ingredients { get; set; }

        public string ingredient { get; set; }
    }
}

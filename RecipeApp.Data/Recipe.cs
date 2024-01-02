using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RecipeApp.Data
{
    public class Recipe
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]

        public int minutes { get; set; }

        public int contributor_id { get; set; }

        public string submitted { get; set; }

        public string n_steps { get; set; }

        public string description { get; set; }

        public string n_ingredients { get; set; }

        public List<Ingredient> ingredient { get; set; }
    }
    public class Ingredient
    {
        public int id { get; set; }

        public string name { get; set; }
    }
}

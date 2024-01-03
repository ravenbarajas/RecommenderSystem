using RecipeApp.Data;

namespace RecommenderSystem
{
    public static class DataSeeder
    {
        public static void Seed(this IHost host)
        { 
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<RecipeDataContext>();
            context.Database.EnsureCreated();
            AddRecipes(context);
        }
        private static void AddRecipes(RecipeDataContext context)
        {
            var recipe = context.Recipes.FirstOrDefault();
            if (recipe != null) return;

            context.Recipes.Add(new Recipe
            { 
                name = "arriba   baked winter squash mexican style",
                minutes = 55,
                contributor_id = 47892,
                submitted = "9/16/2005",
                n_steps = "11",
                description = "\"autumn is my favorite time of year to cook! this recipe \r\ncan be prepared either spicy or sweet, your choice!\r\ntwo of my posted mexican-inspired seasoning mix recipes are offered as suggestions.\"\r\n",
                n_ingredients = "7",
                ingredient = new List<Ingredient>
                { 
                    new Ingredient{ name = "winter squash" },
                    new Ingredient{ name = "mexican seasoning" },
                    new Ingredient{ name = "mixed spice" },
                    new Ingredient{ name = "honey" },
                    new Ingredient{ name = "butter" },
                    new Ingredient{ name = "olive oil" },
                    new Ingredient{ name = "salt" }
                }
            });
            context.Recipes.Add(new Recipe
            {
                name = "a bit different  breakfast pizza",
                minutes = 55,
                contributor_id = 47892,
                submitted = "9/16/2005",
                n_steps = "11",
                description = "\"autumn is my favorite time of year to cook! this recipe \r\ncan be prepared either spicy or sweet, your choice!\r\ntwo of my posted mexican-inspired seasoning mix recipes are offered as suggestions.\"\r\n",
                n_ingredients = "3",
                ingredient = new List<Ingredient>
                {
                    new Ingredient{ name = "winter squash" },
                    new Ingredient{ name = "mexican seasoning" },
                    new Ingredient{ name = "mixed spice" },
                }
            });
            context.Recipes.Add(new Recipe
            {
                name = "all in the kitchen  chili",
                minutes = 55,
                contributor_id = 47892,
                submitted = "9/16/2005",
                n_steps = "11",
                description = "\"autumn is my favorite time of year to cook! this recipe \r\ncan be prepared either spicy or sweet, your choice!\r\ntwo of my posted mexican-inspired seasoning mix recipes are offered as suggestions.\"\r\n",
                n_ingredients = "5",
                ingredient = new List<Ingredient>
                {
                    new Ingredient{ name = "winter squash" },
                    new Ingredient{ name = "mexican seasoning" },
                    new Ingredient{ name = "mixed spice" },
                    new Ingredient{ name = "honey" },
                    new Ingredient{ name = "butter" },
                }
            });
            context.Recipes.Add(new Recipe
            {
                name = "alouette  potatoes",
                minutes = 55,
                contributor_id = 47892,
                submitted = "9/16/2005",
                n_steps = "11",
                description = "\"autumn is my favorite time of year to cook! this recipe \r\ncan be prepared either spicy or sweet, your choice!\r\ntwo of my posted mexican-inspired seasoning mix recipes are offered as suggestions.\"\r\n",
                n_ingredients = "3",
                ingredient = new List<Ingredient>
                {
                    new Ingredient{ name = "winter squash" },
                    new Ingredient{ name = "mexican seasoning" },
                    new Ingredient{ name = "mixed spice" },
                }
            });
            context.Recipes.Add(new Recipe
            {
                name = "all in the kitchen  chili",
                minutes = 55,
                contributor_id = 47892,
                submitted = "9/16/2005",
                n_steps = "11",
                description = "\"autumn is my favorite time of year to cook! this recipe \r\ncan be prepared either spicy or sweet, your choice!\r\ntwo of my posted mexican-inspired seasoning mix recipes are offered as suggestions.\"\r\n",
                n_ingredients = "4",
                ingredient = new List<Ingredient>
                {
                    new Ingredient{ name = "winter squash" },
                    new Ingredient{ name = "mexican seasoning" },
                    new Ingredient{ name = "mixed spice" },
                    new Ingredient{ name = "honey" },
                }
            });

            context.SaveChanges();
        }
    }
}

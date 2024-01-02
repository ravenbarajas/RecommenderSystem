using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Data
{
    public class RecipeDataContext : DbContext
    {
        public RecipeDataContext(DbContextOptions<RecipeDataContext> options):
            base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<Recipe> Recipes { get;set; }
        public DbSet<Ingredient> Ingredients { get;set; }   

    }
}

namespace ChristmasRecipes.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<Recipes> FeaturedRecipes { get; set; }
        public List<Category> Categories { get; set; }
        public List<Recipes> LatestRecipes { get; set; }
        public int TotalRecipes { get; set; }

        // Kategóriánkénti statisztikák
        public int TotalCookies => RecipesByCategory(1);
        public int TotalDesserts => RecipesByCategory(2);
        public int TotalDrinks => RecipesByCategory(3);
        public int TotalMainDishes => RecipesByCategory(4);

        private int RecipesByCategory(int categoryId)
        {
            if (LatestRecipes == null) return 0; 
            return LatestRecipes.Count(r => r.CategoryId == categoryId);
        }
    }

    public class RecipeDetailsViewModel
    {
        public Recipes Recipe { get; set; }
        public List<Recipes> RelatedRecipes { get; set; }
    }
}
namespace ChristmasRecipes.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<Recipes> FeaturedRecipes { get; set; }
        public List<Category> Categories { get; set; }
        public List<Recipes> LatestRecipes { get; set; }
        public int TotalRecipes { get; set; }
    }

    public class RecipeDetailsViewModel
    {
        public Recipes Recipe { get; set; }
        public List<Recipes> RelatedRecipes { get; set; }
    }
}
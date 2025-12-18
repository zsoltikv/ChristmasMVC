namespace ChristmasRecipes.Models
{
    public class Recipes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PrepTime { get; set; } // minutes
        public int CookTime { get; set; } // minutes
        public int Servings { get; set; }
        public string Difficulty { get; set; } // Easy, Medium, Hard
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Instructions { get; set; }
        public List<string> Tips { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public List<Recipes> Recipes { get; set; }
    }

    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public int RecipeId { get; set; }
        public Recipes Recipe { get; set; }
    }
}
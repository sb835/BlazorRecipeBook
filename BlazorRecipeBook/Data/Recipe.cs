using System.ComponentModel.DataAnnotations;

namespace BlazorRecipeBook.Data;


public class Recipe
{
    public int id { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 4, ErrorMessage = "The title must be between 4 and 50 characters.")]
    public string title { get; set; } = "";
    [Required]
    [Url(ErrorMessage = "Please enter a valid image URL.")]
    public string image { get; set; } = "";
    public int readyInMinutes { get; set; } = 0;
    public int servings { get; set; } = 0;
    public string summary { get; set; } = "";
    public string instructions { get; set; } = "";
    public List<Ingredient> extendedIngredients { get; set; } = new List<Ingredient>();
}

public class Ingredient
{
    public string name { get; set; } = "";
    public double amount { get; set; }
    public string unit { get; set; } = "";
}


public class RandomRecipeResponse
{
    public List<Recipe> recipes { get; set; } = new();
}

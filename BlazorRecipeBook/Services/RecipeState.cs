namespace BlazorRecipeBook.Services;
using BlazorRecipeBook.Data;

public class RecipeState
{
    public List<Recipe?> recipes { get; set; }
    public List<Recipe>? LoadedRandomRecipes { get; set; }
    private int Id { get; set; } = 0;

    public void AddRecipe(Recipe? recipe)
    {
        if (recipe != null)
        {
            recipe.id = Id;
            recipes.Add(recipe);
            Id += 1;
        }
    }

    public void RemoveRecipe(Recipe? recipe) { recipes.Remove(recipe); }

    public Recipe? FindById(int id)
    {
        return recipes.FirstOrDefault(r => r?.id == id);
    }
}

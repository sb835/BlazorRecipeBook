namespace BlazorRecipeBook.Services;

using BlazorRecipeBook.Data;
using System.Net.Http.Json;

public class SpoonacularService
{
    private readonly HttpClient _http;
    private readonly string _apiKey = "d9b83e2b5eda41649de99ec674f92352";

    public SpoonacularService(IHttpClientFactory factory)
    {
        _http = factory.CreateClient("Spoonacular");
    }

    public async Task<List<Recipe>> GetRandomRecipesAsync(int count = 1)
    {
        var url = $"recipes/random?number={count}&apiKey={_apiKey}";
        var response = await _http.GetFromJsonAsync<RandomRecipeResponse>(url);
        return response?.recipes ?? new List<Recipe>();
    }
}

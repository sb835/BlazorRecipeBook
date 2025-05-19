namespace BlazorRecipeBook.Services;

public class RatingService
{
    Dictionary<int, int> ratings = new Dictionary<int, int>();

    public void UpdateRating(int id, int rating)
    {
        ratings[id] = rating;
    }

    public int? GetRating(int id)
    {
        return ratings.TryGetValue(id, out var result) ? result : null;
    }
}

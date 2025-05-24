namespace Forum.Application.Features.Categories.Responses;

public class CreateCategoryResponse
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int PostCount { get; set; }
    public string ImageUrl { get; set; }
}
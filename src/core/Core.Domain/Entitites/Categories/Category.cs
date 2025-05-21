using Core.Domain.Entities.Categories.ValueObjects;

namespace Core.Domain.Entities.Categories;

public sealed class Category
{
    public CategoryId CategoryId { get; set; }
    public Name  Name { get; set; }
    public Description  Description { get; set; }
    public PostCount PostCount { get; set; } 
    public ImageUrl  ImageUrl { get; set; }
    private Category(CategoryId categoryId, Name name, Description description, PostCount postCount, ImageUrl imageUrl)
    {
        if (categoryId == null) throw new ArgumentNullException(nameof(categoryId));
        if (name == null) throw new ArgumentNullException(nameof(name));
        if (description == null) throw new ArgumentNullException(nameof(description));
        if (postCount == null) throw new ArgumentNullException(nameof(postCount));
        if (imageUrl == null) throw new ArgumentNullException(nameof(imageUrl));

        CategoryId = categoryId;
        Name = name;
        Description = description;
        PostCount = postCount;
        ImageUrl = imageUrl;
    }


    public static Category Create(CategoryId categoryId, Name name, Description description, PostCount postCount, ImageUrl imageUrl)
    {
        return new Category(categoryId, name, description, postCount, imageUrl);
        
    }
    public void UpdateDescription(Description  newDescription)
    {
        if (newDescription == null) 
            throw new ArgumentNullException(nameof(newDescription));
        Description = newDescription;
    }
}

﻿

using Core.Domain.Entities.Categories.ValueObjects;

namespace Forum.Application.Features.Categories.Responses;

public class CategoryResponse
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int PostCount { get; set; }
    public string ImageUrl { get; set; }
}

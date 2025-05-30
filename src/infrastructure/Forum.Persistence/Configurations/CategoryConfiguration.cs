using Core.Domain.Entities.Categories;
using Core.Domain.Entities.Categories.ValueObjects;
using Forum.Persistence.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Forum.Persistence.Configurations
{
    public sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
builder.ToTable("categories");

builder.HasKey(c => c.CategoryId);

builder.Property(c => c.CategoryId)
    .IsRequired()
    .ValueGeneratedNever()
    .HasConversion<CategoryIdConverters, CategoryIdComparer>();

builder.Property(c => c.Name)
    .IsRequired()
    .HasMaxLength(25)
    .HasConversion(name => name.Value, value => new Name(value));

builder.Property(c => c.Description)
    .IsRequired()
    .HasMaxLength(500)
    .HasConversion(description => description.Value, value => new Description(value));

builder.Property(x => x.PostCount)
    .IsRequired(false)
    .HasDefaultValue(new PostCount(0))
    .HasConversion(x => x.Value, value => new PostCount(value));

builder.Property(x => x.ImageUrl)
    .IsRequired(false)
    .HasConversion(imageUrl => imageUrl.Value, value => new ImageUrl(value));
        }
    }
}
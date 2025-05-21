using Core.Domain.Entities.Posts;
using Core.Domain.Entities.Posts.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Forum.Persistence.Converters;

namespace Forum.Persistence.Configurations
{
    internal sealed class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("posts");
            builder.HasKey(p => p.PostId);
            builder.Property(p => p.PostId)
                .IsRequired()
                .ValueGeneratedNever()
                .HasConversion<PostIdConverter, PostIdComparer>();
            builder.HasIndex(p => p.Title).IsUnique();
            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(25)
                .HasConversion(x => x.Value, value => new Title(value));
            builder.HasMany(p => p.Comments)
                .WithOne(c => c.Post)
                .HasForeignKey(c => c.PostId);
            builder.HasOne(p => p.Category)
                .WithMany()
                .HasForeignKey(p => p.CategoryId)
                .IsRequired();
            builder.Property(p => p.UserId)
                .HasConversion<UserIdConverter, UserIdComparer>();

        }
    }
}
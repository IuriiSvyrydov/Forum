
using Core.Domain.Entities.PostsStatus;
using Core.Domain.Entities.PostsStatus.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Forum.Persistence.Converters;

namespace Forum.Persistence.Configurations
{
    public sealed class PostStatusConfiguration : IEntityTypeConfiguration<PostStatus>
    {
        public void Configure(EntityTypeBuilder<PostStatus> builder)
        {
            builder.ToTable("post_status");
            builder.HasKey(p=>p.PostStatusId);
            builder.Property(p=>p.PostStatusId)
                .IsRequired()
                .ValueGeneratedNever()
                .HasConversion<PostStatusIdConverter,PostStatusIdComparer>();
            builder.HasIndex(p=>p.Name).IsUnique();
            builder.Property(p => p.Name).IsRequired()
                .HasMaxLength(25)
                .HasConversion(x => x.Value, value => new Name(value));
        }
        
    }
}
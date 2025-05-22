using Core.Domain.Entities.Comments;
using Core.Domain.Entities.Comments.ValueObjects;
using Core.Domain.Entities.Users.ValueObjects;
using Core.Domain.Entitites.Comments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Forum.Persistence.Converters;



namespace Forum.Persistence.Configurations
{
    internal sealed class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("comments");
            builder.HasKey(c => c.CommentId);
            builder.Property(c => c.CommentId)
                .IsRequired()
                .ValueGeneratedNever()
                .HasConversion<CommentIdConverter, CommentIdComparer>();

            builder.Property(c => c.Content)
                .IsRequired()
                .HasMaxLength(500)
                .HasConversion(
                    x => x.Value, 
                    value => new CommentContent(value));
            builder.HasOne(c => c.Post)
                .WithMany()
                .HasForeignKey(c => c.PostId)
                .IsRequired();
            builder.Property(p => p.UserId)
                .IsRequired()
                .HasConversion(
                    id => id.Value, // Преобразование UserId в Guid для хранения
                    value => new UserId(value) // Обратное преобразование
                );
            builder.HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .IsRequired();
        }
    }
}
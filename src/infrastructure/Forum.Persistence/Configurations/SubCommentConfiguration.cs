using Core.Domain.Entities.SubComments;
using Core.Domain.Entities.Users.ValueObjects;
using Core.Domain.Entitites.SubComments.ValueObjects;
using Forum.Persistence.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.Persistence.Configurations;

public sealed class SubCommentConfiguration: IEntityTypeConfiguration<SubComment>
{
    public void Configure(EntityTypeBuilder<SubComment> builder)
    {
        
        builder.ToTable("sub_comments");
        builder.HasKey(sc => sc.SubCommentId);
        builder.Property(sc => sc.SubCommentId)
            .IsRequired()
            .ValueGeneratedNever()
            .HasConversion<SubCommentIdConverters,SubCommentIdComparer>();
        builder.HasOne(sc => sc.Comment)
            .WithMany()
            .HasForeignKey(sc => sc.CommentId)
            .IsRequired();
        builder.HasOne(sc => sc.User)
            .WithMany()
            .HasForeignKey(sc => sc.UserId)
            .IsRequired();
        builder.Property(p => p.UserId)
            .IsRequired()
            .HasConversion(
                id => id.Value, // Преобразование UserId в Guid для хранения
                value => new UserId(value) // Обратное преобразование
            );
        builder.Property(x => x.SubCommentContent)
            .HasConversion(x => x.Value, value => new SubCommentContent(value));
    }
}
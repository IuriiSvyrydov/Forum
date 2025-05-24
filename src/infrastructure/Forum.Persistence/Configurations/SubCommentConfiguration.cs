using Core.Domain.Entities.Users.ValueObjects;
using Core.Domain.Entitites.SubComments.ValueObjects;
using Core.Domain.Entitites.Users.ValueObjects;
using Forum.Persistence.Converters;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Forum.Persistence.Configurations;


public class SubCommentConfiguration : IEntityTypeConfiguration<SubComment>
{
    public void Configure(EntityTypeBuilder<SubComment> builder)
    {
        builder.ToTable("sub_comments");
        builder.HasKey(sc => sc.SubCommentId);
        builder.Property(sc => sc.SubCommentId)
            .IsRequired()
            .ValueGeneratedNever()
            .HasConversion<SubCommentIdConverters, SubCommentIdComparer>();
        builder.Property(sc=>sc.SubCommentContent)
            .HasMaxLength(500)
            .IsRequired(false)
            .HasConversion(x=>x.Value,value=>new SubCommentContent(value));
 
        builder.HasOne(sc => sc.Comment)
            .WithMany(c => c.SubComments)
            .HasForeignKey(sc => sc.CommentId)
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);
        builder.Property(sc => sc.UserId)
            .IsRequired()
            .HasConversion(
                id => id.Value,
                value => new UserId(value));
        builder.HasOne(sc => sc.User)
            .WithMany()
            .HasForeignKey(sc => sc.UserId)
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);
    }
}




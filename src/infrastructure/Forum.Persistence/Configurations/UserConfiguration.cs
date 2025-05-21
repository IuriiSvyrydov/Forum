using Core.Domain.Entities.Users;
using Core.Domain.Entities.Users.ValueObjects;
using Forum.Persistence.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.Persistence.Configurations
{
    internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");
            builder.HasKey(u=>u.UserId);
            builder.Property(u=>u.UserId)
                .IsRequired()
                .ValueGeneratedNever()
                .HasConversion<UserIdConverter,UserIdComparer>();
            builder.HasIndex(u=>u.Email).IsUnique();
            builder.Property(u=>u.Email)
                .IsRequired()
                .HasMaxLength(25)
                .HasConversion(x=>x.Value,value=>new Email(value));
            builder.Property(u=>u.Username)
                .IsRequired()
                .HasMaxLength(25)
                .HasConversion(x=>x.Value,value=>new Username(value));
            builder.Property(u=>u.ProfilePictureUrl)
                .IsRequired(false)
                .HasConversion(x=>x.Value,value=>new ProfilePictureUrl(value));
            
        }
    }
}
using System.Reflection;
using Core.Domain.Entities.Categories;
using Core.Domain.Entities.Categories.ValueObjects;
using Core.Domain.Entities.Comments;
using Core.Domain.Entities.Comments.ValueObjects;
using Core.Domain.Entities.Posts;
using Core.Domain.Entities.SubComments;
using Core.Domain.Entities.SubComments.ValueObjects;
using Core.Domain.Entities.Users;
using Core.Domain.Entities.Users.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Forum.Persistence.EntityFramework;

public sealed class AppDbContext: DbContext
{

    
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
        
    }
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Comment> Comments { get; set; } = null!;
    public DbSet<SubComment> SubComments { get; set; } = null!;
    public DbSet<Post> Posts { get; set; }  = null!;
    public DbSet<User> Users { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Указываем EF Core игнорировать тип `SubCommentContent` из разных пространств имен
 

        
        modelBuilder.Entity<CategoryId>().HasNoKey();
        modelBuilder.Entity<CommentId>().HasNoKey();
        modelBuilder.Entity<SubCommentId>().HasNoKey();
        modelBuilder.Entity<UserId>().HasNoKey();

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
using System.Reflection;
using Core.Domain.Entities.Categories;
using Core.Domain.Entities.Comments;
using Core.Domain.Entities.Posts;
using Core.Domain.Entities.SubComments;
using Core.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Forum.Persistence.EntityFramework;

public sealed class AppDbContext: DbContext
{
    public AppDbContext()
    {
        
    }
    
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
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}
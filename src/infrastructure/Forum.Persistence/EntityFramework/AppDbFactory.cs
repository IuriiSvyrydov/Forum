

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Forum.Persistence.EntityFramework
{
    public sealed class AppDbFactory: IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-CR0ELGM;Database=ForumDb;Trusted_Connection=True;TrustServerCertificate=True");
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SporcialAPI.Persistence.Contexts;

namespace SporcialAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SporcialAPIDbContext>
    {
        public SporcialAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<SporcialAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql("User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=SporcialAPIDb;Pooling=true;Connection Lifetime=0;");
            return new SporcialAPIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}



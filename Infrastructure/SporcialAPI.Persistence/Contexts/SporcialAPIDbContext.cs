using Microsoft.EntityFrameworkCore;
using SporcialAPI.Domain.Entities;

namespace SporcialAPI.Persistence.Contexts
{
    public class SporcialAPIDbContext : DbContext
    {
        public SporcialAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<HealthInformation> HealthInformations { get; set; }
        public DbSet<UserActivity> UserActivities { get; set; }
        public DbSet<User> Users {get;set;}
    }
}


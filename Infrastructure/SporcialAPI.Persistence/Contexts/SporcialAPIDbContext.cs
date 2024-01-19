using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SporcialAPI.Domain.Entities;
using SporcialAPI.Domain.Entities.Identity;

namespace SporcialAPI.Persistence.Contexts
{
    public class SporcialAPIDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public SporcialAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<HealthInformation> HealthInformations { get; set; }
        public DbSet<UserActivity> UserActivities { get; set; }
        public DbSet<User> Users {get;set;}
    }
}


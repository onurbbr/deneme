using Microsoft.EntityFrameworkCore;
using SporcialAPI.Application.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using SporcialAPI.Persistence.Concretes;
using SporcialAPI.Persistence.Contexts;
using SporcialAPI.Domain.Entities.Identity;

namespace SporcialAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<SporcialAPIDbContext>(options => options.UseNpgsql("User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=SporcialAPIDb;Pooling=true;Connection Lifetime=0;"));
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<SporcialAPIDbContext>();
            services.AddSingleton<IUserActivityService, UserActivityService>();
            services.AddSingleton<IHealthInformationService, HealthInformationService>();
            services.AddSingleton<IUserService, UserService>();
        }
    }
}

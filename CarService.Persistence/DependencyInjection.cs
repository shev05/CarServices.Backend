using CarServices.Application.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarServices.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection
            services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<CarServicesDbContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
            services.AddScoped<ICarServiceDbContext>(provider =>
            provider.GetService<CarServicesDbContext>());
            return services;
        }
    }
}

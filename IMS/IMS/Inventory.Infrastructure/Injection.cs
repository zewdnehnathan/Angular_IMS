using Inventory.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestApp.Infrastructure;

namespace Inventory.Infrastructure
{
    public static class Injection
    {
        public static IServiceCollection RegisterInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<InventoryContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IInventoryContext>(optiont => optiont.GetService<InventoryContext>());

            return services;
        }
    }
}

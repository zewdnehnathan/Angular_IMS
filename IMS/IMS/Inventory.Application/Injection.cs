using Inventory.Application.Features;
using Inventory.Application.Interfaces;
using Inventory.Domain.Interfaces.Repository;
using Inventory.Infrastructure.Repository;
using ItemRequest.Domain.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Inventory.Application
{
    public static class Injection
    {
        public static IServiceCollection RegisterApplicationService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IRequestItemRepository<RequestModel>, ItemRequestRepository>();

            services.AddTransient<IItemRequestService, RequestItemService>();

            services.AddScoped<IPurchaseRepository, PurchaseRepository>();

            services.AddScoped<IPurchaseService, PurchaseServices>();

            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}

using Manager.Services.Abstraction;
using Manager.Services.Implementation;

namespace TestTaskApp.Extensions
{
    public static class BusinessLogicServiceCollectionExtensions
    {
        public static IServiceCollection SetupBusinessLogic(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderProductService, OrderProductService>();

            return services;
        }
    }
}


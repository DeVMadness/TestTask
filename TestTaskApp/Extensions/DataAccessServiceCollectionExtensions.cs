using Provider.Repositories.Abstraction;
using Provider.Repositories.Implementation;

namespace TestTaskApp.Extensions
{
    public static class DataAccessServiceCollectionExtensions
    {
        public static IServiceCollection SetupDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserRepository>(sp => new UserRepository(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<ICustomerRepository>(sp => new CustomerRepository(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IProductRepository>(sp => new ProductRepository(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IOrderRepository>(sp => new OrderRepository(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IOrderProductRepository>(sp => new OrderProductRepository(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }

}

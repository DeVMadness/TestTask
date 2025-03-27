using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Provider.Repositories.Abstraction;
using Provider.Repositories.Implementation;

namespace TestTaskApp.Extensions
{
    public static class DataAccessServiceCollectionExtension
    {
        public static IServiceCollection SetupDataAccess(this IServiceCollection services)
        {
            var connectionString = @Environment.GetEnvironmentVariable("TestTaskDb");

            services.AddSingleton<IUserRepository>(sp => new UserRepository(connectionString));
            services.AddSingleton<ICustomerRepository>(sp => new CustomerRepository(connectionString));
            services.AddSingleton<IProductRepository>(sp => new ProductRepository(connectionString));
            services.AddSingleton<IOrderRepository>(sp => new OrderRepository(connectionString));
            services.AddSingleton<IOrderProductRepository>(sp => new OrderProductRepository(connectionString));

            return services;
        }
    }
}


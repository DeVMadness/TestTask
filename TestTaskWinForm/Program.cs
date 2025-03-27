using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using TestTaskApp.Extensions;
using Manager.Services.Abstraction;

namespace TestTaskWinForm
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            var connectionString = Environment.GetEnvironmentVariable("TestTaskDb");

           

            services.SetupDataAccess();

            services.SetupBusinessLogic();

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(serviceProvider.GetRequiredService<IProductService>()));
        }
    }
}


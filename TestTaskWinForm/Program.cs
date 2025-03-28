using Microsoft.Extensions.Configuration;
using TestTaskApp.Extensions;
using Manager.Services.Abstraction;
using Provider.Repositories.Abstraction;
using Provider.Repositories.Implementation;
using Manager.Services.Implementation;
using TestTaskWinForm.Extensions;
using Integration.Service.Abstraction;
using Integration.Service.Implementation;


namespace TestTaskWinForm
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();  

            var connectionString = @Environment.GetEnvironmentVariable("TestTaskDb");
            ServiceProvider.Instance.Register<IProductRepository>(() => new ProductRepository(connectionString));
            ServiceProvider.Instance.Register<IProductService>(
                () => new ProductService(ServiceProvider.Instance.GetService<IProductRepository>())
            );
            var productService = ServiceProvider.Instance.GetService<IProductService>();

            ServiceProvider.Instance.Register<IUserRepository>(() => new UserRepository(connectionString));
            ServiceProvider.Instance.Register<IUserService>(
                () => new UserService(ServiceProvider.Instance.GetService<IUserRepository>())
            );
            var userService = ServiceProvider.Instance.GetService<IUserService>();


            HttpClient httpClient = new HttpClient();

            ServiceProvider.Instance.Register<ITaxRateService>(
                () => new TaxRateService()
            );
            ServiceProvider.Instance.Register<ITaxRateService>(
                () => new TaxRateService()
            );

            var taxRateService = ServiceProvider.Instance.GetService<ITaxRateService>();

            //Application.Run(new TaxRateView(taxRateService));
            //Application.Run(new ProductView(productService));
            //Application.Run(new UserView(userService));



        }
    }
}


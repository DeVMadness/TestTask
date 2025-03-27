using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Provider.Repositories.Implementation;
using Provider.Repositories.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using Manager.Services;

using TestTaskApp.Extensions;

namespace TestTaskApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.SetupDataAccess(builder.Configuration);

           
           

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var userRepository = scope.ServiceProvider.GetRequiredService<IUserRepository>();
                userRepository.GetUserByID(2);

            }

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

          
            app.Run();
        }
    }
}
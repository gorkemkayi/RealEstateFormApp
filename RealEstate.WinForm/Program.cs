using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealEstate.Application.Interfaces;
using RealEstate.Application.Mapping;
using RealEstate.Infrastructure.Context;
using RealEstate.Infrastructure.Repositories;

namespace RealEstate.WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            var connectionString=configuration.GetConnectionString("DefaultConnection");

            var services = new ServiceCollection();

            services.AddLogging();

            services.AddDbContext<RealEstateDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<GeneralMapping>();
            });
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<ICustomerRepository,CustomerRepository>();
            services.AddScoped<IEstateRepository, EstateRepository>();

            var serviceProvider = services.BuildServiceProvider();

            //var form1=ActivatorUtilities.CreateInstance<Form1>(serviceProvider);
            var loginForm = ActivatorUtilities.CreateInstance<LoginForm>(serviceProvider);
            //System.Windows.Forms.Application.Run(form1);
            System.Windows.Forms.Application.Run(loginForm);
        }
    }
}
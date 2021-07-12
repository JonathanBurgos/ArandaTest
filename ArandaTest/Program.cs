using ArandaBusiness.Repositories;
using ArandaBusiness.Repositories.Implementations;
using ArandaBusiness.Services;
using ArandaBusiness.Services.Implementations;
using ArandaData.Connection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace ArandaTest
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider =  services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }         
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IGenericServices, GenericServices>().AddScoped<Form1>();
            services.AddScoped<IGenericRepository, GenericRepository>().AddScoped<Form1>();
            var connectionString = "Aranda.db";
            services.AddDbContext<ArandaDbContext>(options => options.UseSqlite(connectionString));

        }
    }
}

using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CarParkABP.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class CarParkABPMigrationsDbContextFactory : IDesignTimeDbContextFactory<CarParkABPMigrationsDbContext>
    {
        public CarParkABPMigrationsDbContext CreateDbContext(string[] args)
        {
            CarParkABPEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<CarParkABPMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new CarParkABPMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../CarParkABP.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CarParkABP.Data;
using Volo.Abp.DependencyInjection;

namespace CarParkABP.EntityFrameworkCore
{
    public class EntityFrameworkCoreCarParkABPDbSchemaMigrator
        : ICarParkABPDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCarParkABPDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CarParkABPMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CarParkABPMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
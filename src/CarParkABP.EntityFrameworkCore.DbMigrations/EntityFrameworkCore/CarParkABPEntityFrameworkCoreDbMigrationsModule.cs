using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace CarParkABP.EntityFrameworkCore
{
    [DependsOn(
        typeof(CarParkABPEntityFrameworkCoreModule)
        )]
    public class CarParkABPEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CarParkABPMigrationsDbContext>();
        }
    }
}

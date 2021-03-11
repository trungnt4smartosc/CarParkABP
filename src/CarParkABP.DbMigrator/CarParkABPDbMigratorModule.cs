using CarParkABP.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CarParkABP.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CarParkABPEntityFrameworkCoreDbMigrationsModule),
        typeof(CarParkABPApplicationContractsModule)
        )]
    public class CarParkABPDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

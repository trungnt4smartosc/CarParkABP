using Volo.Abp.Modularity;

namespace CarParkABP
{
    [DependsOn(
        typeof(CarParkABPApplicationModule),
        typeof(CarParkABPDomainTestModule)
        )]
    public class CarParkABPApplicationTestModule : AbpModule
    {

    }
}
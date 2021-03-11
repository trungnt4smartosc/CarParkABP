using CarParkABP.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CarParkABP
{
    [DependsOn(
        typeof(CarParkABPEntityFrameworkCoreTestModule)
        )]
    public class CarParkABPDomainTestModule : AbpModule
    {

    }
}
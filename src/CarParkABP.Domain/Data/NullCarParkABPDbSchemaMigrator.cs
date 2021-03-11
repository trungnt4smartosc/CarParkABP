using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CarParkABP.Data
{
    /* This is used if database provider does't define
     * ICarParkABPDbSchemaMigrator implementation.
     */
    public class NullCarParkABPDbSchemaMigrator : ICarParkABPDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
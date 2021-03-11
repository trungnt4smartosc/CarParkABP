using System.Threading.Tasks;

namespace CarParkABP.Data
{
    public interface ICarParkABPDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

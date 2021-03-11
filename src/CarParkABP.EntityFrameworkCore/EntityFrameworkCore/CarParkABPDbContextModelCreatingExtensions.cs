using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace CarParkABP.EntityFrameworkCore
{
    public static class CarParkABPDbContextModelCreatingExtensions
    {
        public static void ConfigureCarParkABP(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(CarParkABPConsts.DbTablePrefix + "YourEntities", CarParkABPConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
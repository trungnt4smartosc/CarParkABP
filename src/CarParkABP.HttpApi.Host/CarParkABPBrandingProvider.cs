using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CarParkABP
{
    [Dependency(ReplaceServices = true)]
    public class CarParkABPBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "CarParkABP";
    }
}

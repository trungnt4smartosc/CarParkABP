using Volo.Abp.Settings;

namespace CarParkABP.Settings
{
    public class CarParkABPSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CarParkABPSettings.MySetting1));
        }
    }
}

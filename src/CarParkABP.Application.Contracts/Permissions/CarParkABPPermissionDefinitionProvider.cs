using CarParkABP.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CarParkABP.Permissions
{
    public class CarParkABPPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var carParkGroup = context.AddGroup(CarParkABPPermissions.GroupName, L("Permission:CarParkABP"));

            var carParkPermission = carParkGroup.AddPermission(CarParkABPPermissions.CarPark.Default, L("Permission:CarPark"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CarParkABPResource>(name);
        }
    }
}

using CarParkABP.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CarParkABP.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CarParkABPController : AbpController
    {
        protected CarParkABPController()
        {
            LocalizationResource = typeof(CarParkABPResource);
        }
    }
}
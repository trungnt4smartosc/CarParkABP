using System;
using System.Collections.Generic;
using System.Text;
using CarParkABP.Localization;
using Volo.Abp.Application.Services;

namespace CarParkABP
{
    /* Inherit your application services from this class.
     */
    public abstract class CarParkABPAppService : ApplicationService
    {
        protected CarParkABPAppService()
        {
            LocalizationResource = typeof(CarParkABPResource);
        }
    }
}

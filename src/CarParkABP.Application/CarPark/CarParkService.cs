using CarParkABP.Permissions;
using CarParkABP.Utilities;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkABP.CarPark
{
    public class CarParkService : CarParkABPAppService, ICarParkService
    {
        private readonly HttpHelper<CarParkAvailabilityDto> httpHelper;
        public CarParkService()
        {
            httpHelper = new HttpHelper<CarParkAvailabilityDto>();
        }

        [Authorize(CarParkABPPermissions.CarPark.Default)]
        public async Task<List<CarParkData>> GetCarParkAvailabilities()
        {
            var response = await httpHelper.SendGetRequestAsync(CarParkConstants.CarParkAvailabilityAPI + $"?date_time={DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")}");

            var result = response.Items.FirstOrDefault()?.CarParkData.Take(20).ToList();

            return result;
        }

        //...SERVICE METHODS WILL COME HERE...
    }
}

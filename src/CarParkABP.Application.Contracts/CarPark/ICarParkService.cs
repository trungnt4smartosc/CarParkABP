﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CarParkABP.CarPark
{
    public interface ICarParkService : IApplicationService
    {
        Task<List<CarParkData>> GetCarParkAvailabilities();
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Madar
{
    public interface IPrayerTimesService : IApplicationService
    {
        //Task<PrayerItemDto> GetPrayerListAsync();
        Task<PrayerItemDto> GetPrayerListAsync(PrayerInputDTO prayer);
    }
}

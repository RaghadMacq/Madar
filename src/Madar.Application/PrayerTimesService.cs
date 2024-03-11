using System;
using System.Threading.Tasks;
using Newtonsoft.Json; // Ensure this is uncommented.
using System.Net.Http;
using Volo.Abp.Application.Services;
using Volo.Abp;

namespace Madar
{
   // [RemoteService(IsEnabled =false)]
    public class PrayerTimesService : ApplicationService, IPrayerTimesService
    {
        private readonly HttpClient _httpClient;

        public PrayerTimesService()
        {
            _httpClient = new HttpClient();
        }
       
        public async Task<PrayerItemDto> GetPrayerListAsync(PrayerInputDTO prayer)
        {
            string endpoint = "https://api.aladhan.com/v1/calendarByCity";
            string parameters = $"?city={prayer.city}&country={prayer.country}&method={prayer.method}&month={prayer.month}&year={prayer.year}";
            string uri = endpoint + parameters;

            HttpResponseMessage myResponse = await _httpClient.GetAsync(uri);
            if (!myResponse.IsSuccessStatusCode)
            {
                // Handle error or throw an exception
                throw new Exception("Failed to retrieve prayer times.");
            }
            string theResponse = await myResponse.Content.ReadAsStringAsync();
            dynamic resultObj = JsonConvert.DeserializeObject<dynamic>(theResponse);

            var timings = JsonConvert.DeserializeObject<PrayerItemDto>(resultObj.data[0].timings.ToString());
            return timings;
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Madar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrayerController : ControllerBase
    {
        private readonly IPrayerTimesService _PrayerTimesService;

        public PrayerController(IPrayerTimesService prayerTimesService)
        {
            _PrayerTimesService = prayerTimesService;
        }


        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PrayerInputDTO prayer)
        {
             var result = await _PrayerTimesService.GetPrayerListAsync(prayer);
            return Ok(result);
        }
    }
}

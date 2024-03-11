using System;
using System.Threading.Tasks;
using Volo.Abp.Account;
using Volo.Abp.DependencyInjection;

namespace Madar.HttpApi.Client.ConsoleTestApp;

public class ClientDemoService : ITransientDependency
{
    //private readonly IProfileAppService _profileAppService;
    private readonly IPrayerTimesService _prayerTimesService;


    public ClientDemoService(IPrayerTimesService prayerTimesService)
    {
        _prayerTimesService = prayerTimesService;
    }

    public async Task RunAsync()
    {
        var output = await _prayerTimesService.GetPrayerListAsync(PrayerInputDTO prayer);
        Console.WriteLine(output);
        
    }
}

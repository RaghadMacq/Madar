using System;
using Volo.Abp.Domain.Entities;

namespace Madar
{
    public class PrayerTimes : BasicAggregateRoot<Guid>
    {
        public string Fajr { get; set; }
        public string Sunrise { get; set; }
        public string Dhuhr { get; set; }
        public string Asr { get; set; }
        public string Sunset { get; set; }
        public string Maghrib { get; set; }
        public string Isha { get; set; }
    }
}

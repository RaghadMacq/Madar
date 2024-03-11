using Newtonsoft.Json;

namespace Madar
{
    public class PrayerItemDto
    {
        [JsonProperty("Fajr")]
        public string Fajr { get; set; }
        
        [JsonProperty("Sunrise")]
        public string Sunrise { get; set; }
        
        [JsonProperty("Dhuhr")]
        public string Dhuhr { get; set; }
        
        [JsonProperty("Asr")]
        public string Asr { get; set; }
        
        [JsonProperty("Sunset")]
        public string Sunset { get; set; }
        
        [JsonProperty("Maghrib")]
        public string Maghrib { get; set; }
        
        [JsonProperty("Isha")]
        public string Isha { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Madar
{
    public  class PrayerInputDTO
    {
        public string city { get; set; } = null!;
        public string country { get; set; } = null!;
        public int method { get; set; } 
        public int month { get; set; }
        public int year { get; set; }

    }
}

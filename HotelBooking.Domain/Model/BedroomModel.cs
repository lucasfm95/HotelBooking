using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Domain.Model
{
    public class BedroomModel
    {
        public int InactiveSingle { get; set; }
        public int ActiveSigle { get; set; }
        public int InactiveStandard { get; set; }
        public int ActiveStandard { get; set; }
        public int InactiveLuxury { get; set; }
        public int ActiveLuxury { get; set; }
    }
}

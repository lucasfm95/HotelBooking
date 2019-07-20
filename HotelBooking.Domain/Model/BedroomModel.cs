using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Domain.Model
{
    public class BedroomModel
    {
        public int TotalSigle { get; set; }
        public int ActiveSigle { get; set; }
        public int TotalStandard { get; set; }
        public int ActiveStandard { get; set; }
        public int TotalLuxury { get; set; }
        public int ActiveLuxury { get; set; }
    }
}

using HotelBooking.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Domain.Model
{
    public class BedroomModel
    {
        public eBedroomType Type { get; set; }
        public int Actives { get; set; }
        public int Inactives { get; set; }
    }
}

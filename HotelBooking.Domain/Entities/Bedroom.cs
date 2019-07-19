using HotelBooking.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Domain.Entities
{
    class Bedroom
    {
        public int Id { get; set; }
        public eBedroomType Type { get; set; }
        public bool Active { get; set; }
    }
}

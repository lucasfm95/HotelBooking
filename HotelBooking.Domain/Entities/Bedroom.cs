using HotelBooking.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Domain.Entities
{
    public class Bedroom : Entity
    {
        public Bedroom( ) : base()
        {
           
        }
        public eBedroomType Type { get; set; }
        public bool Active { get; set; }
    }
}

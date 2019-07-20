using HotelBooking.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Domain.Entities
{
    public class Bedroom : Entity
    {
        private static int m_Id = 1;
        public Bedroom( ) : base()
        {
            Id = m_Id++;
        }
        public eBedroomType Type { get; set; }
        public bool Active { get; set; }
    }
}

using HotelBooking.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Domain.Entities
{
    public abstract class Entity : IEntity
    {
        public Entity( )
        {
            Key = Guid.NewGuid( );
        }
        public long Id { get; set; }
        public Guid Key { get; set; }
    }
}

using HotelBooking.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Domain.Entities
{
    public abstract class Entity : IEntity
    {
        private static int m_Id = 1;
        public Entity( )
        {
            Key = Guid.NewGuid( );
            Id = m_Id++;
        }
        public long Id { get; set; }
        public Guid Key { get; set; }
    }
}

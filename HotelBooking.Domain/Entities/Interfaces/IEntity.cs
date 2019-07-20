using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Domain.Entities.Interfaces
{
    public interface IEntity
    {
        long Id { get; set; }
        Guid Key { get; set; }
    }
}

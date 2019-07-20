using HotelBooking.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Business.Business.Interfaces
{
    public interface IClientBusiness
    {
        bool CreateClient( ClientModel clientModel );
    }
}

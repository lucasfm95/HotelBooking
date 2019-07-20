using HotelBooking.Domain.Entities;
using HotelBooking.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Business.Business.Interfaces
{
    public interface IBedroomBusiness
    {
        bool CreateBedrooms( List<BedroomModel> p_BedroomModels );
    }
}

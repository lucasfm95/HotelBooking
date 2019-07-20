using HotelBooking.Business.Business.Interfaces;
using HotelBooking.Domain.Entities;
using HotelBooking.Domain.Model;
using System.Collections.Generic;

namespace HotelBooking.Business.Business
{
    public class BedroomBusiness : IBedroomBusiness
    {
        public List<Bedroom> CreateBedrooms( BedroomModel p_BedroomModel )
        {

            long id = 1;

            for ( int i = 0; i < p_BedroomModel.TotalSigle; i++ )
            {

            }
        }
    }
}

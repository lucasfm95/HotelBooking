using HotelBooking.Business.Business.Interfaces;
using HotelBooking.Domain.Entities;
using HotelBooking.Domain.Model;
using HotelBooking.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Services.Services
{
    public class BedroomService
    {
        private readonly IBedroomBusiness m_BedroomBusiness;
        public BedroomService( IBedroomBusiness p_BedroomBusiness )
        {
            m_BedroomBusiness = p_BedroomBusiness;
        }

        public bool Registration( List<BedroomModel> p_BedroomModels )
        {
            return m_BedroomBusiness.CreateBedrooms( p_BedroomModels );
        }
    }
}

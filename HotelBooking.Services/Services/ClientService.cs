using HotelBooking.Business.Business.Interfaces;
using HotelBooking.Domain.Entities;
using HotelBooking.Domain.Model;
using HotelBooking.Repository.Repositories;
using HotelBooking.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Services.Services
{
    public class ClientService
    {
        private readonly IClientBusiness m_ClientBusiness;
        public ClientService( IClientBusiness p_ClientBusiness )
        {
            m_ClientBusiness = p_ClientBusiness;
        }

        public void Registration( ClientModel clientModel )
        {
            m_ClientBusiness.CreateClient( clientModel );
        }

    }
}

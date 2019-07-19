using HotelBooking.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Services.Services
{
    class ClientService
    {
        private readonly IClientRepository m_ClientRepository;
        public ClientService( IClientRepository p_ClientRepository )
        {
            m_ClientRepository = p_ClientRepository;
        }

    }
}

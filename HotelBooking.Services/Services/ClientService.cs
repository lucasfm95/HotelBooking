using HotelBooking.Domain.Entities;
using HotelBooking.Repository.Repositories;
using HotelBooking.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Services.Services
{
    class ClientService
    {
        private readonly Repository<Client> m_ClientRepository;
        public ClientService( Repository<Client> p_ClientRepository )
        {
            m_ClientRepository = p_ClientRepository;
        }

    }
}

using AutoMapper;
using HotelBooking.Business.Business.Interfaces;
using HotelBooking.Domain.Entities;
using HotelBooking.Domain.Model;
using HotelBooking.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Business.Business
{
    public class ClientBusiness : IClientBusiness
    {
        private readonly Repository<Client> m_ClientRepository; 
        public ClientBusiness( Repository<Client>  p_ClientRepository )
        {
            m_ClientRepository = p_ClientRepository;
        }

        public bool CreateClient( ClientModel clientModel )
        {
            Client client = Mapper.Map<ClientModel, Client>( clientModel );
            return m_ClientRepository.Add( client );
        }
    }
}

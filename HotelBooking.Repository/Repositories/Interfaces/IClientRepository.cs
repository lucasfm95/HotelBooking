using HotelBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Repository.Repositories.Interfaces
{
    /// <summary>
    /// Contrato que respresenta o repositório do cliente
    /// </summary>
    public interface IClientRepository
    {
        List<Client> Clients { get; set; }
        List<Client> GetAll( );
        Client Find( int p_ClientId );
        bool Insert( );

    }
}

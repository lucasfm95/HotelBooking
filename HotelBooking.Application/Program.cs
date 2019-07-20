using HotelBooking.Business.Business;
using HotelBooking.Repository.Repositories;
using HotelBooking.Services.Services;
using System;

namespace HotelBooking.Application
{
    class Program
    {
        static void Main( string[] args )
        {
            // Dependencies
            BedroomRepository bedroomRepository = new BedroomRepository( );
            BedroomBusiness bedroomBusiness = new BedroomBusiness( bedroomRepository );

            ClientRepository clientRepository = new ClientRepository( );
            ClientBusiness clientBusiness = new ClientBusiness( clientRepository );

            Menu menu = new Menu( new BedroomService( bedroomBusiness ), new ClientService( clientBusiness ) );

            menu.Run( );
        }
    }
}

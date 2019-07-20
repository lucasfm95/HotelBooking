using System;

namespace HotelBooking.Application
{
    class Program
    {
        static void Main( string[] args )
        {
            // Dependencies
            Repository.Repositories.BedroomRepository bedroomRepository = new Repository.Repositories.BedroomRepository( );
            Business.Business.BedroomBusiness bedroomBusiness = new Business.Business.BedroomBusiness( bedroomRepository );

            Menu menu = new Menu( new Services.Services.BedroomService( bedroomBusiness ) );

            menu.Run( );
        }
    }
}

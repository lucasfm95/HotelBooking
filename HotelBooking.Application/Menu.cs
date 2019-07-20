using HotelBooking.Domain.Model;
using HotelBooking.Domain.ValueObj;
using HotelBooking.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelBooking.Application
{
    public class Menu
    {
        private readonly BedroomService m_BedroomService;
        public Menu( BedroomService p_BedroomService )
        {
            m_BedroomService = p_BedroomService;
        }

        public void Run( )
        {
            Console.WriteLine("Bem vindo ao Hotel Booking");
            Console.WriteLine("Sistema de reserva de quartos de hotel");

            bool runApp = true;

            do
            {
                Console.WriteLine("Escolha uma opção abaixo:");
                Console.WriteLine("1 - Carga de informações do sistema");
                Console.WriteLine("0 - Sair do sistema");

                int valueRead = Convert.ToInt32( Console.ReadLine( ) );

                switch ( valueRead )
                {
                    case 0:
                        Console.Clear( );
                        Console.WriteLine("Até logo...");
                        runApp = false;
                        break;
                    case 1:
                        SubMenuRegistrationDataApp( );
                        break;
                    default:
                        Console.WriteLine( "Opção inválida" );
                        break;
                }
            } while ( runApp );
        }

        private void SubMenuRegistrationDataApp( )
        {
            bool runSubMenu = true;
            do
            {
                Console.Clear( );
                Console.WriteLine( "Escolha uma opção abaixo:" );
                Console.WriteLine( "1 - Carga de informações de quartos" );
                Console.WriteLine( "0 - Voltar" );

                int valueRead = Convert.ToInt32( Console.ReadLine( ) );

                switch ( valueRead )
                {
                    case 0:
                        Console.Clear( );
                        runSubMenu = false;
                        break;
                    case 1:
                        RegistrationBedrooms( );
                        break;
                    default:
                        Console.WriteLine( "Opção inválida" );
                        break;
                }

            } while ( runSubMenu );
        }

        private void RegistrationBedrooms( )
        {

            List<BedroomModel> bedroomModels = new List<BedroomModel>( );
            foreach ( var item in Enum.GetValues(typeof(eBedroomType)).Cast<eBedroomType>( ).ToList() )
            {
                
                BedroomModel bedroomModel = new BedroomModel( );

                Console.Clear( );

                Console.WriteLine( $"Informe a quatidade total de quartos {item.GetDescription()}:" );

                int totalbedrooms = Convert.ToInt32( Console.ReadLine( ) );

                Console.Clear( );

                Console.WriteLine( $"Informe a quatidade de quartos para reserva {item.GetDescription()}:" );

                int activesBedrooms =  Convert.ToInt32( Console.ReadLine( ) );

                bedroomModels.Add( new BedroomModel( )
                {
                    Type = item,
                    Actives = activesBedrooms,
                    Inactives = totalbedrooms - activesBedrooms
                });
            }

            if ( m_BedroomService.Registration( bedroomModels ) )
            {
                Console.WriteLine( "Dados inseridos com sucesso" );
            }
        }
    }
}

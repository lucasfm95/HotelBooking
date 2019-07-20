using HotelBooking.Domain.Model;
using HotelBooking.Services.Services;
using System;
using System.Collections.Generic;
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
            Console.Clear( );
            // Single
            Console.WriteLine( "Informe a quatidade total de quartos single:" );
            int totalSingle = Convert.ToInt32( Console.ReadLine( ) );

            Console.Clear( );

            Console.WriteLine("Informe a quatidade de quartos para reserva sigle:");
            int single = Convert.ToInt32( Console.ReadLine( ) );

            Console.Clear( );

            //Standard
            Console.WriteLine( "Informe a quatidade total de quartos standard:" );
            int totalStandard = Convert.ToInt32( Console.ReadLine( ) );

            Console.Clear( );

            Console.WriteLine( "Informe a quatidade de quartos para reserva standard:" );
            int standard = Convert.ToInt32( Console.ReadLine( ) );

            Console.Clear( );

            Console.WriteLine( "Informe a quatidade total de quartos luxury:" );
            int totalLuxury = Convert.ToInt32( Console.ReadLine( ) );

            Console.Clear( );

            Console.WriteLine( "Informe a quatidade de quartos para reserva luxury:" );
            int luxury = Convert.ToInt32( Console.ReadLine( ) );

            BedroomModel bedroomModel = new BedroomModel( )
            {
                ActiveSigle = single,
                InactiveSingle = totalSingle - single,
                ActiveStandard = standard,
                InactiveStandard = totalStandard - standard,
                ActiveLuxury = luxury,
                InactiveLuxury = totalLuxury - standard
            };

            if(m_BedroomService.Registration( bedroomModel ) )
            {
                Console.WriteLine("Dados inseridos com sucesso");
            }
        }
    }
}

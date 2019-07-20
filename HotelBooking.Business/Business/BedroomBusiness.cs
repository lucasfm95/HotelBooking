using HotelBooking.Business.Business.Interfaces;
using HotelBooking.Domain.Entities;
using HotelBooking.Domain.Model;
using HotelBooking.Domain.ValueObj;
using HotelBooking.Repository.Repositories.Interfaces;
using System.Collections.Generic;

namespace HotelBooking.Business.Business
{
    public class BedroomBusiness : IBedroomBusiness
    {
        private readonly IBedroomRepository m_BedroomRepository;
        public BedroomBusiness( IBedroomRepository p_BedroomRepository )
        {
            m_BedroomRepository = p_BedroomRepository;
        }

        public bool CreateBedrooms( List<BedroomModel> p_BedroomModels )
        {
            List<Bedroom> bedrooms = new List<Bedroom>( );

            foreach ( var bedroomModel in p_BedroomModels )
            {
                bedrooms.AddRange( CreateBedroomsByType( bedroomModel.Type, bedroomModel.Actives, bedroomModel.Inactives ) );
            }

            return m_BedroomRepository.Add( bedrooms );
        }

        private List<Bedroom> CreateBedroomsByType( eBedroomType p_Type, int p_Actives, int p_Inactives )
        {
            List<Bedroom> bedrooms = new List<Bedroom>( );

            for ( int i = 1; i <= ( p_Actives + p_Inactives ); i++ )
            {
                if ( i <= p_Actives )
                {
                    bedrooms.Add( new Bedroom( )
                    {
                        Active = true,
                        Type = p_Type
                    });
                }
                else
                {
                    bedrooms.Add( new Bedroom( )
                    {
                        Active = false,
                        Type = p_Type
                    } );
                }
            }

            return bedrooms;
        }
    }
}

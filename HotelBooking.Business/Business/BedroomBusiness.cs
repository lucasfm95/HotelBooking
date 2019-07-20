using HotelBooking.Business.Business.Interfaces;
using HotelBooking.Domain.Entities;
using HotelBooking.Domain.Model;
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

        public bool CreateBedrooms( BedroomModel p_BedroomModel )
        {

            long id = 1;
            List<Bedroom> bedrooms = new List<Bedroom>( );

            for ( int i = 0; i < p_BedroomModel.ActiveSigle; i++ )
            {
                bedrooms.Add( new Bedroom( )
                {
                    Id = id,
                    Type = Domain.ValueObj.eBedroomType.Single,
                    Active = true
                } );

                id++;
            }

            for ( int i = 0; i < p_BedroomModel.ActiveStandard; i++ )
            {
                bedrooms.Add( new Bedroom( )
                {
                    Id = id,
                    Type = Domain.ValueObj.eBedroomType.Standard,
                    Active = true
                } );

                id++;
            }

            for ( int i = 0; i < p_BedroomModel.ActiveLuxury; i++ )
            {
                bedrooms.Add( new Bedroom( )
                {
                    Id = id,
                    Type = Domain.ValueObj.eBedroomType.Luxury,
                    Active = true
                } );

                id++;
            }

            for ( int i = 0; i < p_BedroomModel.InactiveSingle; i++ )
            {
                bedrooms.Add( new Bedroom( )
                {
                    Id = id,
                    Type = Domain.ValueObj.eBedroomType.Single,
                    Active = false
                } );

                id++;
            }

            for ( int i = 0; i < p_BedroomModel.InactiveStandard; i++ )
            {
                bedrooms.Add( new Bedroom( )
                {
                    Id = id,
                    Type = Domain.ValueObj.eBedroomType.Standard,
                    Active = false
                } );

                id++;
            }

            for ( int i = 0; i < p_BedroomModel.InactiveLuxury; i++ )
            {
                bedrooms.Add( new Bedroom( )
                {
                    Id = id,
                    Type = Domain.ValueObj.eBedroomType.Luxury,
                    Active = false
                } );

                id++;
            }

            return m_BedroomRepository.Add( bedrooms );
        }
    }
}

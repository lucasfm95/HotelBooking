using HotelBooking.Domain.Entities;
using HotelBooking.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Repository.Repositories
{
    public class BedroomRepository : Repository<Bedroom>, IBedroomRepository
    {
        public bool Add(List<Bedroom> bedrooms )
        {
            try
            {
                m_ListData.AddRange( bedrooms );
                return true;
            }
            catch ( Exception ex )
            {
                throw new Exception( "Error add bedroom", ex );
            }
        }
    }
}

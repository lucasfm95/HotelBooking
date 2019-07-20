using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Repository.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll( );
        T GetById( long id );
        T GetByGuid( Guid guid );
        bool Add( params T[] objs );
        bool Update( T objs );
        bool Delete( long id );
    }
}

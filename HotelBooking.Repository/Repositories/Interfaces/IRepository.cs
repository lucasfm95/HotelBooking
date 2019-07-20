using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Repository.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll( );
        T GetById( long id );
        T GetByKey( Guid key );
        bool Add( T obj );
        bool Update( T obj );
        bool Delete( long id );
    }
}

using HotelBooking.Domain.Entities.Interfaces;
using HotelBooking.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Repository.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : IEntity 
    {
        private readonly List<T> m_ListData;
        private object m_ObjFlag = new object( );

        public Repository( )
        {
            if ( m_ListData == null )
            {
                lock ( m_ObjFlag )
                {
                    if ( m_ListData == null )
                    {
                        m_ListData = new List<T>( );
                    }
                }
            }
        }

        public bool Add( T[] objs )
        {
            try
            {
                foreach ( T obj in objs )
                {
                    m_ListData.Add( obj );
                }
                
                return true;
            }
            catch ( Exception ex)
            {
                throw new Exception("Error add object", ex);
            }
        }

        public bool Delete( long id )
        {
            throw new NotImplementedException( );
        }

        public List<T> GetAll( )
        {
            throw new NotImplementedException( );
        }

        public T GetByGuid( Guid guid )
        {
            throw new NotImplementedException( );
        }

        public T GetById( long id )
        {
            throw new NotImplementedException( );
        }

        public bool Update( T objs )
        {
            throw new NotImplementedException( );
        }
    }
}

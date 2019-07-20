using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Domain.Entities
{
    public class Client : Entity
    {
        private static int m_Id = 1;
        public Client( ) : base( )
        {
            Id = m_Id++;
        }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
    }
}

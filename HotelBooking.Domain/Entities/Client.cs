using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace QT.Domain.Model
{
    public class Address
    {
       
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string LocalNumber { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

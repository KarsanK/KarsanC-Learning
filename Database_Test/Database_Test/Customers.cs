using System;
using System.Collections.Generic;


namespace Database_Test
{
    public class Customer
    {
        public Guid _Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EntryDate { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; }
    }


    public class Address
    {
        public Guid CustomerId { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }

    }


}
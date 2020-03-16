using System;
using System.Collections.Generic;

namespace HarrisSons.Net.API.Models
{
    public partial class Businesscontacts
    {
        public int ContactId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostCode { get; set; }
        public string Telephone { get; set; }
        public string BusinessTelephone { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HarrisSons.Net.Data
{
    public class BusinessContact : Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessContactID { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Business Telephone")]
        public string BusinessTelephone { get; set; }

        public int AddressID { get; set; }
        public Address Address { get; set; }
    }
}

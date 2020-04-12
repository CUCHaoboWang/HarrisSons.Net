using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HarrisSons.Net.Data
{
    public class PersonalContact : Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonalContactID { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Home Telephone")]
        public string HomeTelephone { get; set; }

        public int AddressID { get; set; }
        public Address Address { get; set; }
    }
}

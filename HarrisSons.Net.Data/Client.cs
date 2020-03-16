using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HarrisSons.Net.Data
{
    public class Client : Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientID { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name = "First Contact Date")]
        public DateTime? FirstContactDate { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name = "Last Contact Date")]
        public DateTime? LastContactDate { get; set; }

        public int PersonalContactID { get; set; }
        public PersonalContact PersonalContact { get; set; }
    }
}

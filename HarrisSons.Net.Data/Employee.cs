using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HarrisSons.Net.Data
{
    public class Employee : Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        [Required]
        [Display(Name = "Insurance Number")]
        public string NationalInsuranceNumber { get; set; }
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name = "Date Hired")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Position")]
        public int PositionID { get; set; }
        public Position Position { get; set; }
        public int BusinessContactID { get; set; }
        public BusinessContact BusinessContact { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HarrisSons.Net.Data
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Group Name")]
        public string GroupName { get; set; }

        public ICollection<Position> Positions { get; set; }
    }
}

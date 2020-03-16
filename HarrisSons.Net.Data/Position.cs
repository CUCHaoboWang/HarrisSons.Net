using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HarrisSons.Net.Data
{
    public class Position
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PositionID { get; set; }
        [Required]
        public string Name { get; set; }

        public int DepartmentID { get; set; }
        public Department Department { get; set; }
        public int PayRateID { get; set; }
        public PayRate PayRate { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}

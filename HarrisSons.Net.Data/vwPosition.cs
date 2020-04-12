using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HarrisSons.Net.Data
{
    [Table("vwPosition")]
    public class vwPosition
    {
        [Key]
        public int PositionID { get; set; }
        public string Position { get; set; }
        public int DepartmentID { get; set; }
        public string Department { get; set; }
        public string GroupName { get; set; }
        public int PayRate { get; set; }
    }
}

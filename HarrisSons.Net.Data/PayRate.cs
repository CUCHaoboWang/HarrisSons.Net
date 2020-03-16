using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HarrisSons.Net.Data
{
    public class PayRate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PayRateID { get; set; }
        [Required]
        public int Rank { get; set; }

        public ICollection<Position> Positions { get; set; }
    }
}

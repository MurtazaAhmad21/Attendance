using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace AttendanceMgmtFYP.Models
{
    public partial class DaysOfWeek
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DayId { get; set; }
        public string DayName { get; set; }
    }
}

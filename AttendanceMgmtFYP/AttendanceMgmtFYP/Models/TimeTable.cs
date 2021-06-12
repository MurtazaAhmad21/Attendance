using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace AttendanceMgmtFYP.Models
{
    public partial class TimeTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TimeTableId { get; set; }
        public int? TeacherId { get; set; }
        public int? DayId { get; set; }
        public string _08301000 { get; set; }
        public string _10001130 { get; set; }
        public string _11300100 { get; set; }
        public string _01300300 { get; set; }
        public string _03000430 { get; set; }
        public string _06000800 { get; set; }
        public string _08001000 { get; set; }
    }
}

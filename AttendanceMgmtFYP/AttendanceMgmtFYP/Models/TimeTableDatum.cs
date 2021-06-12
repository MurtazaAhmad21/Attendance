using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace AttendanceMgmtFYP.Models
{
    public partial class TimeTableDatum
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TimeTableId { get; set; }
        public string ModifiedDate { get; set; }
        public string CreatedDate { get; set; }
        public string TimeIn08301000 { get; set; }
        public string TimeOut08301000 { get; set; }
        public string _08301000 { get; set; }
        public string TimeIn10001130 { get; set; }
        public string TimeOut10001130 { get; set; }
        public string _10001130 { get; set; }
        public string TimeIn11300100 { get; set; }
        public string TimeOut11300100 { get; set; }
        public string _11300100 { get; set; }
        public string TimeIn01300300 { get; set; }
        public string TimeOut01300300 { get; set; }
        public string _01300300 { get; set; }
        public string TimeIn03000430 { get; set; }
        public string TimeOut03000430 { get; set; }
        public string _03000430 { get; set; }
        public string TimeIn06000800 { get; set; }
        public string TimeOut06000800 { get; set; }
        public string _06000800 { get; set; }
        public string TimeIn08001000 { get; set; }
        public string TimeOut08001000 { get; set; }
        public string _08001000 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace AttendanceMgmtFYP.Models
{
    public partial class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cnic { get; set; }
        public string Designation { get; set; }
        public string Gender { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string Image { get; set; }
        public string OrignalFileName { get; set; }
        public string FileName { get; set; }
    }
}

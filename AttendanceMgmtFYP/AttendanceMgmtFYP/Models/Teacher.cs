using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceMgmtFYP.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CNIC { get; set; }
        public string Designation { get; set; }
        public string gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Image { get; set; }
        public string OrignalFileName { get; set; }
        public string FileName { get; set; }
    }
}

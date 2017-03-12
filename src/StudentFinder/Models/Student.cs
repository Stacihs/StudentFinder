using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace StudentFinder.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int StudentsSchool { get; set; }
        [Required]
        public string StudentSchoolId { get; set; }
        [Required]
        public string fName { get; set; }
        [Required]
        public string lName { get; set; }
        [Required]
        public string GradeLevel { get; set; }

        //public virtual Student Students { get; set; }
        public ICollection<StudentScheduleSpace> StudentScheduleSpace { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentFinder.Models
{
    public class Schedule
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Label { get; set; }
        [Required]
        public string From { get; set; }
        [Required]
        public string To { get; set; }

        public ICollection<StudentScheduleSpace> StudentScheduleSpace { get; set; }
        //public virtual Schedule Schedules { get; set; }
    }
}

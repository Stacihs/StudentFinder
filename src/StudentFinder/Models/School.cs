using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentFinder.Models
{
    public class School
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        public string Domain { get; set; }

        //public TimeZoneInfo TimeZone { get; set; }

    }
}

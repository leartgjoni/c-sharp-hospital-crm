using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPatient.Models
{
    public class Timetable
    {
        public int Id { get; set; }

        [Required]
        [Range(1,7)]
        public int DayOfTheWeek { get; set; }
        
        public DateTime? StartTime { get; set; }
        
        public DateTime? EndTime { get; set; }

        [Required]
        public bool DayOff { get; set; }
        
        [Required]
        [Display(Name = "User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPatient.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public bool Paid { get; set; }

        [Required]
        public bool Done { get; set; }

        public string Recipe { get; set; }

        public Byte[] File { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }

        [Required]
        [Display(Name = "Patient")]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
       
        [Required]
        [Display(Name = "Service")]
        public int ServiceId { get; set; }
        public Service Service { get; set; }       

        [Required]
        [Display(Name = "User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

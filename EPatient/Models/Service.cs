using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPatient.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Duration { get; set; }
       
        [Required]
        [Display(Name = "Pavilion")]
        public int PavilionId { get; set; }
        public Pavilion Pavilion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPatient.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public List<User> Users { get; set; }

        public const byte Admin = 1;
        public const byte Operator = 2;
        public const byte Doctor = 3;
        public const byte Nurse = 4;

    }
}

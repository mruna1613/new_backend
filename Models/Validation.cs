using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace new_backend.Models
{
    public class Validation
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter the name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter the password")]
        public string password { get; set; }
    }
}

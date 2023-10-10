using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace new_backend.Models
{
    public class SignUpModel
    {
        [Required]
        public string Name {  get; set; }
        [Required]
        [EmailAddress]
        public string EMail { get; set; }
        [Required]
        public string password { get; set; }
    }
}

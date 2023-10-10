using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace new_backend.Models
{
    public class AppUser : IdentityUser
    {
        public string Name {  get; set; } 

        public string password {  get; set; }
    }
}

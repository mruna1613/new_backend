using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using new_backend.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace new_backend.Data
{
    public class AttendanceContext : IdentityDbContext<AppUser>
    {
        public AttendanceContext(DbContextOptions<AttendanceContext> options)
            : base(options)
        { 

        }

        public DbSet<loginDetails> loginDetails { get; set; }

   
    }
}

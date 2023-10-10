using Microsoft.EntityFrameworkCore;

namespace new_backend.Data
{
    public class IdentityDbContext
    {
        private DbContextOptions<AttendanceContext> options;

        public IdentityDbContext(DbContextOptions<AttendanceContext> options)
        {
            this.options = options;
        }
    }
}
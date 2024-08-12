using LogXPTest.Model;
using Microsoft.EntityFrameworkCore;

namespace LogXPTest.Data
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<AttendanceLogs> AttendanceLogs { get; set; }
    }
}

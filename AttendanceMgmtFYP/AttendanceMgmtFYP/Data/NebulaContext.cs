
using Microsoft.EntityFrameworkCore;
using AttendanceMgmtFYP.Models;

namespace AttendanceMgmtFYP.Data
{
    public class Context : DbContext 
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
          
        }
        public DbSet<users>  Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
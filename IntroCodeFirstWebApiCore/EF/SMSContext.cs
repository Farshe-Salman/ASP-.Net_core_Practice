using IntroCodeFirstWebApiCore.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace IntroCodeFirstWebApiCore.EF
{
    public class SMSContext : DbContext
    {
        public SMSContext(DbContextOptions<SMSContext> options) 
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set;  }
        public DbSet<Course> Courses { set; get; }

        public DbSet<Department> Departments { get; set; }


    }
}

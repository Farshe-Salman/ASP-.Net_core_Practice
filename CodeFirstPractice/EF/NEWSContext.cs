using CodeFirstPractice.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstPractice.EF
{
    public class NEWSContext: DbContext
    {
        public NEWSContext(DbContextOptions<NEWSContext> options) : base(options)
        {
        }

        public DbSet<Models.Category> Categories { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace CodeFirstExercise.EF
{
    public class NEWSContext : DbContext
    {
        public NEWSContext(DbContextOptions<NEWSContext> options) : base(options)
        {
        }
        public DbSet<Models.News> News { get; set; }
        public DbSet<Models.Cateory> Cateories { get; set; }

    }
}

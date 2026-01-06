using DAL.EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class PMSContext : DbContext
    {
        public PMSContext(DbContextOptions<PMSContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }


    }
}

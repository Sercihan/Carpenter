using Carpenter.ORM.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carpenter.ORM.Context
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JUDGMENTDAY; Database=CarpenterDB; Integrated Security=True; TrustServerCertificate=True");
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
        public DbSet<Team> teams { get; set; }
    }
}

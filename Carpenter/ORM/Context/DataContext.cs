using Microsoft.EntityFrameworkCore;

namespace Carpenter.ORM.Context
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JUDGMENTDAY; Database=CarpenterDB; Integrated Security=True; TrustServerCertificate=True");
        }
    }
}

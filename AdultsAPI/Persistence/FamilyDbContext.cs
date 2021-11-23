using AdultsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AdultsAPI.Persistence
{
    public class FamilyDbContext : DbContext
    {
        public DbSet<Adult> Adults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Adult.db");
        }

    }

}

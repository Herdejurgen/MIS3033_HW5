using Microsoft.EntityFrameworkCore;
using MIS3033_HW5.Models;

namespace MIS3033_HW5.Data
{
    public class DbConnect:DbContext
    {
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=129.15.67.240;Database=Hw5herd0001;Port=5432;Username=herd0001;Password=J8x5fYOzgyhpJMPR50p5");
    }
}

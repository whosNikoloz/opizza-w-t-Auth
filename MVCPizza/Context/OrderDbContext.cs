using Microsoft.EntityFrameworkCore;
using MVCPizza.Models;

namespace MVCPizza.Context
{
    public class OrderDbContext : DbContext
    {
        public DbSet<OrderModel> Orders { get; set; }
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderModel>()
                .Property(o => o.FinalPrice)
                .HasColumnType("decimal(18,2)");

            // Other configuration code...

            base.OnModelCreating(modelBuilder);
        }

    }
}

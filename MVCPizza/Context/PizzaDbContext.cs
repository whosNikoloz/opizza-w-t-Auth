using Microsoft.EntityFrameworkCore;
using MVCPizza.Models;

namespace MVCPizza.Context
{
    public class PizzaDbContext :DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }

        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options)
        {

        }
    }
}

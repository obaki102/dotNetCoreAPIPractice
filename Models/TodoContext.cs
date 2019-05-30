using TodoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class ToDoContext : DbContext
    {

        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {

        }
        //public DbSet<Customer> Customers { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Customer>().ToTable("DimCustomer");
            modelBuilder.Entity<Currency>().ToTable("DimCurrency");

        }

    }
}
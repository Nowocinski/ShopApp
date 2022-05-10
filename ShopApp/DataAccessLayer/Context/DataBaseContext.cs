using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
    public class DataBaseContext : DbContext
    {

        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(key => key.Id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=LAPTOP-RN2RML2L\SQLEXPRESS;Database=ShopAppDB;Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        public DbSet<Customer> Customer { get; set; }
    }
}

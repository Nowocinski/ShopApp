using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
    public class DataBaseContext : DbContext
    {
        private static DataBaseContext _instance = null;
        public static DataBaseContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataBaseContext();
                }
                return _instance;
            }
        }

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

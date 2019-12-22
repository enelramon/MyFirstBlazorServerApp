using MyFirstBlazorServerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MyFirstBlazorServerApp.Data
{
    public class Context : DbContext
    {
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Payouts> PayOuts { get; set; }

        //public Context(DbContextOptions<Context> options) : base(options)
        //{

        //} 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server = (Local); Database = TestDb; Trusted_Connection = True;");

        }
    }
}

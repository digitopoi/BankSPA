using Microsoft.EntityFrameworkCore;
using BankSPA.Models;

namespace BankSPA.Data
{
    public class BankDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
        {
    
        }
    }
}

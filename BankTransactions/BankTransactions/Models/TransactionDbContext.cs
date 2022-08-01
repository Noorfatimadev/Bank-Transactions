using Microsoft.EntityFrameworkCore;

namespace BankTransactions.Models
{
    public class TransactionDbContext:DbContext
    {
        //constructor
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options) // pass same parameter tpo base
        {

        }

        //physical db
        public DbSet<Transaction> Transactions { get; set; }
    }
}

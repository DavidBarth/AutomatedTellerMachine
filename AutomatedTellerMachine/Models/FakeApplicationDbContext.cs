using System.Data.Entity;

namespace AutomatedTellerMachine.Models
{
    public class FakeApplicationDbContext : IApplicationDbContext
    {
        public IDbSet<CheckingAccount> CheckingAccounts { get; set; }
       
           

        public IDbSet<Transaction> Transactions { get; set; }
       

        public int SaveChanges()
        {
            return 0;
        }
    }
}
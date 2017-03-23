using System.Data.Entity;

namespace AutomatedTellerMachine.Models
{
    public interface IApplicationDbContext
    {
        //using IDbSet for not committing to a DB directly
        IDbSet<CheckingAccount> CheckingAccounts { get; set; }
        IDbSet<Transaction> Transactions { get; set; }

        int SaveChanges(); //the method wee call in the 
    }
}

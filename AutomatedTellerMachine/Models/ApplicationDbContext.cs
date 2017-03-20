using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace AutomatedTellerMachine.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        
        //generic DbSet to use the member to exposes CheckingAccount data 
        public DbSet<CheckingAccount> CheckingAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        
    }
   

}
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using AutomatedTellerMachine.Controllers;

namespace AutomatedTellerMachine.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        
        //generic DbSet to use the member to exposes CheckingAccount data 

        //IDbSet to use 
        public IDbSet<CheckingAccount> CheckingAccounts { get; set; }

        public IDbSet<Transaction> Transactions { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        
    }
   

}
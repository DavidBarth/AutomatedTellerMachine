using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AutomatedTellerMachine.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        
        //generic DbSet to use the member to exposes CheckingAccount data 
        public DbSet<CheckingAccount> CheckingAccounts { get; set; }


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
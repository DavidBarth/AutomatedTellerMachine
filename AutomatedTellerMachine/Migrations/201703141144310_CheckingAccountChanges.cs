namespace AutomatedTellerMachine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckingAccountChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountNumber", c => c.String(maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountNumber", c => c.String());
        }
    }
}

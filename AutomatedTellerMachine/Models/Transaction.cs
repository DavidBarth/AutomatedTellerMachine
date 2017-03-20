using System.ComponentModel.DataAnnotations;

namespace AutomatedTellerMachine.Models
{
    public class Transaction
    {
        //primary key
        public int Id { get; set; }

        //amount to be added or deducted
        [Required]
        [DataType(DataType.Currency)]
        public decimal AmountDecimal { get; set; }

        //property that will correspond to foreign key in the db
        //that identifies the checking account of the logged in user
        public int CheckingAccountId { get; set; }
        //navigation property for the related checking account EF sets this up as foreign key
        public CheckingAccount CheckingAccount { get; set; }

    }
}
namespace AutomatedTellerMachine.Models
{
    public class CheckingAccount
    {
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
    }
}
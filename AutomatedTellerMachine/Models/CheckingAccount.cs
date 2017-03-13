using System.ComponentModel.DataAnnotations;

namespace AutomatedTellerMachine.Models
{
    public class CheckingAccount
    {
        //primary key
        public int Id { get; set; }

        [RegularExpression(@"\d{6,10}", ErrorMessage = "Account number must be between 6 and 10 digits.")]
        [Display(Name="Account Number")]
        public string AccountNumber { get; set; }

        [Display(Name="First Name")]
        public string FirstName  { get; set; }

        [Display(Name="Last Name")]
        public string LastName { get; set; }

        /*public string Name 
         * {
         *    get
         *    {
         *      return string.Format("{0} {1}", this.firstName, this.lastName);
         *    }
         * }
         * */
        public string Name => $"{FirstName} {LastName}"; //combines first and last name - string interpolation, expression body

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
    }
}
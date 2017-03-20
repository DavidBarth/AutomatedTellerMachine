using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomatedTellerMachine.Models
{
    public class CheckingAccount
    {
        //primary key
        public int Id { get; set; }

        // [RegularExpression(@"\d{6,10}", ErrorMessage = "Account number must be between 6 and 10 digits.")]
        [StringLength(10)]
        [Display(Name="Account Number")]
        [Column(TypeName = "varchar")]
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
        //combines first and last name - string interpolation, expression body
        public string Name => $"{FirstName} {LastName}"; 

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        //for assigning a User object
        public virtual  ApplicationUser User { get; set; }

        //foreign key property of the related applicationuser entity
        [Required]
        public string ApplicationUserId { get; set; }

        //nav property to tansactions to access the collections
        //of transactions associated to a given checking account
        public virtual  ICollection<Transaction> Transactions { get; set; }
    }
}
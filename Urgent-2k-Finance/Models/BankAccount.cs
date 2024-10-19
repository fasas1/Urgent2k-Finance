using System.ComponentModel.DataAnnotations;

namespace Urgent_2k_Finance.Models
{
    public class BankAccount
    {
        [Key]
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }
        public string? UserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; } // Foreign key to ApplicationUser
    }

}

using Microsoft.AspNetCore.Identity;

namespace Urgent_2k_Finance.Models
{
    public class ApplicationUser :IdentityUser
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KYCStatus { get; set; }
  

    }
}

namespace Urgent_2k_Finance.Models.Dto
{
    public class RegisterRequestDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
    }
}

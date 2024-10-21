using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Urgent_2k_Finance.Models;
using Urgent_2k_Finance.Models.Dto;
using Urgent_2k_Finance.Repository.IRepository;

namespace Urgent_2k_Finance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private readonly IBankAccountRepository _bankRepo;

        private readonly UserManager<ApplicationUser> _userManager;
        public BankAccountController(IBankAccountRepository bankRepo, UserManager<ApplicationUser> userManager)
        {
            _bankRepo = bankRepo;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<ActionResult> GetAccounts()
        {
            var accountList = await _bankRepo.GetAllAsync(
                    includeProperties: "ApplicationUser");
            return Ok(accountList);
        }

       [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequestDto model)
    {
        var user = new ApplicationUser
        {
            UserName = model.Email,
            Email = model.Email,
            FullName = model.FullName,
            DateOfBirth = model.DateOfBirth,
            KYCStatus = "Pending" // Default status for KYC
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            // On successful signup, create a bank account
            await _bankRepo.CreateAccountAsync(user);
            return Ok(new { message = "User registered successfully" });
        }

          return BadRequest(result.Errors);
      }

        [HttpPost("kyc")]
        public async Task<IActionResult> VerifyKYC([FromBody] KycDto model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);

            if (user == null) return NotFound("User not found");

            // Example KYC verification logic
            if (model.DocumentVerified)
            {
                user.KYCStatus = "Verified";
                await _userManager.UpdateAsync(user);
                return Ok(new { message = "KYC verified successfully" });
            }

            return BadRequest("KYC verification failed");
        }


    }
}

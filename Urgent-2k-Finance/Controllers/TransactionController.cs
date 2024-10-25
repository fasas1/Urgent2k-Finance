using Microsoft.AspNetCore.Mvc;

using Urgent_2k_Finance.Models.Dto;
using Urgent_2k_Finance.Repository.IRepository;


namespace Urgent_2k_Finance.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferRepository _transferRepo;


        public TransferController( ITransferRepository transferRepo)
        {
            _transferRepo = transferRepo;
        }

        [HttpPost("initiate")]
        public async Task<IActionResult> InitiateTransfer([FromBody] TransferRequestDto transferRequestDto)
        {
            var result = await _transferRepo.InitiateTransferAsync(transferRequestDto);
            if (result.Status)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpPost("verify")]
        public async Task<IActionResult> VerifyTransfer([FromBody] VerifyTransferDto verifyTransferDto)
        {
            var isSuccess = await _transferRepo.VerifyTransferAsync(verifyTransferDto);
            if (isSuccess)
                return Ok(new { message = "Transfer verified successfully." });
            return BadRequest(new { message = "Transfer verification failed." });
        }
    }
}





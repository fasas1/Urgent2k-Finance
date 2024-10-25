
using Urgent_2k_Finance.Models;
using Urgent_2k_Finance.Models.Dto;
using System.Threading.Tasks;

namespace Urgent_2k_Finance.Repository.IRepository
{
    public interface ITransferRepository : IRepository<Transaction>
    {
        Task<TransferResponseDto> InitiateTransferAsync(TransferRequestDto transferRequestDto);
        Task<bool> VerifyTransferAsync(VerifyTransferDto verifyTransferDto);
    }
}

using System.Linq.Expressions;
using Urgent_2k_Finance.Models;

namespace Urgent_2k_Finance.Repository.IRepository
{
    public interface IBankAccountRepository : IRepository<BankAccount>
    {
        Task<BankAccount> GetByAccountNumberAsync(string accountNumber);
        Task CreateAccountAsync(ApplicationUser user);
    }

}

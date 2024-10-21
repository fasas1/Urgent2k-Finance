using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Urgent_2k_Finance.Data;
using Urgent_2k_Finance.Models;
using Urgent_2k_Finance.Repository.IRepository;

namespace Urgent_2k_Finance.Repository
{
    public class BankAccountRepository : Repository<BankAccount>, IBankAccountRepository
    {
        private readonly ApplicationDbContext _db;
        public BankAccountRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;  
        }
        public async Task CreateAccountAsync(ApplicationUser user)
        {
            var account = new BankAccount
            {
                ApplicationUserId = user.Id,
                AccountNumber = GenerateAccountNumber(),
                Balance = 0,
                AccountType = "Savings"
            };

            await _db.BankAccounts.AddAsync(account);
            await _db.SaveChangesAsync();
        }

        private string GenerateAccountNumber()
        {
            return new Random().Next(1000000000, 1999999999).ToString();
        
        }

        public Task<BankAccount> GetByAccountNumberAsync(string accountNumber)
        {
            throw new NotImplementedException();
        }
    }
}

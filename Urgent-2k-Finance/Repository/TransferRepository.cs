using Paystack.Net.SDK;
using Paystack.Net.SDK.Models.Transfers.Initiation;
using Paystack.Net.SDK.Models.Transfers.TransferDetails;
using Paystack.Net.SDK.Transfers;
using Urgent_2k_Finance.Models;
using Urgent_2k_Finance.Models.Dto;
using Urgent_2k_Finance.Repository.IRepository;
using Urgent_2k_Finance.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace Urgent_2k_Finance.Repository
{
    public class TransferRepository : Repository<Transaction>, ITransferRepository
    {
        private readonly PaystackTransfers _paystackTransfers;
        private readonly ApplicationDbContext _db;

        public TransferRepository(IConfiguration configuration, ApplicationDbContext db) : base(db)
        {
            _db = db;
            var paystackSecretKey = configuration["Paystack:SecretKey"];
            _paystackTransfers = new PaystackTransfers(paystackSecretKey);
        }

        public async Task<TransferResponseDto> InitiateTransferAsync(TransferRequestDto transferRequestDto)
        {
            try
            {
                // Initiate transfer using Paystack SDK
                var transferInitiationModel = await _paystackTransfers.InitiateTransfer(
                    amount: (int)(transferRequestDto.Amount * 100),  // Convert amount to kobo for Paystack
                    recipient_code: transferRequestDto.RecipientCode,
                    source: transferRequestDto.Source,
                    currency: transferRequestDto.Currency,
                    reason: transferRequestDto.Reason
                );

                if (transferInitiationModel.status)
                {
                    return new TransferResponseDto
                    {
                        Status = true,
                        Message = "Transfer initiated successfully",
                        TransferDate = transferInitiationModel.data.createdAt
                    };
                }

                return new TransferResponseDto
                {
                    Status = false,
                    Message = transferInitiationModel.message
                };
            }
            catch (Exception ex)
            {
                // Log exception (use logger in real application)
                return new TransferResponseDto
                {
                    Status = false,
                    Message = $"Error initiating transfer: {ex.Message}"
                };
            }
        }

        public async Task<bool> VerifyTransferAsync(VerifyTransferDto verifyTransferDto)
        {
            try
            {
                var response = await _paystackTransfers.FinalizeTransfer(verifyTransferDto.TransferCode, verifyTransferDto.Otp);
                return response.Contains("success");
            }
            catch (Exception ex)
            {
                // Log exception (use logger in real application)
                return false;
            }
        }
    }
}

namespace Urgent_2k_Finance.Models.Dto
{

        public class TransferRequestDto
        {
            public string RecipientCode { get; set; }
            public decimal Amount { get; set; }
            public string Source { get; set; } = "balance";
            public string Currency { get; set; } = "NGN";
            public string Reason { get; set; }
        }
    }


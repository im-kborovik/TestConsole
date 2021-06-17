using System;

namespace Skynet.Dtos.Accounting
{
    public class DepositOrCheckLine
    {
        public string AccountId { get; set; }
        public string CustomerId { get; set; }
        public Decimal Amount { get; set; }
        public string Memo { get; set; }
    }
}
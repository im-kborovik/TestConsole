using System;

namespace Skynet.Dtos.Accounting
{
    public class JournalEntry
    {
        public string PrivateNote { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime DateTime { get; set; }
        public string DebitAccountId { get; set; }
        public string CreditAccountId { get; set; }
        public string Memo { get; set; }
        public Decimal Amount { get; set; }
        public string TransactionClass { get; set; }
        public string DebitCustomerId { get; set; }
        
        public string DebitVendorId { get; set; }
        public string CreditCustomerId { get; set; }
        
        public string CreditVendorId { get; set; }
    }
}
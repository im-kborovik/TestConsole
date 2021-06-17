using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Accounting
{
    public class DepositCheckEntry
    {
        public string PrivateNote { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime DateTime { get; set; }
        public string DepositAccountId { get; set; }
        public string Memo { get; set; }
        public string TransactionClass { get; set; }
        public List<DepositOrCheckLine> PaymentDepositLines { get; set; }
    }
}
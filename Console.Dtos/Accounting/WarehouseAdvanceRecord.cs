using System;

namespace Skynet.Dtos.Accounting
{
    public class WarehouseAdvanceRecord
    {
        public string LoanNumber { get; set; }
        public DateTime TransactionDate { get; set; }
       
        public DateTime DatePosted { get; set; }
        public double TransactionAmount { get; set; }
        public double DepositedToDDA { get; set; }
    }
}
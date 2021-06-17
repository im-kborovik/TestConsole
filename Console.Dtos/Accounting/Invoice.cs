using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Accounting
{
   
    public class Invoice
    {
        public string AccountId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public string FullName { get; set; }
        public string BillToStreetAddress { get; set; }
        public string BillToCity { get; set; }
        public string BillToState { get; set; }
        public string BillToZipCode { get; set; }
        public string BillToCountry { get; set; }

        public string Memo { get; set; }
        public List<InvoiceLineItem> LineItems { get; set; }
        public string LoanNumber { get; set; }
        public int InvoiceNumber { get; set; }
        public string PrivateNote { get; set; }
        
        public string ReferenceNumber { get; set; }
    }

    public class InvoiceLineItem
    {
        public Decimal Rate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Item { get; set; }
    }
}
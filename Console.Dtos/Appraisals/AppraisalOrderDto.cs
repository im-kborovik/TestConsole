using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.Appraisals
{
    public class AppraisalOrderDto
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string LoanIdentifier { get; set; }
        public int AMCIdentifier { get; set; }
        public string AMCOrderNumber { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

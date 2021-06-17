using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.Appraisals
{
    public class AppraisalProductsDto
    {
        public Guid Id { get; set; }
        public AppraisalVendors AppraisalVendor { get; set; }
        public Guid ComapnyId { get; set; }
        public int AMCIdentifier { get; set; }
        public string AMCProductIdentifier { get; set; }
        public decimal AMCFee { get; set; }
    }
}

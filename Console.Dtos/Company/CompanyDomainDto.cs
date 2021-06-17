using System;
using Skynet.Shared.Company;

namespace Skynet.Dtos.Company
{
    public class CompanyDomainDto
    {
        public Guid CompanyId { get; set; }
        public string DomainName { get; set; }
        public DomainType Type { get; set; }
    }
}
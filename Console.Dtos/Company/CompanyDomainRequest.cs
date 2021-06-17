using Skynet.Shared.Company;

namespace Skynet.Dtos.Company
{
    public class CompanyDomainRequest
    {
        public string DomainName { get; set; }
        public DomainType Type { get; set; }
    }
}
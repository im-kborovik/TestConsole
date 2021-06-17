using System;

namespace Skynet.Dtos.Company
{
    public class CompanyUpdateRequest:CompanyCreateRequest
    {
        public Guid CompanyId { get; set; }
    }
}

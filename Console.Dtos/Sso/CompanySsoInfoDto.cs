using System;

namespace Skynet.Dtos.Sso
{
    //note vv: we don't want to return filled data (like certificate) to front-end for security reasons
    public class CompanySsoInfoDto
    {
        public Guid CompanySsoInfoId { get; set; }
        public Guid CompanyId { get; set; }
    }
}

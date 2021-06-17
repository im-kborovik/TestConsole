using System;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.Sso
{
    public class CompanySsoInfoDataDto : CompanySsoInfoDataRequestDto, ITenantDto
    {
        public Guid CompanyId { get; set; }
    }
}
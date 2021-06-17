using System;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.Accounting
{
    public class AccountingSettingDto : AccountingSettingRequest, ITenantDto
    {
        public Guid CompanyId { get; set; }
    }
}
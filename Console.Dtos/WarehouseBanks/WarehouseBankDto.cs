using System;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.WarehouseBanks
{
    public class WarehouseBankDto : WarehouseBankRequestDto, ITenantDto
    {
        public Guid WarehouseBankId { get; set; }
        public Guid CompanyId { get; set; }
    }
}
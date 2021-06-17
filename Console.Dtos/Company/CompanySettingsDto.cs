using System;

namespace Skynet.Dtos.Company
{
    public class CompanySettingsDto
    {
        public Guid CompanyId { get; set; }
        public bool IsTelephonyEnabled { get; set; }
    }
}
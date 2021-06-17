using System;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.ApplyForm
{
    public class ApplyFormUiSettingDto : ApplyFormUiSettingRequestDto, ITenantDto
    {
        public Guid ApplyFormUiSettingId { get; set; }

        public Guid CompanyId { get; set; }
    }
}
using System;
using Skynet.Dtos.ApplyForm.LoanEditor;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationAssetDto : ApplicationAssetRequestDto, ITenantDto, IApplicationSubEntityDto
    {
        public Guid AssetId { get; set; }

        public Guid ApplicationId { get; set; }

        public Guid CompanyId { get; set; }

        public int OrderNumber { get; set; }
    }
}
using System;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.Documents.Bundles
{
    public class DocumentBundleTypeDto : DocumentBundleTypeRequest, ITenantDto
    {
        public Guid CompanyId { get; set; }
    }
}
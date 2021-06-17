using System;
using Skynet.Dtos.ApplyForm.LoanEditor;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationDeclarationDto : ApplicationDeclarationRequestDto, ITenantDto, IApplicationSubEntityDto
    {
        public Guid ApplicationId { get; set; }

        public Guid DeclarationId { get; set; }

        public Guid CompanyId { get; set; }
    }
}
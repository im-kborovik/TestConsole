using System;
using Skynet.Dtos.ApplyForm.LoanEditor;
using Skynet.Dtos.Common;
using Skynet.Shared.ApplyForm;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationTitleHolderDto : OrderedDto, ITenantDto, IApplicationSubEntityDto
    {
        public Guid TitleHolderId { get; set; }

        public Guid ApplicationId { get; set; }

        public Guid CompanyId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public PersonSuffix? Suffix { get; set; }

        public string CellPhoneNumber { get; set; }

        public string Email { get; set; }
    }
}
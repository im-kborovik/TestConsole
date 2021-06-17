using System;
using System.Collections.Generic;
using Skynet.Dtos.Attributes.DynamicFields;
using Skynet.Dtos.Common;
using Skynet.Shared.Loan.LoanApplication;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationBorrowerDto : OrderedDto, ITenantDto, IApplicationSubEntityDto
    {
        public Guid BorrowerId { get; set; }

        public Guid ApplicationId { get; set; }

        public Guid CompanyId { get; set; }

        public Guid? PersonId { get; set; }

        public Guid? SpousePersonId { get; set; }

        [DynamicField("Credit Score")]
        public CreditScore? CreditScore { get; set; }

        [DynamicField("Did {0} Live Same Two Years")]
        public bool IsLivedSameTwoYears { get; set; }

        [DynamicField("Is {0} Assets Joint")]
        public bool IsAssetsJoint { get; set; }

        [InstanceDynamicField("Person")]
        public ApplicationPersonDto Person { get; set; }

        [InstanceDynamicField("Spouse Person")]
        public ApplicationPersonDto SpousePerson { get; set; }

        public IReadOnlyCollection<ApplicationAssetDto> Assets { get; set; }

        public IReadOnlyCollection<ApplicationLiabilityDto> Liabilities { get; set; }
    }
}
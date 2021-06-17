using System;
using Skynet.Dtos.Attributes.DynamicFields;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationMilitaryDto : ITenantDto, IApplicationSubEntityDto
    {
        public Guid MilitaryId { get; set; }

        public Guid PersonId { get; set; }

        public Guid ApplicationId { get; set; }

        public Guid CompanyId { get; set; }

        [DynamicField("Is Served")]
        public bool IsServedInMilitary { get; set; }

        [DynamicField("Currently Serving Date")]
        public DateTime? CurrentlyServingDate { get; set; }

        [DynamicField("Currently Serving")]
        public bool IsCurrentlyServing { get; set; }

        [DynamicField("Currently Retired")]
        public bool IsCurrentlyRetired { get; set; }

        [DynamicField("Non Activated Member Of Reserve National Guard")]
        public bool IsNonActivatedMemberOfReserveNationalGuard { get; set; }

        [DynamicField("Surviving Spouse")]
        public bool IsSurvivingSpouse { get; set; }
    }
}
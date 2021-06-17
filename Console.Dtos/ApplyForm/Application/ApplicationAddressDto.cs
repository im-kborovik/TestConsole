using System;
using Skynet.Dtos.Attributes.DynamicFields;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationAddressDto : ITenantDto, IApplicationSubEntityDto
    {
        public Guid AddressId { get; set; }

        public Guid ApplicationId { get; set; }

        public Guid CompanyId { get; set; }

        [DynamicField("Country")]
        public string Country { get; set; }

        [DynamicField("State")]
        public string State { get; set; }

        [DynamicField("Zip")]
        public string Zip { get; set; }

        [DynamicField("City")]
        public string City { get; set; }

        [DynamicField("Street")]
        public string Street { get; set; }

        [DynamicField("Unit")]
        public string Unit { get; set; }
    }
}
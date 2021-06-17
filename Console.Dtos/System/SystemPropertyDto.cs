using System;

namespace Skynet.Dtos.System
{
    public class SystemPropertyDto : SystemPropertyRequestDto
    {
        public Guid? CompanyId { get; set; }
    }
}
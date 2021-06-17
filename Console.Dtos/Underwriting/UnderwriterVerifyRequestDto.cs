using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Underwriting
{
    public class UnderwriterVerifyRequestDto
    {
        public Guid ApplicationId { get; set; }

        public IReadOnlyCollection<Guid> GroupIds { get; set; }
    }
}

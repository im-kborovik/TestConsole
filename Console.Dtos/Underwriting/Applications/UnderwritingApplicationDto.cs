using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Underwriting.Applications
{
    public class UnderwritingApplicationDto
    {
        public Guid ApplicationId { get; set; }
        public DateTime CreatedDate { get; set; }
        public IReadOnlyCollection<string> Borrowers { get; set; }
    }
}

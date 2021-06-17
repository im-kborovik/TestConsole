using System;

namespace Skynet.Dtos.CRM.Lead
{
    public class UserLeadAssignmentRuleDto
    {
        public Guid UserId { get; set; }
        public bool AllowPurchase { get; set; }
        public bool AllowRefi { get; set; }

    }
}

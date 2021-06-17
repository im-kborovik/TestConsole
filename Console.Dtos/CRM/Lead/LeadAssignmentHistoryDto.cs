using System;

namespace Skynet.Dtos.CRM.Lead
{
    public class LeadAssignmentHistoryDto
    {
        public Guid LeadAssignmentHistoryId { get; set; }
        public Guid LeadId { get; set; }
        public Guid? AssignedUserId { get; set; }
        public DateTime AssignedTime { get; set; }
        public DateTime UnassignedTime { get; set; }
        public Guid? PreviousAssignedUserId { get; set; }
    }
}

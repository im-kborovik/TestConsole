namespace Skynet.Dtos.ElsaMessages
{
    public class ResumeBlockedLeadWorkflow
    {
        public ResumeBlockedLeadWorkflow()
        {
        }

        public ResumeBlockedLeadWorkflow(string leadId)
        {
            LeadId = leadId;
        }
        
        public string LeadId { get; set; } = default!;
    }
}
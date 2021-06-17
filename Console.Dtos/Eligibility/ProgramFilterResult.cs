using Skynet.Dtos.Loan;

namespace Skynet.Dtos.Eligibility
{
    public class ProgramFilterResult
    {
        public ProgramDto Program { get; set; }

        public bool IsAllowed { get; set; }

        public string DenialReason  { get; set; }
    }
}
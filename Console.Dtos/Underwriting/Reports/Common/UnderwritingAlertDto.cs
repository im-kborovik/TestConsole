using Skynet.Shared.Underwriting;

namespace Skynet.Dtos.Underwriting.Reports.Common
{
    public class UnderwritingAlertDto
    {
        public string Comment { get; set; }

        public UnderwritingAlertType AlertType { get; set; }
    }
}

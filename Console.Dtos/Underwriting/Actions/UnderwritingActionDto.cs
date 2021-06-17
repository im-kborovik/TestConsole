using Skynet.Shared.Underwriting;
using System.Collections.Generic;

namespace Skynet.Dtos.Underwriting.Actions
{
    public class UnderwritingActionDto
    {
        public string Name { get; set; }

        public UnderwritingActionType Type { get; set; }

        public IReadOnlyCollection<UnderwritingActionArgDto> Args { get; set; }
    }
}

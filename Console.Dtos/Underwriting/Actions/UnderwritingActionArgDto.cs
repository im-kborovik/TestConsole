using Skynet.Shared.Underwriting;

namespace Skynet.Dtos.Underwriting.Actions
{
    public class UnderwritingActionArgDto
    {
        public UnderwritingArgType Type { get; set; }
        public string Key { get; set; }
        public object Value { get; set; }
    }
}

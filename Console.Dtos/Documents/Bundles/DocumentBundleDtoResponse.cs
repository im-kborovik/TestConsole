using System.IO;

namespace Skynet.Dtos.Documents.Bundles
{
    public class DocumentBundleDtoResponse
    {
        public string FileName { get; set; }
        public Stream ContentStream { get; set; }
    }
}

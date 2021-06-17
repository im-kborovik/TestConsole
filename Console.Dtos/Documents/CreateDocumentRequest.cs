using System.IO;

namespace Skynet.Dtos.Documents
{
    public class CreateDocumentRequest : CreateDocumentsRequestBase
    {
        public string FileName { get; set; }

        public Stream ContentStream { get; set; }
    }
}
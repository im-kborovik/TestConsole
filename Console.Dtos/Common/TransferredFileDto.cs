using System.IO;

namespace Skynet.Dtos.Common
{
    public class TransferredFileDto
    {
        public string FileName { get; set; }

        public Stream ContentStream { get; set; }
    }
}
using System.Collections.Generic;
using Skynet.Dtos.Common;

namespace Skynet.Dtos.Documents
{
    public class CreateMultipleDocumentsRequest: CreateDocumentsRequestBase
    {
        public IReadOnlyCollection<TransferredFileDto> Files { get; set; }
    }
}
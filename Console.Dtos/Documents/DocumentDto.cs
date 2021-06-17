using System;
using Skynet.Shared.Document;

namespace Skynet.Dtos.Documents
{
    public class DocumentDto
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public Guid LoanId { get; set; }

        public Guid DocumentTypeId { get; set; }

        public string FileName { get; set; }

        public int PagesCount { get; set; }

        public DateTime CreatedDate { get; set; }

        public ProcessingStatus Status { get; set; }
    }
}
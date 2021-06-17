using System;

namespace Skynet.Dtos.Documents
{
    public abstract class CreateDocumentsRequestBase
    {
        public Guid CompanyId { get; set; }

        public Guid LoanId { get; set; }

        public Guid DocumentTypeId { get; set; }

        public Guid UserId { get; set; }

        public Guid? TaskId { get; set; }
    }
}
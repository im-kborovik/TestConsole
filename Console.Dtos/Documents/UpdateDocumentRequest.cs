using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.Documents
{
    public class UpdateDocumentRequest
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public Guid LoanId { get; set; }
        public Guid DocumentTypeId { get; set; }
        public int PagesCount { get; set; }
        public DateTime CreatedDate { get; set; }        
    }
}

using System;
using System.IO;

namespace Skynet.Dtos.Accounting
{
    public class CreateAdvanceFileRequest
    {
        public Guid CompanyId { get; set; }
        public Guid WarehouseBankId { get; set; }
        public Guid? UserId { get; set; }
        public Stream ContentStream { get; set; }
        public string Extension { get; set; }
    }
}
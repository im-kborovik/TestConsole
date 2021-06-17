using System;

namespace Skynet.Dtos.Accounting
{
    public class AdvanceFileDto
    {
        public Guid AdvanceFileId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid WarehouseBankId { get; set; }
    }
}
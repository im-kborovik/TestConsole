using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.Documents
{
    public class DocumentEventDtoResponse
    {
        public Guid DocumentId { get; set; }
        public Guid? UserId { get; set; }
        public string UserName { get; set; }
        public DocumentEventType EventType { get; set; }
        public DateTime EventDate { get; set; }
    }
}

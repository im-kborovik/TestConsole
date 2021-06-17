using System;

namespace Skynet.Dtos.ApplyForm.Application
{
    public class ApplicationActiveClientSessionDto
    {
        public Guid CompanyId { get; set; }
        public Guid ApplicationId { get; set; }
        public Guid ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
    }
}

using System;

namespace Skynet.Dtos.User
{
    public class UserRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public Guid CompanyId { get; set; }
        public string WebTheme { get; set; }
    }
}

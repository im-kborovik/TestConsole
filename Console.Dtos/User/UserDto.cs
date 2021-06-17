using System;
using System.Collections.Generic;
using Skynet.Dtos.Company;

namespace Skynet.Dtos.User
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public Guid CompanyId { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? LastLoggedIn { get; set; }

        public bool Approved { get; set; }

        public bool Enabled { get; set; }
        
        public string WebTheme { get; set; }
        public long HubSpotId { get; set; }
        
        public string PhoneExtension { get; set; }
    }
}

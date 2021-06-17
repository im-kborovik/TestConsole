using System;

namespace Skynet.Dtos.User
{
    public class UserProfileDto
    {
        public Guid UserId { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string WebTheme { get; set; }

        public bool CanChangedWebTheme { get; set; }
    }
}
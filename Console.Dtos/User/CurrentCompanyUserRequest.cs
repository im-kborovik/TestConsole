using System;
    
namespace Skynet.Dtos.User
{
    public class CurrentCompanyUserRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string WebTheme { get; set; }
    }
}
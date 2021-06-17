namespace Skynet.Dtos.User
{
    public class AuthenticatedUserResult
    {
        public string Email { get; set; }
        public bool IsSuccess { get; set; }
        public string FailureReason { get; set; }
        public string Token { get; set; }
        public string WebTheme { get; set; }
        public bool PasswordChangeRequired { get; set; }
    }
}

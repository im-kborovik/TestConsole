namespace Skynet.Dtos.User
{
    public class ChangeTemporaryPasswordRequest
    {
        public string Email { get; set; }
        public string TemporaryPassword { get; set; }
        public string NewPassword { get; set; }
    }
}

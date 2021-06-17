namespace Skynet.Dtos.User
{
    public class ClientSignInRequest
    {
        public string PhoneNumber { get; set; }
        public string VerificationCode { get; set; }
    }
}
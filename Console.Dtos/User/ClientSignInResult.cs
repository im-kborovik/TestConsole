namespace Skynet.Dtos.User
{
    public class ClientSignInResult
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public string Token { get; set; }

        public static ClientSignInResult FromError(string errorMessage)
        {
            return new ClientSignInResult()
                   {
                       IsSuccess = false,
                       ErrorMessage = errorMessage
                   };
        }
    }
}
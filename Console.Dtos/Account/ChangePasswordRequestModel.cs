namespace Skynet.Dtos.Account
{
    public class ChangePasswordRequestModel
    {
        public string OldPassword { get; set; }

        public string NewPassword { get; set; }
    }
}

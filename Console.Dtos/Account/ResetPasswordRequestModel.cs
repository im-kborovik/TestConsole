﻿namespace Skynet.Dtos.Account
{
    public class ResetPasswordRequestModel
    {
        public string Email { get; set; }

        public string Password { get; set; }


        public string Code { get; set; }
    }
}

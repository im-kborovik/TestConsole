using System;

namespace Skynet.Dtos.User
{
    public class BrokerUserRequest : UserRequest
    {
        public Guid BrokerId { get; set; }
    }
}

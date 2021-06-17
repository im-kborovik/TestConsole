using System;

namespace Skynet.Dtos.User
{
    public class BrokerUserDto : UserDto
    {
        public Guid BrokerId { get; set; }
    }
}
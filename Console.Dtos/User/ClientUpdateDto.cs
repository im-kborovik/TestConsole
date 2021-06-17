using System;

namespace Skynet.Dtos.User
{
    public class ClientUpdateDto : ClientRequestDto
    {
        public Guid Id { get; set; }
    }
}